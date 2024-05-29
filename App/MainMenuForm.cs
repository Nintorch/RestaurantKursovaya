using App.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace App
{
    public partial class MainMenuForm : Form
    {
        RestaurantContext context = new();

        public MainMenuForm()
        {
            InitializeComponent();

            ReloadData();
        }

        private void ReloadData()
        {
            employeeBindingSource.DataSource = context.Employees.ToList();
        }

        private bool FilterData(Employee employee)
        {
            // Проверка на имя, фамилию и отчество
            if (employee.LastName == null ||
                !employee.LastName.Contains(TextBox_FilterLastName.Text, StringComparison.OrdinalIgnoreCase))
                return false;
            if (employee.FirstName == null ||
                !employee.FirstName.Contains(TextBox_FilterFirstName.Text, StringComparison.OrdinalIgnoreCase))
                return false;
            if (employee.MiddleName == null ||
                !employee.MiddleName.Contains(TextBox_FilterMiddleName.Text, StringComparison.OrdinalIgnoreCase))
                return false;

            // Проверка на роль
            if (employee.Role == null ||
                !employee.Role.Contains(TextBox_FilterRole.Text, StringComparison.OrdinalIgnoreCase))
                return false;

            // Проверка на дату рождения, если галочка была поставлена
            if (CheckBox_FilterBirthday.Checked && employee.Birthday != DateTimePicker_FilterBirthday.Value)
                return false;

            return true;
        }

        private void Button_Filter_Click(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = context.Employees.Where(FilterData).ToList();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            MessageBox.Show("Изменения были успешно сохранены.");
        }

        private void Button_AddEmployee_Click(object sender, EventArgs e)
        {
            new AddEmployeeForm().ShowDialog();
            ReloadData();
        }

        private void DataGridView_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DataGridView_Data.Rows[e.RowIndex].Cells["id"].Value;

            var employee = context.Employees
                .Include(e => e.Awards)
                .Include(e => e.OvertimePeriods)
                .Include(e => e.Fines)
                .First(e => e.ID == id);

            switch (DataGridView_Data.Columns[e.ColumnIndex].Name)
            {
                case "AwardsButton":
                    new AwardsListForm(employee).ShowDialog();
                    break;

                case "OvertimePeriodsButton":
                    new OvertimePeriodsListForm(employee).ShowDialog();
                    break;

                case "FinesButton":
                    new FinesListForm(employee).ShowDialog();
                    break;

                case "SickPeriodsButton":
                    new SickPeriodsListForm(employee).ShowDialog();
                    break;

                case "CalculateSalaryButton":
                    new CalculateSalaryForm(employee).ShowDialog();
                    break;

                case "DeleteButton":
                    var result = MessageBox.Show(
                        $"Вы уверены, что вы хотите удалить сотрудника \"{employee.GetFullName()}\" из базы данных?",
                        "Требуется подтверждение",
                        MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                        employee.Delete();
                        context.SaveChanges();
                        MessageBox.Show($"Сотрудник \"{employee.GetFullName()}\" был успешно удалён из базы данных.");
                        ReloadData();
                    }
                    break;
            }
        }

        private void Button_Report_Click(object sender, EventArgs e)
            => new PrepareReportForm().ShowDialog();
    }
}
