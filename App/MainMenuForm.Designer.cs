namespace App
{
    partial class MainMenuForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            DataGridView_Data = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthdayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workHoursPerDayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workDaysPerWeekDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleWorkStartDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            baseSalaryPerHourInRublesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            awardsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            overtimePeriodsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            finesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AwardsButton = new DataGridViewButtonColumn();
            OvertimePeriodsButton = new DataGridViewButtonColumn();
            FinesButton = new DataGridViewButtonColumn();
            SickPeriodsButton = new DataGridViewButtonColumn();
            CalculateSalaryButton = new DataGridViewButtonColumn();
            DeleteButton = new DataGridViewButtonColumn();
            employeeBindingSource = new BindingSource(components);
            TextBox_FilterLastName = new TextBox();
            groupBox1 = new GroupBox();
            Button_Filter = new Button();
            DateTimePicker_FilterBirthday = new DateTimePicker();
            CheckBox_FilterBirthday = new CheckBox();
            label5 = new Label();
            TextBox_FilterRole = new TextBox();
            label4 = new Label();
            TextBox_FilterMiddleName = new TextBox();
            label3 = new Label();
            TextBox_FilterFirstName = new TextBox();
            label2 = new Label();
            Button_AddEmployee = new Button();
            Button_Save = new Button();
            Button_Report = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(319, 28);
            label1.TabIndex = 2;
            label1.Text = "Список сотрудников ресторана";
            // 
            // DataGridView_Data
            // 
            DataGridView_Data.AllowUserToAddRows = false;
            DataGridView_Data.AllowUserToDeleteRows = false;
            DataGridView_Data.AutoGenerateColumns = false;
            DataGridView_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Data.Columns.AddRange(new DataGridViewColumn[] { id, lastNameDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn, birthdayDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, workHoursPerDayDataGridViewTextBoxColumn, workDaysPerWeekDataGridViewTextBoxColumn, roleWorkStartDateDataGridViewTextBoxColumn, baseSalaryPerHourInRublesDataGridViewTextBoxColumn, awardsDataGridViewTextBoxColumn, overtimePeriodsDataGridViewTextBoxColumn, finesDataGridViewTextBoxColumn, AwardsButton, OvertimePeriodsButton, FinesButton, SickPeriodsButton, CalculateSalaryButton, DeleteButton });
            DataGridView_Data.DataSource = employeeBindingSource;
            DataGridView_Data.Location = new Point(12, 40);
            DataGridView_Data.Name = "DataGridView_Data";
            DataGridView_Data.RowHeadersWidth = 51;
            DataGridView_Data.RowTemplate.Height = 29;
            DataGridView_Data.Size = new Size(532, 367);
            DataGridView_Data.TabIndex = 3;
            DataGridView_Data.CellContentClick += DataGridView_Data_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "ID";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            id.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            middleNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            middleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            middleNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            birthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            birthdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Должность";
            roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // workHoursPerDayDataGridViewTextBoxColumn
            // 
            workHoursPerDayDataGridViewTextBoxColumn.DataPropertyName = "WorkHoursPerDay";
            workHoursPerDayDataGridViewTextBoxColumn.HeaderText = "Количество часов работы в день";
            workHoursPerDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            workHoursPerDayDataGridViewTextBoxColumn.Name = "workHoursPerDayDataGridViewTextBoxColumn";
            workHoursPerDayDataGridViewTextBoxColumn.Width = 250;
            // 
            // workDaysPerWeekDataGridViewTextBoxColumn
            // 
            workDaysPerWeekDataGridViewTextBoxColumn.DataPropertyName = "WorkDaysPerWeek";
            workDaysPerWeekDataGridViewTextBoxColumn.HeaderText = "Количество рабочих дней в неделю";
            workDaysPerWeekDataGridViewTextBoxColumn.MinimumWidth = 6;
            workDaysPerWeekDataGridViewTextBoxColumn.Name = "workDaysPerWeekDataGridViewTextBoxColumn";
            workDaysPerWeekDataGridViewTextBoxColumn.Width = 250;
            // 
            // roleWorkStartDateDataGridViewTextBoxColumn
            // 
            roleWorkStartDateDataGridViewTextBoxColumn.DataPropertyName = "RoleWorkStartDate";
            roleWorkStartDateDataGridViewTextBoxColumn.HeaderText = "Время начала работы на этой должности";
            roleWorkStartDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            roleWorkStartDateDataGridViewTextBoxColumn.Name = "roleWorkStartDateDataGridViewTextBoxColumn";
            roleWorkStartDateDataGridViewTextBoxColumn.Width = 250;
            // 
            // baseSalaryPerHourInRublesDataGridViewTextBoxColumn
            // 
            baseSalaryPerHourInRublesDataGridViewTextBoxColumn.DataPropertyName = "BaseSalaryPerHourInRubles";
            baseSalaryPerHourInRublesDataGridViewTextBoxColumn.HeaderText = "Базовая зарплата в рублях в час";
            baseSalaryPerHourInRublesDataGridViewTextBoxColumn.MinimumWidth = 6;
            baseSalaryPerHourInRublesDataGridViewTextBoxColumn.Name = "baseSalaryPerHourInRublesDataGridViewTextBoxColumn";
            baseSalaryPerHourInRublesDataGridViewTextBoxColumn.Width = 250;
            // 
            // awardsDataGridViewTextBoxColumn
            // 
            awardsDataGridViewTextBoxColumn.DataPropertyName = "Awards";
            awardsDataGridViewTextBoxColumn.HeaderText = "Awards";
            awardsDataGridViewTextBoxColumn.MinimumWidth = 6;
            awardsDataGridViewTextBoxColumn.Name = "awardsDataGridViewTextBoxColumn";
            awardsDataGridViewTextBoxColumn.Visible = false;
            awardsDataGridViewTextBoxColumn.Width = 125;
            // 
            // overtimePeriodsDataGridViewTextBoxColumn
            // 
            overtimePeriodsDataGridViewTextBoxColumn.DataPropertyName = "OvertimePeriods";
            overtimePeriodsDataGridViewTextBoxColumn.HeaderText = "OvertimePeriods";
            overtimePeriodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            overtimePeriodsDataGridViewTextBoxColumn.Name = "overtimePeriodsDataGridViewTextBoxColumn";
            overtimePeriodsDataGridViewTextBoxColumn.Visible = false;
            overtimePeriodsDataGridViewTextBoxColumn.Width = 125;
            // 
            // finesDataGridViewTextBoxColumn
            // 
            finesDataGridViewTextBoxColumn.DataPropertyName = "Fines";
            finesDataGridViewTextBoxColumn.HeaderText = "Fines";
            finesDataGridViewTextBoxColumn.MinimumWidth = 6;
            finesDataGridViewTextBoxColumn.Name = "finesDataGridViewTextBoxColumn";
            finesDataGridViewTextBoxColumn.Visible = false;
            finesDataGridViewTextBoxColumn.Width = 125;
            // 
            // AwardsButton
            // 
            AwardsButton.DataPropertyName = "ID";
            AwardsButton.HeaderText = "Премии";
            AwardsButton.MinimumWidth = 6;
            AwardsButton.Name = "AwardsButton";
            AwardsButton.Text = "Премии";
            AwardsButton.UseColumnTextForButtonValue = true;
            AwardsButton.Width = 125;
            // 
            // OvertimePeriodsButton
            // 
            OvertimePeriodsButton.HeaderText = "Сверхурочные часы";
            OvertimePeriodsButton.MinimumWidth = 6;
            OvertimePeriodsButton.Name = "OvertimePeriodsButton";
            OvertimePeriodsButton.Text = "Сверхурочные часы";
            OvertimePeriodsButton.UseColumnTextForButtonValue = true;
            OvertimePeriodsButton.Width = 200;
            // 
            // FinesButton
            // 
            FinesButton.HeaderText = "Штрафы";
            FinesButton.MinimumWidth = 6;
            FinesButton.Name = "FinesButton";
            FinesButton.Text = "Штрафы";
            FinesButton.UseColumnTextForButtonValue = true;
            FinesButton.Width = 125;
            // 
            // SickPeriodsButton
            // 
            SickPeriodsButton.HeaderText = "Больничные";
            SickPeriodsButton.MinimumWidth = 6;
            SickPeriodsButton.Name = "SickPeriodsButton";
            SickPeriodsButton.Text = "Больничные";
            SickPeriodsButton.UseColumnTextForButtonValue = true;
            SickPeriodsButton.Width = 125;
            // 
            // CalculateSalaryButton
            // 
            CalculateSalaryButton.HeaderText = "Посчитать зарплату";
            CalculateSalaryButton.MinimumWidth = 6;
            CalculateSalaryButton.Name = "CalculateSalaryButton";
            CalculateSalaryButton.Text = "Посчитать зарплату";
            CalculateSalaryButton.UseColumnTextForButtonValue = true;
            CalculateSalaryButton.Width = 150;
            // 
            // DeleteButton
            // 
            DeleteButton.HeaderText = "Удалить";
            DeleteButton.MinimumWidth = 6;
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Text = "Удалить";
            DeleteButton.UseColumnTextForButtonValue = true;
            DeleteButton.Width = 125;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Data.Employee);
            // 
            // TextBox_FilterLastName
            // 
            TextBox_FilterLastName.Location = new Point(6, 46);
            TextBox_FilterLastName.Name = "TextBox_FilterLastName";
            TextBox_FilterLastName.Size = new Size(225, 27);
            TextBox_FilterLastName.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Button_Filter);
            groupBox1.Controls.Add(DateTimePicker_FilterBirthday);
            groupBox1.Controls.Add(CheckBox_FilterBirthday);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TextBox_FilterRole);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TextBox_FilterMiddleName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TextBox_FilterFirstName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TextBox_FilterLastName);
            groupBox1.Location = new Point(550, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 367);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск сотрудников";
            // 
            // Button_Filter
            // 
            Button_Filter.Location = new Point(6, 301);
            Button_Filter.Name = "Button_Filter";
            Button_Filter.Size = new Size(225, 29);
            Button_Filter.TabIndex = 15;
            Button_Filter.Text = "Найти";
            Button_Filter.UseVisualStyleBackColor = true;
            Button_Filter.Click += Button_Filter_Click;
            // 
            // DateTimePicker_FilterBirthday
            // 
            DateTimePicker_FilterBirthday.Location = new Point(6, 268);
            DateTimePicker_FilterBirthday.Name = "DateTimePicker_FilterBirthday";
            DateTimePicker_FilterBirthday.Size = new Size(225, 27);
            DateTimePicker_FilterBirthday.TabIndex = 14;
            // 
            // CheckBox_FilterBirthday
            // 
            CheckBox_FilterBirthday.AutoSize = true;
            CheckBox_FilterBirthday.Location = new Point(6, 238);
            CheckBox_FilterBirthday.Name = "CheckBox_FilterBirthday";
            CheckBox_FilterBirthday.Size = new Size(141, 24);
            CheckBox_FilterBirthday.TabIndex = 13;
            CheckBox_FilterBirthday.Text = "Дата рождения:";
            CheckBox_FilterBirthday.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 182);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 11;
            label5.Text = "Должность:";
            // 
            // TextBox_FilterRole
            // 
            TextBox_FilterRole.Location = new Point(6, 205);
            TextBox_FilterRole.Name = "TextBox_FilterRole";
            TextBox_FilterRole.Size = new Size(225, 27);
            TextBox_FilterRole.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 129);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 9;
            label4.Text = "Отчество:";
            // 
            // TextBox_FilterMiddleName
            // 
            TextBox_FilterMiddleName.Location = new Point(6, 152);
            TextBox_FilterMiddleName.Name = "TextBox_FilterMiddleName";
            TextBox_FilterMiddleName.Size = new Size(225, 27);
            TextBox_FilterMiddleName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 7;
            label3.Text = "Имя:";
            // 
            // TextBox_FilterFirstName
            // 
            TextBox_FilterFirstName.Location = new Point(6, 99);
            TextBox_FilterFirstName.Name = "TextBox_FilterFirstName";
            TextBox_FilterFirstName.Size = new Size(225, 27);
            TextBox_FilterFirstName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Фамилия:";
            // 
            // Button_AddEmployee
            // 
            Button_AddEmployee.Location = new Point(12, 413);
            Button_AddEmployee.Name = "Button_AddEmployee";
            Button_AddEmployee.Size = new Size(225, 29);
            Button_AddEmployee.TabIndex = 16;
            Button_AddEmployee.Text = "Добавить нового сотрудника";
            Button_AddEmployee.UseVisualStyleBackColor = true;
            Button_AddEmployee.Click += Button_AddEmployee_Click;
            // 
            // Button_Save
            // 
            Button_Save.Location = new Point(243, 413);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(200, 29);
            Button_Save.TabIndex = 18;
            Button_Save.Text = "Сохранить изменения";
            Button_Save.UseVisualStyleBackColor = true;
            Button_Save.Click += Button_Save_Click;
            // 
            // Button_Report
            // 
            Button_Report.Location = new Point(588, 413);
            Button_Report.Name = "Button_Report";
            Button_Report.Size = new Size(200, 29);
            Button_Report.TabIndex = 19;
            Button_Report.Text = "Отчёт о зарплатах";
            Button_Report.UseVisualStyleBackColor = true;
            Button_Report.Click += Button_Report_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button_Report);
            Controls.Add(Button_Save);
            Controls.Add(Button_AddEmployee);
            Controls.Add(groupBox1);
            Controls.Add(DataGridView_Data);
            Controls.Add(label1);
            Name = "MainMenuForm";
            Tag = "";
            Text = "Сотрудники ресторана - Список сотрудников";
            ((System.ComponentModel.ISupportInitialize)DataGridView_Data).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DataGridView_Data;
        private TextBox TextBox_FilterLastName;
        private GroupBox groupBox1;
        private Button Button_Filter;
        private DateTimePicker DateTimePicker_FilterBirthday;
        private CheckBox CheckBox_FilterBirthday;
        private Label label5;
        private TextBox TextBox_FilterRole;
        private Label label4;
        private TextBox TextBox_FilterMiddleName;
        private Label label3;
        private TextBox TextBox_FilterFirstName;
        private Label label2;
        private Button Button_AddEmployee;
        private Button Button_Save;
        private BindingSource employeeBindingSource;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workHoursPerDayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workDaysPerWeekDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleWorkStartDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn baseSalaryPerHourInRublesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn awardsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn overtimePeriodsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finesDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn AwardsButton;
        private DataGridViewButtonColumn OvertimePeriodsButton;
        private DataGridViewButtonColumn FinesButton;
        private DataGridViewButtonColumn SickPeriodsButton;
        private DataGridViewButtonColumn CalculateSalaryButton;
        private DataGridViewButtonColumn DeleteButton;
        private Button Button_Report;
    }
}