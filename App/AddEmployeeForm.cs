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
                    LastName = CheckForm(TextBox_LastName.Text, "Фамилия"),
                    FirstName = CheckForm(TextBox_FirstName.Text, "Имя"),
                    MiddleName = CheckForm(TextBox_MiddleName.Text, "Отчество"),
                    Birthday = DateTimePicker_Birthday.Value,
                    Role = CheckForm(TextBox_Role.Text, "Должность"),
                    WorkHoursPerDay = CheckFormInt(TextBox_WorkHoursPerDay.Text, "Количество рабочих часов в день"),
                    WorkDaysPerWeek = CheckFormInt(TextBox_WorkDaysPerWeek.Text, "Количество рабочих дней в неделю"),
                    RoleWorkStartDate = DateTimePicker_RoleWorkStart.Value,
                    BaseSalaryPerHourInRubles = CheckFormInt(TextBox_BaseSalaryPerHour.Text, "Базовая зарплата (в рублях в час)"),
                };

                context.Employees.Add(employee);
                context.SaveChanges();
                MessageBox.Show($"Сотрудник \"{employee.GetFullName()}\" был добавлен в базу данных.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string CheckForm(string text, string name)
        {
            if (text == "")
                throw new Exception($"Поле \"{name}\" не может быть пустым.");
            return text;
        }

        private int CheckFormInt(string text, string name)
        {
            if (text == "")
                throw new Exception($"Поле \"{name}\" не может быть пустым.");
            if (!int.TryParse(text, out int result))
                throw new Exception($"Вы должны ввести число в поле \"{name}\".");
            return result;
        }
    }
}
