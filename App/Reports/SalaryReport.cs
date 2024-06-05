using App.Data;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Globalization;

namespace App.Reports
{
    public class SalaryReport : IExcelReport
    {
        public struct Column
        {
            public string Name { get; set; }
            public Func<Employee, Math_Library.EmployeeSalaryReport, object?> Getter { get; set; }
        }

        static Column[] columns = {
            new() { Name = "ФИО", Getter = (e, r) => e.GetFullName() },
            new() { Name = "День рождения", Getter = (e, r) => e.Birthday },
            new() { Name = "Должность", Getter = (e, r) => e.Role },
            new() { Name = "Кол-во рабочих часов в день", Getter = (e, r) => e.WorkHoursPerDay },
            new() { Name = "Кол-во рабочих дней в неделю", Getter = (e, r) => e.WorkDaysPerWeek },
            new() { Name = "Дата начала работы на должности", Getter = (e, r) => e.RoleWorkStartDate },
            new() { Name = "Базовая зарплата (в рублях в час)",
                Getter = (e, r) => e.BaseSalaryPerHourInRubles },

            new() { Name = "Базовая зарплата (в рублях в месяц)", Getter = (e, r) => r.BaseSalary },
            new() { Name = "Количество премий", Getter = (e, r) => r.AwardsCount },
            new() { Name = "Сумма премий", Getter = (e, r) => r.AwardsAmount },
            new() { Name = "Количество сверхурочных часов", Getter = (e, r) => r.OvertimeHoursCount },
            new() { Name = "Оплата за сверхурочные часы", Getter = (e, r) => r.OvertimeAmount },
            new() { Name = "Количество штрафов", Getter = (e, r) => r.FinesCount },
            new() { Name = "Сумма штрафов", Getter = (e, r) => r.FinesAmount },
            new() { Name = "Количество больничных дней", Getter = (e, r) => r.SickPeriodsDays },
            new() { Name = "Снижение за больничные", Getter = (e, r) => r.SickTax },

            new() { Name = "Зарплата за месяц (в рублях)", Getter = (e, r) => r.SalaryResult },
        };

        RestaurantContext context = new();
        ExcelPackage package = new();
        ExcelWorksheet sheet;
        int month = 0;
        int year = 0;
        const int rowOffset = 2;

        public SalaryReport(int month, int year)
        {
            this.month = month;
            this.year = year;
            sheet = package.Workbook.Worksheets.Add("Отчёт о зарплатах");

            BuildHeader();
            int employeeCount = BuildEmployeeInfo();
            SetStyle(sheet.Cells[
                rowOffset + 1, 1,
                rowOffset + 1 + employeeCount, columns.Length].Style.Border);

            for (int i = 0; i < columns.Length; i++)
                sheet.Column(i + 1).AutoFit();

            sheet.Cells[1, 1].Value = "Отчёт о зарплатах сотрудников в ресторане";
            sheet.Cells[2, 1].Value = $"Период: {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)} {year}";
        }

        private static void SetStyle(Border border)
        {
            var style = ExcelBorderStyle.Thin;
            border.Top.Style = style;
            border.Bottom.Style = style;
            border.Left.Style = style;
            border.Right.Style = style;
        }

        private void BuildHeader()
        {
            for (int i = 0; i < columns.Length; i++)
            {
                var column = columns[i];
                sheet.Cells[rowOffset+1, i+1].Value = column.Name;
            }

            sheet.Cells[rowOffset+1, 1, rowOffset+1, columns.Length].Style.Font.Bold = true;
        }

        private int BuildEmployeeInfo()
        {
            var employees = context.Employees
                .Include(e => e.Awards)
                .Include(e => e.OvertimePeriods)
                .Include(e => e.Fines)
                .ToList();

            for (int i = 0; i < employees.Count; i++)
            {
                var info = GetEmployeeInfo(employees[i]);
                for (int j = 0; j < columns.Length; j++)
                {
                    object? result = info[j];
                    sheet.Cells[i + 2 + rowOffset, j + 1].Value = info[j];

                    if (result != null && result is DateTime)
                    {
                        sheet.Cells[i + 2 + rowOffset, j + 1].Style.Numberformat.Format =
                            DateTimeFormatInfo.CurrentInfo.ShortDatePattern;
                    }
                }
            }

            return employees.Count;
        }

        private object?[] GetEmployeeInfo(Employee e)
        {
            var report = ReportHelper.GetEmployeeSalaryReport(e, month, year);
            return columns.Select(c => c.Getter(e, report)).ToArray();
        }

        public void WriteToFile(string filename) => File.WriteAllBytes(filename, package.GetAsByteArray());
    }
}
