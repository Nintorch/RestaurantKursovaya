using App.Data;
using Microsoft.EntityFrameworkCore;

namespace App
{
    public partial class CalculateSalaryForm : Form
    {
        RestaurantContext context = new();
        Employee employee;
        DateTime monthStart, monthEnd;

        public CalculateSalaryForm(Employee employee)
        {
            InitializeComponent();

            this.employee = context.Employees
                .Include(e => e.Awards)
                .Include(e => e.OvertimePeriods)
                .Include(e => e.Fines)
                .First(e => e.ID == employee.ID);

            Label_EmployeeName.Text = employee.GetFullName();
            ShowEmployeeInformation();

            NumericUpDown_Year.Maximum = DateTime.Now.Year;
            ComboBox_Month.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void ShowEmployeeInformation()
        {
            Label_Role.Text = employee.Role;
            Label_WorkHoursPerDay.Text = employee.WorkHoursPerDay.ToString();
            Label_WorkDaysPerWeek.Text = employee.WorkDaysPerWeek.ToString();
            Label_RoleWorkStartDate.Text = employee.RoleWorkStartDate.ToString()?.Split(' ')[0];
            Label_BaseSalaryPerHour.Text = employee.BaseSalaryPerHourInRubles.ToString();
        }

        private void Button_Calculate_Click(object sender, EventArgs e)
        {
            GroupBox_Results.Enabled = true;
            Label_Period.Text = $"{ComboBox_Month.Text} {NumericUpDown_Year.Value}";

            // Получаем данные о сотруднике в виде объекта для математической библиотеки
            const char rubleChar = 'р';
            Math_Library.Employee mathEmployee = EmployeeToMathLibrary();

            monthStart = new DateTime((int)NumericUpDown_Year.Value, ComboBox_Month.SelectedIndex + 1, 1);
            monthEnd = new DateTime(
                    (int)NumericUpDown_Year.Value,
                    ComboBox_Month.SelectedIndex + 1,
                    DateTime.DaysInMonth((int)NumericUpDown_Year.Value, ComboBox_Month.SelectedIndex + 1));

            // Выводим базовую зарплату
            float baseSalary = Math_Library.Formulas.BaseSalary(mathEmployee);
            Label_BaseSalary.Text = baseSalary.ToString() + rubleChar;

            // Выводим сумму и количество премий за определенный год и месяц

            var awards = employee.Awards.Where(a => a.AwardDate >= monthStart && a.AwardDate <= monthEnd).ToList();
            float premiiSum = awards.Sum(a => a.AmountInRubles ?? 0);

            Label_AwardsCount.Text = awards.Count.ToString();
            Label_AwardsAmount.Text = premiiSum.ToString() + rubleChar;

            // Выводим сумму и количество сверхурочных часов за определенный год и месяц

            var overtimePeriods = employee.OvertimePeriods.Where(o => o.Date >= monthStart && o.Date <= monthEnd).ToList();
            float overtimeHours = overtimePeriods.Sum(o => o.OvertimeHoursCount ?? 0);

            Label_OvertimeHoursCount.Text = overtimeHours.ToString();
            Label_OvertimeHoursPay.Text = Math_Library.Formulas.OvertimeSalary(mathEmployee, overtimeHours).ToString() + rubleChar;

            // Выводим сумму и количество штрафов за определенный год и месяц

            var fines = employee.Fines.Where(f => f.Date >= monthStart && f.Date <= monthEnd).ToList();
            float finesSum = fines.Sum(f => f.Amount ?? 0);

            Label_FinesCount.Text = fines.Count.ToString();
            Label_FinesAmount.Text = finesSum.ToString() + rubleChar;

            // Выводим количество больничных и снижение зарплаты за них за определенный год и месяц

            var sickPeriods = employee.GetSickPeriods().Where(sp => sp.ContainsOrTouches(monthStart, monthEnd)).ToList()
                .Select(sp => AdjustSickPeriod(sp, monthStart, monthEnd)).ToList();

            float sickTax = Math_Library.Formulas.SickTax(mathEmployee, sickPeriods);
            Label_SickTax.Text = sickTax.ToString() + rubleChar;
            Label_SickPeriodsCount.Text = sickPeriods.Select(sp => (sp.Finish - sp.Start).Days + 1).Sum().ToString();

            // Выводим общую зарплату за определенный год и месяц

            Label_Salary.Text =
                Math_Library.Formulas.Salary(mathEmployee, premiiSum, finesSum, sickPeriods, overtimeHours).ToString()
                + rubleChar;

            MessageBox.Show($"Зарплата для сотрудника \"{employee.GetFullName()}\" была успешно рассчитана!");
        }

        public static Math_Library.SickPeriod AdjustSickPeriod(SickPeriod period, DateTime monthStart, DateTime monthEnd)
        {
            // Проверка на null через оператор ??, чтобы компилятор не ругался
            return new(
                period.DateStart < monthStart ? monthStart : period.DateStart ?? monthStart,
                period.DateEnd > monthEnd ? monthEnd : period.DateEnd ?? monthEnd
                );
        }

        private Math_Library.Employee EmployeeToMathLibrary() => new()
        {
            RublesPerHour = employee.BaseSalaryPerHourInRubles ?? 0,
            WorkHoursPerDay = employee.WorkHoursPerDay ?? 0,
            WorkDaysPerWeek = employee.WorkDaysPerWeek ?? 0,
        };

        private void Button_ShowAwards_Click(object sender, EventArgs e)
            => new AwardsListForm(employee, monthStart, monthEnd).ShowDialog();

        private void Button_ShowOvertimeHours_Click(object sender, EventArgs e)
            => new OvertimePeriodsListForm(employee, monthStart, monthEnd).ShowDialog();

        private void Button_ShowFines_Click(object sender, EventArgs e)
            => new FinesListForm(employee, monthStart, monthEnd).ShowDialog();

        private void Button_ShowSickPeriods_Click(object sender, EventArgs e)
            => new SickPeriodsListForm(employee, monthStart, monthEnd).ShowDialog();
    }
}
