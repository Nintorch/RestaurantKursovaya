using App.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class MainMenuForm : Form
    {
        RestaurantContext context = new();

        public MainMenuForm()
        {
            InitializeComponent();

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
        }

        private void Button_DeleteEmployee_Click(object sender, EventArgs e)
        {
            var rows = DataGridView_Data.SelectedRows;
            if (rows.Count == 0)
            {
                MessageBox.Show("Не было выделено ни одной строки сотрудников.");
                return;
            }

            int deletedCount = 0;

            foreach (DataRow row in rows)
            {
                Employee employee = context.Employees.First(e => e.ID == (int)row[0]);
                if (MessageBox.Show(
                    $"Вы уверены, что вы хотите полностью удалить сотрудника \"{employee.GetFullName()}\"?",
                    "Требуется подтверждение",
                    MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    employee.Delete();
                    deletedCount++;
                }
            }

            context.SaveChanges();

            MessageBox.Show($"Был(и) удален(ы) {deletedCount} сотрудник(ов).");
        }
    }
}
