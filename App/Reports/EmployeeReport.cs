using App.Data;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using OfficeOpenXml.Style;
using System.Globalization;
using System.Reflection;
using static OfficeOpenXml.ExcelErrorValue;

namespace App.Reports
{
    public class EmployeeReport : IExcelReport
    {
        public struct Column<T>
        {
            public string Name { get; set; }
            public Func<T, object?> Getter { get; set; }
        }

        RestaurantContext context = new();
        ExcelPackage package = new();

        Employee employee;
        Math_Library.EmployeeSalaryReport report;

        DateTime monthStart;
        DateTime monthEnd;

        string periodString;

        public EmployeeReport(Employee employee, DateTime monthStart, DateTime monthEnd)
        {
            this.employee = employee;
            this.monthStart = monthStart;
            this.monthEnd = monthEnd;
            periodString =
                $"Период: {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthStart.Month)} {monthStart.Year}";

            BuildMainPage();
            BuildAwards();
            BuildFines();
            BuildOvertimePeriods();
            BuildSickPeriods();
        }

        private void BuildMainPage()
        {
            var report = ReportHelper.GetEmployeeSalaryReport(employee, monthStart.Month, monthStart.Year);
            var sheet = CreateSheet("Основные данные");

            // Колонка 1, информация о сотруднике

            int row = 3, rowStart = row;
            int column = 1;

            sheet.Cells[1, 1].Value = "Информация о сотруднике";
            sheet.Cells[2, 1].Value = periodString;

            MainPage_AddRow(sheet, row++, column, "Ф.И.О.", employee.GetFullName());
            MainPage_AddRow(sheet, row++, column, "День рождения", employee.Birthday);
            MainPage_AddRow(sheet, row++, column, "Должность", employee.Role);
            MainPage_AddRow(sheet, row++, column, "Кол-во рабочих часов в день", employee.WorkHoursPerDay);
            MainPage_AddRow(sheet, row++, column, "Кол-во рабочих дней в неделю", employee.WorkDaysPerWeek);
            MainPage_AddRow(sheet, row++, column, "Начало работы на этой должности", employee.RoleWorkStartDate);
            MainPage_AddRow(sheet, row++, column, "Зарплата в рублях в час", employee.BaseSalaryPerHourInRubles);

            SetStyle(sheet.Cells[rowStart, column, row-1, column+1].Style.Border);
            sheet.Column(column).AutoFit();
            sheet.Column(column + 1).AutoFit();

            // Колонка 2, информация о зарплате сотрудника

            row = rowStart;
            column = 4;

            MainPage_AddRow(sheet, row++, column, "Базовая зарплата в месяц", report.BaseSalary);
            MainPage_AddRow(sheet, row++, column, "Количество премий", report.AwardsCount);
            MainPage_AddRow(sheet, row++, column, "Сумма премий", report.AwardsAmount);
            MainPage_AddRow(sheet, row++, column, "Количество сверхурочных часов", report.OvertimeHoursCount);
            MainPage_AddRow(sheet, row++, column, "Оплата за сверхурочные часы", report.OvertimeAmount);
            MainPage_AddRow(sheet, row++, column, "Количество штрафов", report.FinesCount);
            MainPage_AddRow(sheet, row++, column, "Сумма штрафов", report.FinesAmount);
            MainPage_AddRow(sheet, row++, column, "Количество больничных дней", report.SickPeriodsDays);
            MainPage_AddRow(sheet, row++, column, "Снижение за больничные дни", report.SickTax);
            MainPage_AddRow(sheet, row++, column, "Зарплата за месяц", report.SalaryResult);

            SetStyle(sheet.Cells[rowStart, column, row - 1, column + 1].Style.Border);
            sheet.Column(column).AutoFit();
            sheet.Column(column + 1).AutoFit();
        }

        private void MainPage_AddRow(ExcelWorksheet sheet, int row, int column, string name, object? value)
        {
            sheet.Cells[row, column].Value = name;
            sheet.Cells[row, column+1].Value = value;

            if (value != null && value is DateTime)
                sheet.Cells[row, column + 1].Style.Numberformat.Format =
                    DateTimeFormatInfo.CurrentInfo.ShortDatePattern;
        }

        private void BuildAwards()
        {
            var awards = employee.Awards.Where(a => a.AwardDate >= monthStart && a.AwardDate <= monthEnd).ToList();
            var sheet = CreateSheet("Премии");
            sheet.Cells[1, 1].Value = "Премии сотрудника";
            sheet.Cells[2, 1].Value = periodString;
            sheet.Cells[3, 1].Value = "Количество премий: " + awards.Count;

            FillSheet(
                sheet,
                new List<Column<Award>>
                {
                    new() { Name = "Сумма в рублях", Getter = a => a.AmountInRubles },
                    new() { Name = "Дата получения", Getter = a => a.AwardDate },
                    new() { Name = "Причина получения", Getter = a => a.Reason },
                },
                awards,
                rowOffset: 3
            );
        }

