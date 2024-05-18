using App.Data;

namespace App
{
    public partial class AddSickPeriodForm : Form
    {
        RestaurantContext context = new();
        Employee employee;

        public AddSickPeriodForm(Employee employee)
        {
            InitializeComponent();
            this.employee = context.Employees.First(e => e.ID == employee.ID);
            Label_EmployeeName.Text = employee.GetFullName();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var sickPeriod = new SickPeriod()
                {
                    EmployeeID = employee.ID,
                    DateStart = DateTimePicker_StartDate.Value,
                    DateEnd = DateTimePicker_EndDate.Value,
                    Reason = DataCheck.CheckForm(TextBox_Reason.Text, "Причина больничного периода"),
                };

                context.SickPeriods.Add(sickPeriod);
                context.SaveChanges();
                MessageBox.Show($"Больничный период для сотрудника \"{employee.GetFullName()}\" был добавлен в базу данных!");
                Close();
            }
            catch (DataCheck.DataError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_TodayDate_Click(object sender, EventArgs e)
        {
            DateTimePicker_StartDate.Value = DateTime.Today;
        }

        private void Button_StartTodayDate_Click(object sender, EventArgs e)
            => DateTimePicker_StartDate.Value = DateTime.Today;

        private void Button_EndTodayDate_Click(object sender, EventArgs e)
            => DateTimePicker_EndDate.Value = DateTime.Today;
    }
}
