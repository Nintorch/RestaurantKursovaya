using App.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace App
{
    public partial class FinesListForm : Form
    {
        RestaurantContext context = new();
        Employee employee;

        public FinesListForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;

            Label_EmployeeName.Text = employee.GetFullName();
            ReloadData();
        }

        public FinesListForm(Employee employee, DateTime filterStart, DateTime filterEnd)
        {
            InitializeComponent();
            this.employee = employee;
            Label_EmployeeName.Text = employee.GetFullName();

            CheckBox_FilterDate.Checked = true;
            DateTimePicker_FilterDateStart.Value = filterStart;
            DateTimePicker_FilterDateEnd.Value = filterEnd;
            FilterData();
        }

        public static string GetEmployeeTitle(Employee employee) => $"{employee.GetFullName()} - {employee.Role}";

        private void ReloadData()
        {
            employeeListBindingSource.DataSource = context.Employees
                .Select(x => new IdToTextMap(x.ID, GetEmployeeTitle(x))).ToList();

            employee = context.Employees
                .Include(e => e.Fines)
                .First(e => e.ID == employee.ID);
            fineBindingSource.DataSource = employee.Fines.ToList();
        }

        private void DataGridView_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DataGridView_Data.Rows[e.RowIndex].Cells["id"].Value;
            Fine fine = context.Fines.First(x => x.ID == id);

            if (DataGridView_Data.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                var result = MessageBox.Show(
                    $"Вы уверены, что вы хотите удалить штраф сотрудника \"{employee.GetFullName()}\"?",
                    "Требуется подтверждение",
                    MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    context.Fines.Remove(fine);
                    context.SaveChanges();
                    MessageBox.Show("Штраф был успешно удалён.");
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
            if (filterAmount) try
                {
                    amountStart = DataCheck.CheckFormInt(TextBox_FilterAmountStart.Text, "Нижний предел суммы");
                    amountEnd = DataCheck.CheckFormInt(TextBox_FilterAmountEnd.Text, "Верхний предел суммы");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            bool filterDate = CheckBox_FilterDate.Checked;
            DateTime dateStart = DateTimePicker_FilterDateStart.Value;
            DateTime dateEnd = DateTimePicker_FilterDateEnd.Value;

            bool filterReason = CheckBox_FilterReason.Checked;
            string reason = TextBox_FilterReason.Text;

            employee = context.Employees
                .Include(e => e.Fines)
                .First(e => e.ID == employee.ID);
            fineBindingSource.DataSource = employee.Fines.ToList().Where(f =>
            {
                if (filterAmount && (f.Amount < amountStart || f.Amount > amountEnd))
                    return false;
                if (filterDate && (f.Date < dateStart || f.Date > dateEnd))
                    return false;
                if (filterReason && !(f.Reason ?? "").Contains(reason, StringComparison.OrdinalIgnoreCase))
                    return false;
                return true;
            }).ToList();
        }

        private void Button_Filter_Click(object sender, EventArgs e) => FilterData();

        private void Button_AddFine_Click(object sender, EventArgs e)
        {
            new AddFineForm(employee).ShowDialog();
            ReloadData();
        }
    }
}
