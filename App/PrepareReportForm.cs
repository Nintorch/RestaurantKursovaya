using App.Reports;

namespace App
{
    public partial class PrepareReportForm : Form
    {
        public PrepareReportForm()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            bool result = ReportHelper.SaveReport(
                new SalaryReport(ComboBox_Month.SelectedIndex + 1, (int)NumericUpDown_Year.Value),
                "Отчёт о зарплатах сотрудников"
                );
            if (result) Close();
        }
    }
}
