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
            const char rubleChar = 'р';

            GroupBox_Results.Enabled = true;
            Label_Period.Text = $"{ComboBox_Month.Text} {NumericUpDown_Year.Value}";

            var report = SalaryReport.GetEmployeeSalaryReport(
                employee, ComboBox_Month.SelectedIndex + 1, (int)NumericUpDown_Year.Value
                );
            monthStart = report.MonthStart;
            monthEnd = report.MonthEnd;

            // Выводим базовую зарплату
            Label_BaseSalary.Text = report.BaseSalary.ToString() + rubleChar;

            // Выводим сумму и количество премий за определенный год и месяц
            Label_AwardsCount.Text = report.AwardsCount.ToString();
            Label_AwardsAmount.Text = report.AwardsAmount.ToString() + rubleChar;

            // Выводим сумму и количество сверхурочных часов за определенный год и месяц
            Label_OvertimeHoursCount.Text = report.OvertimeHoursCount.ToString();
            Label_OvertimeHoursPay.Text = report.OvertimeAmount.ToString() + rubleChar;

            // Выводим сумму и количество штрафов за определенный год и месяц
            Label_FinesCount.Text = report.FinesCount.ToString();
            Label_FinesAmount.Text = report.FinesAmount.ToString() + rubleChar;

            // Выводим количество больничных и снижение зарплаты за них за определенный год и месяц
            Label_SickTax.Text = report.SickTax.ToString() + rubleChar;
            Label_SickPeriodsCount.Text = report.SickPeriodsDays.ToString();

            // Выводим общую зарплату за определенный год и месяц
            Label_Salary.Text = report.SalaryResult.ToString() + rubleChar;

            MessageBox.Show($"Зарплата для сотрудника \"{employee.GetFullName()}\" была успешно рассчитана!");
        }

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
