using App.Data;

namespace App
{
    public partial class AddEmployeeForm : Form
    {
        RestaurantContext context = new();

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = new Employee()
                {
                    LastName = DataCheck.CheckForm(TextBox_LastName.Text, "Фамилия"),
                    FirstName = DataCheck.CheckForm(TextBox_FirstName.Text, "Имя"),
                    MiddleName = DataCheck.CheckForm(TextBox_MiddleName.Text, "Отчество"),
                    Birthday = DateTimePicker_Birthday.Value,
                    Role = DataCheck.CheckForm(TextBox_Role.Text, "Должность"),
                    WorkHoursPerDay = DataCheck.CheckFormInt(TextBox_WorkHoursPerDay.Text, "Количество рабочих часов в день"),
                    WorkDaysPerWeek = DataCheck.CheckFormInt(TextBox_WorkDaysPerWeek.Text, "Количество рабочих дней в неделю"),
                    RoleWorkStartDate = DateTimePicker_RoleWorkStart.Value,
                    BaseSalaryPerHourInRubles = DataCheck.CheckFormInt(TextBox_BaseSalaryPerHour.Text, "Базовая зарплата (в рублях в час)"),
                };

                context.Employees.Add(employee);
                context.SaveChanges();
                MessageBox.Show($"Сотрудник \"{employee.GetFullName()}\" был добавлен в базу данных.");
                Close();
            }
            catch (DataCheck.DataError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