        private void BuildFines()
        {
            var fines = employee.Fines.Where(f => f.Date >= monthStart && f.Date <= monthEnd).ToList();
            var sheet = CreateSheet("Штрафы");
            sheet.Cells[1, 1].Value = "Штрафы сотрудника";
            sheet.Cells[2, 1].Value = periodString;
            sheet.Cells[3, 1].Value = "Количество штрафов: " + fines.Count;

            FillSheet(
                sheet,
                new List<Column<Fine>>
                {
                    new() { Name = "Сумма в рублях", Getter = a => a.Amount },
                    new() { Name = "Дата получения", Getter = a => a.Date },
                    new() { Name = "Причина получения", Getter = a => a.Reason },
                    new() { Name = "Выдан", Getter = a => context.Employees.First(e => e.ID == a.GiverID).GetFullName() },
                },
                fines,
                rowOffset: 3
            );
        }

        private void BuildOvertimePeriods()
        {
            var periods = employee.OvertimePeriods.Where(o => o.Date >= monthStart && o.Date <= monthEnd).ToList();
            var sheet = CreateSheet("Сверхурочные часы");
            sheet.Cells[1, 1].Value = "Сверхурочные часы сотрудника";
            sheet.Cells[2, 1].Value = periodString;
            sheet.Cells[3, 1].Value = "Количество сверхурочных периодов: " + periods.Count;

            FillSheet(
                sheet,
                new List<Column<OvertimePeriod>>
                {
                    new() { Name = "Дата", Getter = a => a.Date },
                    new() { Name = "Количество часов", Getter = a => a.OvertimeHoursCount },
                },
                periods,
                rowOffset: 3
            );
        }

        private void BuildSickPeriods()
        {
            var periods = employee.GetSickPeriods().Where(s => s.ContainsOrTouches(monthStart, monthEnd)).ToList();
            var sheet = CreateSheet("Больничные периоды");
            sheet.Cells[1, 1].Value = "Больничные периоды сотрудника";
            sheet.Cells[2, 1].Value = periodString;
            sheet.Cells[3, 1].Value = "Количество больничных периодов: " + periods.Count;

            FillSheet(
                sheet,
                new List<Column<SickPeriod>>
                {
                    new() { Name = "Дата начала", Getter = a => a.DateStart },
                    new() { Name = "Дата конца", Getter = a => a.DateEnd },
                    new() { Name = "Количество дней", Getter = a => Math_Library.Formulas.SickPeriodLength(a.ToMathLibrary()) },
                    new() { Name = "Причина (опционально)", Getter = a => a.Reason },
                },
                periods,
                rowOffset: 3
            );
        }

        private ExcelWorksheet CreateSheet(string name) => package.Workbook.Worksheets.Add(name);

        private void FillSheet<T>(ExcelWorksheet sheet, List<Column<T>> columns, List<T> values, int rowOffset = 0)
        {
            for (int i = 0; i < columns.Count; i++)
            {
                var column = columns[i];
                sheet.Cells[rowOffset + 1, i + 1].Value = column.Name;
            }

            sheet.Cells[rowOffset + 1, 1, rowOffset + 1, columns.Count].Style.Font.Bold = true;

            for (int i = 0; i < values.Count; i++)
            {
                T value = values[i];
                for (int j = 0; j < columns.Count; j++)
                {
                    object? result = columns[j].Getter(value);
                    sheet.Cells[i + 2 + rowOffset, j + 1].Value = result;
                    if (result != null && result is DateTime)
                    {
                        sheet.Cells[i + 2 + rowOffset, j + 1].Style.Numberformat.Format =
                            DateTimeFormatInfo.CurrentInfo.ShortDatePattern;
                    }
                }
            }

            for (int i = 0; i < columns.Count; i++)
                sheet.Column(i + 1).AutoFit();

            SetStyle(sheet.Cells[
                rowOffset + 1, 1,
                rowOffset + 1 + values.Count, columns.Count].Style.Border);
        }

        private static void SetStyle(Border border)
        {
            var style = ExcelBorderStyle.Thin;
            border.Top.Style = style;
            border.Bottom.Style = style;
            border.Left.Style = style;
            border.Right.Style = style;
        }

        public void WriteToFile(string filename) => File.WriteAllBytes(filename, package.GetAsByteArray());
    }
}
