using App.Data;

namespace App.Reports
{
    public static class ReportHelper
    {
        public static Math_Library.EmployeeSalaryReport GetEmployeeSalaryReport(Employee e, int month, int year)
        {
            var period = Math_Library.EmployeeSalaryReport.GetMonthPeriod(month, year);
            var (monthStart, monthEnd) = period;

            Math_Library.EmployeeSalaryReport report = new(e.ToMathLibrary(), period,
                e.Awards
                    .Where(a => a.AwardDate >= monthStart && a.AwardDate <= monthEnd)
                    .Select(a => a.AmountInRubles ?? 0).ToList(),
                e.OvertimePeriods
                    .Where(o => o.Date >= monthStart && o.Date <= monthEnd)
                    .Select(o => (int)(o.OvertimeHoursCount ?? 0)).ToList(),
                e.Fines
                    .Where(f => f.Date >= monthStart && f.Date <= monthEnd)
                    .Select(f => f.Amount ?? 0).ToList(),
                e.GetSickPeriods()
                    .Where(s => s.ContainsOrTouches(monthStart, monthEnd))
                    .Select(s => s.ToMathLibrary())
                    .ToList()
                );
            return report;
        }

        public static bool SaveReport(IExcelReport report, string name)
        {
            var SaveFileDialog_Report = new SaveFileDialog
            {
                Title = "Сохранение отчёта",
                Filter = "Файл Excel|*.xlsx"
            };

            if (SaveFileDialog_Report.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    report.WriteToFile(SaveFileDialog_Report.FileName);
                    MessageBox.Show(name + " сохранён в файл "
                        + SaveFileDialog_Report.FileName, "Успешно");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при сохранении отчёта: " + ex.Message, "Ошибка");
                }
            }
            return false;
        }
    }
}
