﻿using App.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace App
{
    public partial class OvertimePeriodsListForm : Form
    {
        RestaurantContext context = new();
        Employee employee;

        public OvertimePeriodsListForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            Label_EmployeeName.Text = employee.GetFullName();
            ReloadData();
        }

        public OvertimePeriodsListForm(Employee employee, DateTime filterStart, DateTime filterEnd)
        {
            InitializeComponent();
            this.employee = employee;
            Label_EmployeeName.Text = employee.GetFullName();

            CheckBox_FilterDate.Checked = true;
            DateTimePicker_FilterDateStart.Value = filterStart;
            DateTimePicker_FilterDateEnd.Value = filterEnd;
            FilterData();
        }

        private void ReloadData()
        {
            employee = context.Employees
                .Include(e => e.OvertimePeriods)
                .First(e => e.ID == employee.ID);
            overtimePeriodBindingSource.DataSource = employee.OvertimePeriods.ToList();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            MessageBox.Show("Изменения были успешно сохранены!");
        }

        private void CheckBox_FilterDate_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox_FilterDate.Enabled = CheckBox_FilterDate.Checked;
        }

        private void CheckBox_FilterAmount_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox_FilterAmount.Enabled = CheckBox_FilterAmount.Checked;
        }

        private void FilterData()
        {
            bool filterAmount = CheckBox_FilterAmount.Checked;
            int amountStart = 0, amountEnd = 0;
            if (filterAmount) try
                {
                    amountStart = DataCheck.CheckFormInt(TextBox_FilterAmountStart.Text, "Нижний предел количества часов");
                    amountEnd = DataCheck.CheckFormInt(TextBox_FilterAmountEnd.Text, "Верхний предел количества часов");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            bool filterDate = CheckBox_FilterDate.Checked;
            DateTime dateStart = DateTimePicker_FilterDateStart.Value;
            DateTime dateEnd = DateTimePicker_FilterDateEnd.Value;

            employee = context.Employees
                .Include(e => e.OvertimePeriods)
                .First(e => e.ID == employee.ID);
            overtimePeriodBindingSource.DataSource = employee.OvertimePeriods.ToList().Where(o =>
            {
                if (filterAmount && (o.OvertimeHoursCount < amountStart || o.OvertimeHoursCount > amountEnd))
                    return false;
                if (filterDate && (o.Date < dateStart || o.Date > dateEnd))
                    return false;
                return true;
            }).ToList();
        }

        private void Button_Filter_Click(object sender, EventArgs e) => FilterData();

        private void Button_AddEmployee_Click(object sender, EventArgs e)
        {
            new AddOvertimePeriodForm(employee).ShowDialog();
            ReloadData();
        }

        private void DataGridView_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DataGridView_Data.Rows[e.RowIndex].Cells["id"].Value;
            OvertimePeriod period = context.OvertimePeriods.First(o => o.ID == id);

            if (DataGridView_Data.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                var result = MessageBox.Show(
                    $"Вы уверены, что вы хотите удалить сверхурочные часы сотрудника {employee.GetFullName()}?",
                    "Требуется подтверждение",
                    MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    context.OvertimePeriods.Remove(period);
                    context.SaveChanges();
                    MessageBox.Show("Сверхурочные часы были успешно удалены.");
                    ReloadData();
                }
            }
        }
    }
}
