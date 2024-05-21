namespace Math_Library
{
    public class Formulas
    {
        // Сюда надо передавать кол-во рублей в час, кол-во рабочих часов в день, кол-во рабочих дней в неделю
        public static float BaseSalary(Employee employee)
        {
            if ((employee.WorkHoursPerDay < 0) || (employee.RublesPerHour < 0 ) || (employee.WorkDaysPerWeek < 0)) {
                throw new Exception("У сотрудника отрицательные числа в полях данных.");
            }

            return employee.RublesPerHour * employee.WorkHoursPerDay * employee.WorkDaysPerWeek * 4;
        }

        public static int SickPeriodLength(SickPeriod period) => (period.Finish - period.Start).Days + 1;

        // Сюда надо передавать дату начала и окончания болезни, кол-во рабочих часов в неделю, зарплату за час
        public static float SickTax(Employee employee, List<SickPeriod> periods)
        {
            if ((employee.WorkHoursPerDay < 0) || (employee.RublesPerHour < 0))
            {
                throw new Exception("У сотрудника отрицательные числа в полях данных.");
            }

            float sum = 0;

            foreach (SickPeriod period in periods)
            {
                var dif = SickPeriodLength(period);
                var mis_hours = dif * employee.WorkHoursPerDay;
                sum += mis_hours * employee.RublesPerHour - ((mis_hours * 19242) / (employee.WorkHoursPerDay * employee.WorkDaysPerWeek * 4));
            }

            return sum;
        }

        // Сюда надо передавать количество сверхурочных часов и зарплату за час
        public static float OvertimeSalary(Employee employee, float hours)
        {
            if (employee.RublesPerHour < 0)
            {
                throw new Exception("У сотрудника отрицательные числа в полях данных.");
            }
            else if (hours < 0)
            {
                throw new Exception("Подсчёт сверхурочных часов: отрицательное число часов.");
            }

            return hours * employee.RublesPerHour;
        }

        public static float Salary(Employee employee, float premiiSum, float finesSum, List<SickPeriod> sickPeriods, float overtimeHours)
        {
            if (premiiSum < 0)
            {
                throw new Exception("Подсчёт зарплаты: отрицательная сумма премий.");
            }
            else if (finesSum < 0)
            {
                throw new Exception("Подсчёт зарплаты: отрицательная сумма штрафов.");
            }
            else if (overtimeHours < 0)
            {
                throw new Exception("Подсчёт зарплаты: отрицательная сумма сверхурочных часов.");
            }

            return BaseSalary(employee) - SickTax(employee, sickPeriods) + premiiSum - finesSum + OvertimeSalary(employee, overtimeHours);
        }
    }
}
