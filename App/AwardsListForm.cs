using App.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class AwardsListForm : Form
    {
        RestaurantContext context = new();
        Employee employee;

        public AwardsListForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            Label_EmployeeName.Text = employee.GetFullName();
            ReloadData();
        }

        public AwardsListForm(Employee employee, DateTime filterStart, DateTime filterEnd)
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
                .Include(e => e.Awards)
                .First(e => e.ID == employee.ID);
            awardBindingSource.DataSource = employee.Awards.ToList();
        }

        private void Button_AddAward_Click(object sender, EventArgs e)
        {
            new AddAwardForm(employee).ShowDialog();
            ReloadData();
        }

        private void DataGridView_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DataGridView_Data.Rows[e.RowIndex].Cells["id"].Value;
            Award award = context.Awards.First(x => x.ID == id);

            if (DataGridView_Data.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                var result = MessageBox.Show(
                    $"Вы уверены, что вы хотите удалить премию сотрудника \"{employee.GetFullName()}\"?",
                    "Требуется подтверждение",
                    MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    context.Awards.Remove(award);
                    context.SaveChanges();
                    MessageBox.Show("Премия была успешно удалена.");
                    ReloadData();
                }
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            MessageBox.Show("Изменения были успешно сохранены!");
        }

        private void CheckBox_FilterAmount_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox_FilterAmount.Enabled = CheckBox_FilterAmount.Checked;
        }

        private void CheckBox_FilterDate_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox_FilterDate.Enabled = CheckBox_FilterDate.Checked;
        }

        private void CheckBox_FilterReason_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_FilterReason.Enabled = CheckBox_FilterReason.Checked;
        }

        private void FilterData()
        {
            bool filterAmount = CheckBox_FilterAmount.Checked;
            int amountStart = 0, amountEnd = 0;
            if (filterAmount)
            {
                amountStart = DataCheck.CheckFormInt(TextBox_FilterAmountStart.Text, "Нижний предел суммы");
                amountEnd = DataCheck.CheckFormInt(TextBox_FilterAmountEnd.Text, "Верхний предел суммы");
            }

            bool filterDate = CheckBox_FilterDate.Checked;
            DateTime dateStart = DateTimePicker_FilterDateStart.Value;
            DateTime dateEnd = DateTimePicker_FilterDateEnd.Value;

            bool filterReason = CheckBox_FilterReason.Checked;
            string reason = TextBox_FilterReason.Text;

            employee = context.Employees
                .Include(e => e.Awards)
                .First(e => e.ID == employee.ID);
            awardBindingSource.DataSource = employee.Awards.ToList().Where(a =>
            {
                if (filterAmount && (a.AmountInRubles < amountStart || a.AmountInRubles > amountEnd))
                    return false;
                if (filterDate && (a.AwardDate < dateStart || a.AwardDate > dateEnd))
                    return false;
                if (filterReason && !(a.Reason ?? "").Contains(reason, StringComparison.OrdinalIgnoreCase))
                    return false;
                return true;
            }).ToList();
        }

        private void Button_Filter_Click(object sender, EventArgs e) => FilterData();
    }
}
