using App.Data;
using System.Data;

namespace App
{
    public partial class SickPeriodsListForm : Form
    {
        RestaurantContext context = new();
        Employee employee;

        public SickPeriodsListForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            Label_EmployeeName.Text = employee.GetFullName();
            ReloadData();
        }

        public SickPeriodsListForm(Employee employee, DateTime filterStart, DateTime filterEnd)
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
            sickPeriodBindingSource.DataSource = employee.GetSickPeriods().ToList();
        }

        private void DataGridView_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DataGridView_Data.Rows[e.RowIndex].Cells["id"].Value;
            SickPeriod sickPeriod = context.SickPeriods.First(sp => sp.ID == id);

            if (DataGridView_Data.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                var result = MessageBox.Show(
                    $"Вы уверены, что вы хотите удалить больничный период сотрудника \"{employee.GetFullName()}\"?",
                    "Требуется подтверждение",
                    MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    context.SickPeriods.Remove(sickPeriod);
                    context.SaveChanges();
                    MessageBox.Show("Больничный период был успешно удалён.");
                    ReloadData();
                }
            }
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

        private void CheckBox_FilterReason_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_FilterReason.Enabled = CheckBox_FilterReason.Checked;
        }

        private void FilterData()
        {
            bool filterDate = CheckBox_FilterDate.Checked;
            DateTime dateStart = DateTimePicker_FilterDateStart.Value;
            DateTime dateEnd = DateTimePicker_FilterDateEnd.Value;

            bool filterReason = CheckBox_FilterReason.Checked;
            string reason = TextBox_FilterReason.Text;

            employee = context.Employees
                .First(e => e.ID == employee.ID);
            sickPeriodBindingSource.DataSource = employee.GetSickPeriods().ToList().Where(sp =>
            {
                if (filterDate && !sp.ContainsOrTouches(dateStart, dateEnd))
                    return false;
                if (filterReason && !(sp.Reason ?? "").Contains(reason, StringComparison.OrdinalIgnoreCase))
                    return false;
                return true;
            }).ToList();
        }

        private void Button_Filter_Click(object sender, EventArgs e) => FilterData();

        private void Button_AddSickPeriod_Click(object sender, EventArgs e)
        {
            new AddSickPeriodForm(employee).ShowDialog();
            ReloadData();
        }
    }
}
