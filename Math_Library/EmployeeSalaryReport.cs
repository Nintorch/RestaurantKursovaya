namespace Math_Library
{
    public class EmployeeSalaryReport
    {
        public Employee Employee { get; set; }

        public float BaseSalary { get; set; }

        public int AwardsCount { get; set; }
        public int AwardsAmount { get; set; }

        public int OvertimeHoursCount { get; set; }
        public float OvertimeAmount { get; set; }

        public int FinesCount { get; set; }
        public int FinesAmount { get; set; }

        public int SickPeriodsDays { get; set; }
        public float SickTax { get; set; }

        public float SalaryResult { get; set; }

        public DateTime MonthStart { get; set; }
        public DateTime MonthEnd { get; set; }

        public EmployeeSalaryReport(Employee employee, Tuple<DateTime, DateTime> period,
            List<int> awards, List<int> overtimePeriods, List<int> fines, List<SickPeriod> sickPeriods)
        {
            Employee = employee;

            (MonthStart, MonthEnd) = period;

            // Выводим базовую зарплату
            BaseSalary = Formulas.BaseSalary(employee);

            // Выводим сумму и количество премий за определенный год и месяц

            int premiiSum = awards.Sum();
            AwardsCount = awards.Count;
            AwardsAmount = premiiSum;

            // Выводим сумму и количество сверхурочных часов за определенный год и месяц

            int overtimeHours = overtimePeriods.Sum();
            OvertimeHoursCount = overtimeHours;
            OvertimeAmount = Formulas.OvertimeSalary(employee, overtimeHours);

            // Выводим сумму и количество штрафов за определенный год и месяц

            int finesSum = fines.Sum();
            FinesCount = fines.Count;
            FinesAmount = finesSum;

            // Выводим количество больничных и снижение зарплаты за них за определенный год и месяц

            sickPeriods = sickPeriods.Select(s => AdjustSickPeriod(s)).ToList();
            float sickTax = Formulas.SickTax(employee, sickPeriods);
            SickTax = sickTax;
            SickPeriodsDays = sickPeriods.Select(sp => (sp.Finish - sp.Start).Days + 1).Sum();

            // Выводим общую зарплату за определенный год и месяц

            SalaryResult = Formulas.Salary(employee, premiiSum, finesSum, sickPeriods, overtimeHours);
        }

        public SickPeriod AdjustSickPeriod(SickPeriod period)
        {
            // Проверка на null через оператор ??, чтобы компилятор не ругался
            return new(
                period.Start < MonthStart ? MonthStart : period.Start,
                period.Finish > MonthEnd ? MonthEnd : period.Finish
                );
        }

        public static Tuple<DateTime, DateTime> GetMonthPeriod(int month, int year)
            => Tuple.Create(new DateTime(year, month, 1), new DateTime(year, month, DateTime.DaysInMonth(year, month)));
    }
}
