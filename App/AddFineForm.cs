using App.Data;
using System.Data;

namespace App
{
    public partial class AddFineForm : Form
    {
        RestaurantContext context = new();
        Employee employee;

        public AddFineForm(Employee employee)
        {
            InitializeComponent();
            this.employee = context.Employees.First(e => e.ID == employee.ID);
            Label_EmployeeName.Text = employee.GetFullName();
            employeeListBindingSource.DataSource = context.Employees
                .Select(x => new IdToTextMap(x.ID, FinesListForm.GetEmployeeTitle(x))).ToList();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var fine = new Fine()
                {
                    EmployeeID = employee.ID,
                    Amount = DataCheck.CheckFormInt(TextBox_Amount.Text, "Сумма (в рублях)"),
                    Date = DateTimePicker_Date.Value,
                    Reason = DataCheck.CheckForm(TextBox_Reason.Text, "Причина штрафа"),
                    GiverID = (int)ComboBox_Giver.SelectedValue,
                };

                context.Fines.Add(fine);
                context.SaveChanges();
                MessageBox.Show($"Штраф для сотрудника \"{employee.GetFullName()}\" был добавлен в базу данных!");
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
