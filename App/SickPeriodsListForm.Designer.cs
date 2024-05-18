namespace App
{
    partial class SickPeriodsListForm
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
            Label_EmployeeName = new Label();
            DataGridView_Data = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            employeeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reasonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DeleteButton = new DataGridViewButtonColumn();
            sickPeriodBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            Button_Filter = new Button();
            TextBox_FilterReason = new TextBox();
            CheckBox_FilterReason = new CheckBox();
            GroupBox_FilterDate = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            DateTimePicker_FilterDateEnd = new DateTimePicker();
            DateTimePicker_FilterDateStart = new DateTimePicker();
            CheckBox_FilterDate = new CheckBox();
            Button_AddSickPeriod = new Button();
            Button_Save = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sickPeriodBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            GroupBox_FilterDate.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(431, 28);
            label1.TabIndex = 3;
            label1.Text = "Список больничных периодов сотрудника";
            // 
            // Label_EmployeeName
            // 
            Label_EmployeeName.AutoSize = true;
            Label_EmployeeName.Location = new Point(12, 37);
            Label_EmployeeName.Name = "Label_EmployeeName";
            Label_EmployeeName.Size = new Size(172, 20);
            Label_EmployeeName.TabIndex = 4;
            Label_EmployeeName.Text = "(имя сотрудника здесь)";
            // 
            // DataGridView_Data
            // 
            DataGridView_Data.AllowUserToAddRows = false;
            DataGridView_Data.AllowUserToDeleteRows = false;
            DataGridView_Data.AutoGenerateColumns = false;
            DataGridView_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Data.Columns.AddRange(new DataGridViewColumn[] { id, employeeIDDataGridViewTextBoxColumn, dateStartDataGridViewTextBoxColumn, dateEndDataGridViewTextBoxColumn, reasonDataGridViewTextBoxColumn, DeleteButton });
            DataGridView_Data.DataSource = sickPeriodBindingSource;
            DataGridView_Data.Location = new Point(12, 60);
            DataGridView_Data.Name = "DataGridView_Data";
            DataGridView_Data.RowHeadersWidth = 51;
            DataGridView_Data.RowTemplate.Height = 29;
            DataGridView_Data.Size = new Size(555, 318);
            DataGridView_Data.TabIndex = 5;
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
            // employeeIDDataGridViewTextBoxColumn
            // 
            employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            employeeIDDataGridViewTextBoxColumn.Visible = false;
            employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            dateStartDataGridViewTextBoxColumn.HeaderText = "Начало периода";
            dateStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            dateStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            dateEndDataGridViewTextBoxColumn.HeaderText = "Конец периода";
            dateEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            dateEndDataGridViewTextBoxColumn.Width = 125;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            reasonDataGridViewTextBoxColumn.HeaderText = "Причина (опционально)";
            reasonDataGridViewTextBoxColumn.MinimumWidth = 6;
            reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            reasonDataGridViewTextBoxColumn.Width = 400;
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
            // sickPeriodBindingSource
            // 
            sickPeriodBindingSource.DataSource = typeof(Data.SickPeriod);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Button_Filter);
            groupBox1.Controls.Add(TextBox_FilterReason);
            groupBox1.Controls.Add(CheckBox_FilterReason);
            groupBox1.Controls.Add(GroupBox_FilterDate);
            groupBox1.Controls.Add(CheckBox_FilterDate);
            groupBox1.Location = new Point(573, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 241);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтрация";
            // 
            // Button_Filter
            // 
            Button_Filter.Location = new Point(6, 200);
            Button_Filter.Name = "Button_Filter";
            Button_Filter.Size = new Size(150, 29);
            Button_Filter.TabIndex = 9;
            Button_Filter.Text = "Фильтровать";
            Button_Filter.UseVisualStyleBackColor = true;
            Button_Filter.Click += Button_Filter_Click;
            // 
            // TextBox_FilterReason
            // 
            TextBox_FilterReason.Enabled = false;
            TextBox_FilterReason.Location = new Point(217, 56);
            TextBox_FilterReason.Multiline = true;
            TextBox_FilterReason.Name = "TextBox_FilterReason";
            TextBox_FilterReason.Size = new Size(150, 138);
            TextBox_FilterReason.TabIndex = 6;
            // 
            // CheckBox_FilterReason
            // 
            CheckBox_FilterReason.AutoSize = true;
            CheckBox_FilterReason.Location = new Point(217, 26);
            CheckBox_FilterReason.Name = "CheckBox_FilterReason";
            CheckBox_FilterReason.Size = new Size(116, 24);
            CheckBox_FilterReason.TabIndex = 5;
            CheckBox_FilterReason.Text = "По причине";
            CheckBox_FilterReason.UseVisualStyleBackColor = true;
            CheckBox_FilterReason.CheckedChanged += CheckBox_FilterReason_CheckedChanged;
            // 
            // GroupBox_FilterDate
            // 
            GroupBox_FilterDate.Controls.Add(label3);
            GroupBox_FilterDate.Controls.Add(label2);
            GroupBox_FilterDate.Controls.Add(DateTimePicker_FilterDateEnd);
            GroupBox_FilterDate.Controls.Add(DateTimePicker_FilterDateStart);
            GroupBox_FilterDate.Enabled = false;
            GroupBox_FilterDate.Location = new Point(6, 56);
            GroupBox_FilterDate.Name = "GroupBox_FilterDate";
            GroupBox_FilterDate.Size = new Size(203, 138);
            GroupBox_FilterDate.TabIndex = 1;
            GroupBox_FilterDate.TabStop = false;
            GroupBox_FilterDate.Text = "Период поиска";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 3;
            label3.Text = "Конец:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Начало:";
            // 
            // DateTimePicker_FilterDateEnd
            // 
            DateTimePicker_FilterDateEnd.Location = new Point(6, 99);
            DateTimePicker_FilterDateEnd.Name = "DateTimePicker_FilterDateEnd";
            DateTimePicker_FilterDateEnd.Size = new Size(191, 27);
            DateTimePicker_FilterDateEnd.TabIndex = 1;
            // 
            // DateTimePicker_FilterDateStart
            // 
            DateTimePicker_FilterDateStart.Location = new Point(6, 46);
            DateTimePicker_FilterDateStart.Name = "DateTimePicker_FilterDateStart";
            DateTimePicker_FilterDateStart.Size = new Size(191, 27);
            DateTimePicker_FilterDateStart.TabIndex = 0;
            // 
            // CheckBox_FilterDate
            // 
            CheckBox_FilterDate.AutoSize = true;
            CheckBox_FilterDate.Location = new Point(6, 26);
            CheckBox_FilterDate.Name = "CheckBox_FilterDate";
            CheckBox_FilterDate.Size = new Size(85, 24);
            CheckBox_FilterDate.TabIndex = 0;
            CheckBox_FilterDate.Text = "По дате";
            CheckBox_FilterDate.UseVisualStyleBackColor = true;
            CheckBox_FilterDate.CheckedChanged += CheckBox_FilterDate_CheckedChanged;
            // 
            // Button_AddSickPeriod
            // 
            Button_AddSickPeriod.Location = new Point(12, 384);
            Button_AddSickPeriod.Name = "Button_AddSickPeriod";
            Button_AddSickPeriod.Size = new Size(250, 29);
            Button_AddSickPeriod.TabIndex = 7;
            Button_AddSickPeriod.Text = "Добавить больничный период";
            Button_AddSickPeriod.UseVisualStyleBackColor = true;
            Button_AddSickPeriod.Click += Button_AddSickPeriod_Click;
            // 
            // Button_Save
            // 
            Button_Save.Location = new Point(268, 384);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(200, 29);
            Button_Save.TabIndex = 8;
            Button_Save.Text = "Сохранить изменения";
            Button_Save.UseVisualStyleBackColor = true;
            Button_Save.Click += Button_Save_Click;
            // 
            // SickPeriodsListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 421);
            Controls.Add(Button_Save);
            Controls.Add(Button_AddSickPeriod);
            Controls.Add(groupBox1);
            Controls.Add(DataGridView_Data);
            Controls.Add(Label_EmployeeName);
            Controls.Add(label1);
            Name = "SickPeriodsListForm";
            Text = "Сотрудники ресторана - Список больничных периодов сотрудника";
            ((System.ComponentModel.ISupportInitialize)DataGridView_Data).EndInit();
            ((System.ComponentModel.ISupportInitialize)sickPeriodBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            GroupBox_FilterDate.ResumeLayout(false);
            GroupBox_FilterDate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Label_EmployeeName;
        private DataGridView DataGridView_Data;
        private GroupBox groupBox1;
        private CheckBox CheckBox_FilterDate;
        private GroupBox GroupBox_FilterDate;
        private Label label3;
        private Label label2;
        private DateTimePicker DateTimePicker_FilterDateEnd;
        private DateTimePicker DateTimePicker_FilterDateStart;
        private TextBox TextBox_FilterReason;
        private CheckBox CheckBox_FilterReason;
        private Button Button_AddSickPeriod;
        private Button Button_Save;
        private Button Button_Filter;
        private BindingSource sickPeriodBindingSource;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn DeleteButton;
    }
}