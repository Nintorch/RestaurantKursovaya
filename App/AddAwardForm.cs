using App.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
