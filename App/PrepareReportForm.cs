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
    public partial class PrepareReportForm : Form
    {
        public PrepareReportForm()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog_Report.Title = "Сохранение отчёта";
            SaveFileDialog_Report.Filter = "Файл Excel|*.xlsx";

            if (SaveFileDialog_Report.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var report = new SalaryReport(ComboBox_Month.SelectedIndex+1, (int)NumericUpDown_Year.Value);
                    report.WriteToFile(SaveFileDialog_Report.FileName);
                    MessageBox.Show("Отчёт о зарплатах сотрудников сохранён в файл "
                        + SaveFileDialog_Report.FileName, "Успешно");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при сохранении отчёта: " + ex.Message, "Ошибка");
                }
            }
        }
    }
}
