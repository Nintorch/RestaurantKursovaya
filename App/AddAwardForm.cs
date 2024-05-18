using App.Data;

namespace App
{
    public partial class AddAwardForm : Form
    {
        RestaurantContext context = new();
        Employee employee;

        public AddAwardForm(Employee employee)
        {
            InitializeComponent();
            this.employee = context.Employees.First(e => e.ID == employee.ID);
            Label_EmployeeName.Text = employee.GetFullName();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var award = new Award()
                {
                    EmployeeID = employee.ID,
                    AmountInRubles = DataCheck.CheckFormInt(TextBox_Amount.Text, "Сумма (в рублях)"),
                    AwardDate = DateTimePicker_Date.Value,
                    Reason = DataCheck.CheckForm(TextBox_Reason.Text, "Причина премии"),
                };

                context.Awards.Add(award);
                context.SaveChanges();
                MessageBox.Show($"Премия для сотрудника \"{employee.GetFullName()}\" была добавлена в базу данных!");
                Close();
            }
            catch (DataCheck.DataError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_TodayDate_Click(object sender, EventArgs e)
        {
            DateTimePicker_Date.Value = DateTime.Today;
        }
    }
}
