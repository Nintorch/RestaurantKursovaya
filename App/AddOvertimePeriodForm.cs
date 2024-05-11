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
    public partial class AddOvertimePeriodForm : Form
    {
        RestaurantContext context = new();
        Employee employee;

        public AddOvertimePeriodForm(Employee employee)
        {
            InitializeComponent();
            this.employee = context.Employees.First(e => e.ID == employee.ID);
            Label_EmployeeName.Text = employee.GetFullName();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var overtimePeriod = new OvertimePeriod()
                {
                    EmployeeID = employee.ID,
                    Date = DateTimePicker_Date.Value,
                    OvertimeHoursCount = (short)DataCheck.CheckFormInt(TextBox_Amount.Text, "Количество часов"),
                };

                context.OvertimePeriods.Add(overtimePeriod);
                context.SaveChanges();
                MessageBox.Show($"Сверхурочные часы для сотрудника \"{employee.GetFullName()}\" были добавлены в базу данных.");
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
