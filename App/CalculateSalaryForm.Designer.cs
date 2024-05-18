namespace App
{
    partial class CalculateSalaryForm
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
            Label_EmployeeName = new Label();
            label1 = new Label();
            GroupBox_FilterDate = new GroupBox();
            label3 = new Label();
            NumericUpDown_Year = new NumericUpDown();
            label2 = new Label();
            ComboBox_Month = new ComboBox();
            GroupBox_Results = new GroupBox();
            label15 = new Label();
            Label_Period = new Label();
            label22 = new Label();
            Label_BaseSalary = new Label();
            label16 = new Label();
            Button_ShowSickPeriods = new Button();
            Button_ShowFines = new Button();
            Button_ShowOvertimeHours = new Button();
            Button_ShowAwards = new Button();
            Label_SickTax = new Label();
            label11 = new Label();
            Label_SickPeriodsCount = new Label();
            label14 = new Label();
            Label_FinesAmount = new Label();
            label10 = new Label();
            Label_FinesCount = new Label();
            label12 = new Label();
            Label_OvertimeHoursPay = new Label();
            label8 = new Label();
            Label_OvertimeHoursCount = new Label();
            label7 = new Label();
            Label_AwardsAmount = new Label();
            label6 = new Label();
            Label_AwardsCount = new Label();
            label5 = new Label();
            Label_Salary = new Label();
            label4 = new Label();
            Button_Calculate = new Button();
            groupBox2 = new GroupBox();
            Label_BaseSalaryPerHour = new Label();
            Label_RoleWorkStartDate = new Label();
            Label_WorkDaysPerWeek = new Label();
            Label_WorkHoursPerDay = new Label();
            Label_Role = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            GroupBox_FilterDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown_Year).BeginInit();
            GroupBox_Results.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Label_EmployeeName
            // 
            Label_EmployeeName.AutoSize = true;
            Label_EmployeeName.Location = new Point(12, 42);
            Label_EmployeeName.Name = "Label_EmployeeName";
            Label_EmployeeName.Size = new Size(172, 20);
            Label_EmployeeName.TabIndex = 26;
            Label_EmployeeName.Text = "(имя сотрудника здесь)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 28);
            label1.TabIndex = 25;
            label1.Text = "Подсчёт зарплаты сотрудника";
            // 
            // GroupBox_FilterDate
            // 
            GroupBox_FilterDate.Controls.Add(label3);
            GroupBox_FilterDate.Controls.Add(NumericUpDown_Year);
            GroupBox_FilterDate.Controls.Add(label2);
            GroupBox_FilterDate.Controls.Add(ComboBox_Month);
            GroupBox_FilterDate.Location = new Point(12, 65);
            GroupBox_FilterDate.Name = "GroupBox_FilterDate";
            GroupBox_FilterDate.Size = new Size(321, 86);
            GroupBox_FilterDate.TabIndex = 27;
            GroupBox_FilterDate.TabStop = false;
            GroupBox_FilterDate.Text = "Период подсчёта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 23);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 3;
            label3.Text = "Год:";
            // 
            // NumericUpDown_Year
            // 
            NumericUpDown_Year.Location = new Point(163, 46);
            NumericUpDown_Year.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            NumericUpDown_Year.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            NumericUpDown_Year.Name = "NumericUpDown_Year";
            NumericUpDown_Year.Size = new Size(150, 27);
            NumericUpDown_Year.TabIndex = 2;
            NumericUpDown_Year.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Месяц:";
            // 
            // ComboBox_Month
            // 
            ComboBox_Month.DisplayMember = "0";
            ComboBox_Month.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Month.FormattingEnabled = true;
            ComboBox_Month.Items.AddRange(new object[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" });
            ComboBox_Month.Location = new Point(6, 46);
            ComboBox_Month.Name = "ComboBox_Month";
            ComboBox_Month.Size = new Size(151, 28);
            ComboBox_Month.TabIndex = 0;
            ComboBox_Month.ValueMember = "0";
            // 
            // GroupBox_Results
            // 
            GroupBox_Results.Controls.Add(label15);
            GroupBox_Results.Controls.Add(Label_Period);
            GroupBox_Results.Controls.Add(label22);
            GroupBox_Results.Controls.Add(Label_BaseSalary);
            GroupBox_Results.Controls.Add(label16);
            GroupBox_Results.Controls.Add(Button_ShowSickPeriods);
            GroupBox_Results.Controls.Add(Button_ShowFines);
            GroupBox_Results.Controls.Add(Button_ShowOvertimeHours);
            GroupBox_Results.Controls.Add(Button_ShowAwards);
            GroupBox_Results.Controls.Add(Label_SickTax);
            GroupBox_Results.Controls.Add(label11);
            GroupBox_Results.Controls.Add(Label_SickPeriodsCount);
            GroupBox_Results.Controls.Add(label14);
            GroupBox_Results.Controls.Add(Label_FinesAmount);
            GroupBox_Results.Controls.Add(label10);
            GroupBox_Results.Controls.Add(Label_FinesCount);
            GroupBox_Results.Controls.Add(label12);
            GroupBox_Results.Controls.Add(Label_OvertimeHoursPay);
            GroupBox_Results.Controls.Add(label8);
            GroupBox_Results.Controls.Add(Label_OvertimeHoursCount);
            GroupBox_Results.Controls.Add(label7);
            GroupBox_Results.Controls.Add(Label_AwardsAmount);
            GroupBox_Results.Controls.Add(label6);
            GroupBox_Results.Controls.Add(Label_AwardsCount);
            GroupBox_Results.Controls.Add(label5);
            GroupBox_Results.Controls.Add(Label_Salary);
            GroupBox_Results.Controls.Add(label4);
            GroupBox_Results.Enabled = false;
            GroupBox_Results.Location = new Point(12, 209);
            GroupBox_Results.Name = "GroupBox_Results";
            GroupBox_Results.Size = new Size(812, 288);
            GroupBox_Results.TabIndex = 28;
            GroupBox_Results.TabStop = false;
            GroupBox_Results.Text = "Результаты";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 223);
            label15.Name = "label15";
            label15.Size = new Size(307, 20);
            label15.TabIndex = 26;
            label15.Text = "(Больничные дни оплачиваются по МРОТ)";
            // 
            // Label_Period
            // 
            Label_Period.AutoSize = true;
            Label_Period.Location = new Point(257, 23);
            Label_Period.Name = "Label_Period";
            Label_Period.Size = new Size(96, 20);
            Label_Period.TabIndex = 25;
            Label_Period.Text = "Январь 2024";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 23);
            label22.Name = "label22";
            label22.Size = new Size(66, 20);
            label22.TabIndex = 24;
            label22.Text = "Период:";
            // 
            // Label_BaseSalary
            // 
            Label_BaseSalary.AutoSize = true;
            Label_BaseSalary.Location = new Point(257, 43);
            Label_BaseSalary.Name = "Label_BaseSalary";
            Label_BaseSalary.Size = new Size(26, 20);
            Label_BaseSalary.TabIndex = 23;
            Label_BaseSalary.Text = "0р";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 43);
            label16.Name = "label16";
            label16.Size = new Size(195, 20);
            label16.TabIndex = 22;
            label16.Text = "Базовая зарплата в месяц:";
            // 
            // Button_ShowSickPeriods
            // 
            Button_ShowSickPeriods.Location = new Point(353, 179);
            Button_ShowSickPeriods.Name = "Button_ShowSickPeriods";
            Button_ShowSickPeriods.Size = new Size(250, 29);
            Button_ShowSickPeriods.TabIndex = 21;
            Button_ShowSickPeriods.Text = "Просмотр больничных";
            Button_ShowSickPeriods.UseVisualStyleBackColor = true;
            Button_ShowSickPeriods.Click += Button_ShowSickPeriods_Click;
            // 
            // Button_ShowFines
            // 
            Button_ShowFines.Location = new Point(353, 139);
            Button_ShowFines.Name = "Button_ShowFines";
            Button_ShowFines.Size = new Size(250, 29);
            Button_ShowFines.TabIndex = 20;
            Button_ShowFines.Text = "Просмотр штрафов";
            Button_ShowFines.UseVisualStyleBackColor = true;
            Button_ShowFines.Click += Button_ShowFines_Click;
            // 
            // Button_ShowOvertimeHours
            // 
            Button_ShowOvertimeHours.Location = new Point(353, 99);
            Button_ShowOvertimeHours.Name = "Button_ShowOvertimeHours";
            Button_ShowOvertimeHours.Size = new Size(250, 29);
            Button_ShowOvertimeHours.TabIndex = 19;
            Button_ShowOvertimeHours.Text = "Просмотр сверхурочных часов";
            Button_ShowOvertimeHours.UseVisualStyleBackColor = true;
            Button_ShowOvertimeHours.Click += Button_ShowOvertimeHours_Click;
            // 
            // Button_ShowAwards
            // 
            Button_ShowAwards.Location = new Point(353, 59);
            Button_ShowAwards.Name = "Button_ShowAwards";
            Button_ShowAwards.Size = new Size(250, 29);
            Button_ShowAwards.TabIndex = 18;
            Button_ShowAwards.Text = "Просмотр премий";
            Button_ShowAwards.UseVisualStyleBackColor = true;
            Button_ShowAwards.Click += Button_ShowAwards_Click;
            // 
            // Label_SickTax
            // 
            Label_SickTax.AutoSize = true;
            Label_SickTax.Location = new Point(256, 203);
            Label_SickTax.Name = "Label_SickTax";
            Label_SickTax.Size = new Size(26, 20);
            Label_SickTax.TabIndex = 17;
            Label_SickTax.Text = "0р";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 203);
            label11.Name = "label11";
            label11.Size = new Size(195, 20);
            label11.TabIndex = 16;
            label11.Text = "Снижение за больничные:";
            // 
            // Label_SickPeriodsCount
            // 
            Label_SickPeriodsCount.AutoSize = true;
            Label_SickPeriodsCount.Location = new Point(256, 183);
            Label_SickPeriodsCount.Name = "Label_SickPeriodsCount";
            Label_SickPeriodsCount.Size = new Size(17, 20);
            Label_SickPeriodsCount.TabIndex = 15;
            Label_SickPeriodsCount.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 183);
            label14.Name = "label14";
            label14.Size = new Size(222, 20);
            label14.TabIndex = 14;
            label14.Text = "Количество больничных дней:";
            // 
            // Label_FinesAmount
            // 
            Label_FinesAmount.AutoSize = true;
            Label_FinesAmount.Location = new Point(256, 163);
            Label_FinesAmount.Name = "Label_FinesAmount";
            Label_FinesAmount.Size = new Size(26, 20);
            Label_FinesAmount.TabIndex = 13;
            Label_FinesAmount.Text = "0р";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 163);
            label10.Name = "label10";
            label10.Size = new Size(124, 20);
            label10.TabIndex = 12;
            label10.Text = "Сумма штрафов:";
            // 
            // Label_FinesCount
            // 
            Label_FinesCount.AutoSize = true;
            Label_FinesCount.Location = new Point(256, 143);
            Label_FinesCount.Name = "Label_FinesCount";
            Label_FinesCount.Size = new Size(17, 20);
            Label_FinesCount.TabIndex = 11;
            Label_FinesCount.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 143);
            label12.Name = "label12";
            label12.Size = new Size(159, 20);
            label12.TabIndex = 10;
            label12.Text = "Количество штрафов:";
            // 
            // Label_OvertimeHoursPay
            // 
            Label_OvertimeHoursPay.AutoSize = true;
            Label_OvertimeHoursPay.Location = new Point(256, 123);
            Label_OvertimeHoursPay.Name = "Label_OvertimeHoursPay";
            Label_OvertimeHoursPay.Size = new Size(26, 20);
            Label_OvertimeHoursPay.TabIndex = 9;
            Label_OvertimeHoursPay.Text = "0р";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 123);
            label8.Name = "label8";
            label8.Size = new Size(223, 20);
            label8.TabIndex = 8;
            label8.Text = "Оплата за сверхурочные часы:";
            // 
            // Label_OvertimeHoursCount
            // 
            Label_OvertimeHoursCount.AutoSize = true;
            Label_OvertimeHoursCount.Location = new Point(256, 103);
            Label_OvertimeHoursCount.Name = "Label_OvertimeHoursCount";
            Label_OvertimeHoursCount.Size = new Size(17, 20);
            Label_OvertimeHoursCount.TabIndex = 7;
            Label_OvertimeHoursCount.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 103);
            label7.Name = "label7";
            label7.Size = new Size(240, 20);
            label7.TabIndex = 6;
            label7.Text = "Количество сверхурочных часов:";
            // 
            // Label_AwardsAmount
            // 
            Label_AwardsAmount.AutoSize = true;
            Label_AwardsAmount.Location = new Point(256, 83);
            Label_AwardsAmount.Name = "Label_AwardsAmount";
            Label_AwardsAmount.Size = new Size(26, 20);
            Label_AwardsAmount.TabIndex = 5;
            Label_AwardsAmount.Text = "0р";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 83);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 4;
            label6.Text = "Сумма премий:";
            // 
            // Label_AwardsCount
            // 
            Label_AwardsCount.AutoSize = true;
            Label_AwardsCount.Location = new Point(256, 63);
            Label_AwardsCount.Name = "Label_AwardsCount";
            Label_AwardsCount.Size = new Size(17, 20);
            Label_AwardsCount.TabIndex = 3;
            Label_AwardsCount.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 63);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 2;
            label5.Text = "Количество премий:";
            // 
            // Label_Salary
            // 
            Label_Salary.AutoSize = true;
            Label_Salary.Location = new Point(256, 260);
            Label_Salary.Name = "Label_Salary";
            Label_Salary.Size = new Size(26, 20);
            Label_Salary.TabIndex = 1;
            Label_Salary.Text = "0р";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 260);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 0;
            label4.Text = "Зарплата за месяц:";
            // 
            // Button_Calculate
            // 
            Button_Calculate.Location = new Point(12, 157);
            Button_Calculate.Name = "Button_Calculate";
            Button_Calculate.Size = new Size(200, 29);
            Button_Calculate.TabIndex = 29;
            Button_Calculate.Text = "Рассчитать зарплату";
            Button_Calculate.UseVisualStyleBackColor = true;
            Button_Calculate.Click += Button_Calculate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Label_BaseSalaryPerHour);
            groupBox2.Controls.Add(Label_RoleWorkStartDate);
            groupBox2.Controls.Add(Label_WorkDaysPerWeek);
            groupBox2.Controls.Add(Label_WorkHoursPerDay);
            groupBox2.Controls.Add(Label_Role);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Location = new Point(338, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(486, 138);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Информация о сотруднике";
            // 
            // Label_BaseSalaryPerHour
            // 
            Label_BaseSalaryPerHour.AutoSize = true;
            Label_BaseSalaryPerHour.Location = new Point(299, 103);
            Label_BaseSalaryPerHour.Name = "Label_BaseSalaryPerHour";
            Label_BaseSalaryPerHour.Size = new Size(17, 20);
            Label_BaseSalaryPerHour.TabIndex = 9;
            Label_BaseSalaryPerHour.Text = "0";
            // 
            // Label_RoleWorkStartDate
            // 
            Label_RoleWorkStartDate.AutoSize = true;
            Label_RoleWorkStartDate.Location = new Point(299, 83);
            Label_RoleWorkStartDate.Name = "Label_RoleWorkStartDate";
            Label_RoleWorkStartDate.Size = new Size(17, 20);
            Label_RoleWorkStartDate.TabIndex = 8;
            Label_RoleWorkStartDate.Text = "0";
            // 
            // Label_WorkDaysPerWeek
            // 
            Label_WorkDaysPerWeek.AutoSize = true;
            Label_WorkDaysPerWeek.Location = new Point(299, 63);
            Label_WorkDaysPerWeek.Name = "Label_WorkDaysPerWeek";
            Label_WorkDaysPerWeek.Size = new Size(17, 20);
            Label_WorkDaysPerWeek.TabIndex = 7;
            Label_WorkDaysPerWeek.Text = "0";
            // 
            // Label_WorkHoursPerDay
            // 
            Label_WorkHoursPerDay.AutoSize = true;
            Label_WorkHoursPerDay.Location = new Point(299, 43);
            Label_WorkHoursPerDay.Name = "Label_WorkHoursPerDay";
            Label_WorkHoursPerDay.Size = new Size(17, 20);
            Label_WorkHoursPerDay.TabIndex = 6;
            Label_WorkHoursPerDay.Text = "0";
            // 
            // Label_Role
            // 
            Label_Role.AutoSize = true;
            Label_Role.Location = new Point(299, 23);
            Label_Role.Name = "Label_Role";
            Label_Role.Size = new Size(86, 20);
            Label_Role.TabIndex = 5;
            Label_Role.Text = "Должность";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 103);
            label21.Name = "label21";
            label21.Size = new Size(249, 20);
            label21.TabIndex = 4;
            label21.Text = "Базовая зарплата (в рублях в час):";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 83);
            label20.Name = "label20";
            label20.Size = new Size(289, 20);
            label20.TabIndex = 3;
            label20.Text = "Дата начала работы на этой должности:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 63);
            label19.Name = "label19";
            label19.Size = new Size(231, 20);
            label19.TabIndex = 2;
            label19.Text = "Кол-во рабочих дней в неделю:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 43);
            label18.Name = "label18";
            label18.Size = new Size(217, 20);
            label18.TabIndex = 1;
            label18.Text = "Кол-во рабочих часов в день:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 23);
            label17.Name = "label17";
            label17.Size = new Size(89, 20);
            label17.TabIndex = 0;
            label17.Text = "Должность:";
            // 
            // CalculateSalaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 505);
            Controls.Add(groupBox2);
            Controls.Add(Button_Calculate);
            Controls.Add(GroupBox_Results);
            Controls.Add(GroupBox_FilterDate);
            Controls.Add(Label_EmployeeName);
            Controls.Add(label1);
            Name = "CalculateSalaryForm";
            Text = "Сотрудники ресторана - Подсчёт зарплаты сотрудника";
            GroupBox_FilterDate.ResumeLayout(false);
            GroupBox_FilterDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown_Year).EndInit();
            GroupBox_Results.ResumeLayout(false);
            GroupBox_Results.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_EmployeeName;
        private Label label1;
        private GroupBox GroupBox_FilterDate;
        private Label label3;
        private NumericUpDown NumericUpDown_Year;
        private Label label2;
        private ComboBox ComboBox_Month;
        private GroupBox GroupBox_Results;
        private Label Label_Salary;
        private Label label4;
        private Label Label_AwardsCount;
        private Label label5;
        private Label Label_AwardsAmount;
        private Label label6;
        private Label Label_OvertimeHoursCount;
        private Label label7;
        private Label Label_OvertimeHoursPay;
        private Label label8;
        private Label Label_FinesAmount;
        private Label label10;
        private Label Label_FinesCount;
        private Label label12;
        private Label Label_SickTax;
        private Label label11;
        private Label Label_SickPeriodsCount;
        private Label label14;
        private Button Button_ShowFines;
        private Button Button_ShowOvertimeHours;
        private Button Button_ShowAwards;
        private Button Button_ShowSickPeriods;
        private Button Button_Calculate;
        private Label Label_BaseSalary;
        private Label label16;
        private GroupBox groupBox2;
        private Label label17;
        private Label label19;
        private Label label18;
        private Label label20;
        private Label label21;
        private Label Label_BaseSalaryPerHour;
        private Label Label_RoleWorkStartDate;
        private Label Label_WorkDaysPerWeek;
        private Label Label_WorkHoursPerDay;
        private Label Label_Role;
        private Label Label_Period;
        private Label label22;
        private Label label15;
    }
}