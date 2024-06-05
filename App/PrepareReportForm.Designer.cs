namespace App
{
    partial class PrepareReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            NumericUpDown_Year = new NumericUpDown();
            label2 = new Label();
            ComboBox_Month = new ComboBox();
            Button_Save = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown_Year).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(298, 28);
            label1.TabIndex = 3;
            label1.Text = "Создание отчёта о зарплатах";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 118);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 7;
            label3.Text = "Год:";
            // 
            // NumericUpDown_Year
            // 
            NumericUpDown_Year.Location = new Point(169, 141);
            NumericUpDown_Year.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            NumericUpDown_Year.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            NumericUpDown_Year.Name = "NumericUpDown_Year";
            NumericUpDown_Year.Size = new Size(150, 27);
            NumericUpDown_Year.TabIndex = 6;
            NumericUpDown_Year.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 5;
            label2.Text = "Месяц:";
            // 
            // ComboBox_Month
            // 
            ComboBox_Month.DisplayMember = "0";
            ComboBox_Month.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Month.FormattingEnabled = true;
            ComboBox_Month.Items.AddRange(new object[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" });
            ComboBox_Month.Location = new Point(12, 141);
            ComboBox_Month.Name = "ComboBox_Month";
            ComboBox_Month.Size = new Size(151, 28);
            ComboBox_Month.TabIndex = 4;
            ComboBox_Month.ValueMember = "0";
            // 
            // Button_Save
            // 
            Button_Save.Location = new Point(102, 250);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(150, 29);
            Button_Save.TabIndex = 8;
            Button_Save.Text = "Сохранить отчёт";
            Button_Save.UseVisualStyleBackColor = true;
            Button_Save.Click += Button_Save_Click;
            // 
            // label4
            // 
            label4.Location = new Point(12, 46);
            label4.Name = "label4";
            label4.Size = new Size(330, 72);
            label4.TabIndex = 9;
            label4.Text = "Выберите период, за который будет расчитана зарплата всех сотрудников ресторана.";
            // 
            // label5
            // 
            label5.Location = new Point(12, 199);
            label5.Name = "label5";
            label5.Size = new Size(330, 48);
            label5.TabIndex = 10;
            label5.Text = "Нажмите на кнопку и выберите файл для сохранения отчёта.";
            // 
            // PrepareReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 299);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Button_Save);
            Controls.Add(label3);
            Controls.Add(NumericUpDown_Year);
            Controls.Add(label2);
            Controls.Add(ComboBox_Month);
            Controls.Add(label1);
            Name = "PrepareReportForm";
            Text = "Сотрудники ресторана - Создание отчёта о зарплатах";
            ((System.ComponentModel.ISupportInitialize)NumericUpDown_Year).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private NumericUpDown NumericUpDown_Year;
        private Label label2;
        private ComboBox ComboBox_Month;
        private Button Button_Save;
        private Label label4;
        private Label label5;
    }
}