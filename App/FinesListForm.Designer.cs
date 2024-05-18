namespace App
{
    partial class FinesListForm
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
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reasonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giverIDDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            employeeListBindingSource = new BindingSource(components);
            employeeNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DeleteButton = new DataGridViewButtonColumn();
            fineBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            Button_Filter = new Button();
            TextBox_FilterReason = new TextBox();
            CheckBox_FilterReason = new CheckBox();
            GroupBox_FilterAmount = new GroupBox();
            TextBox_FilterAmountEnd = new TextBox();
            TextBox_FilterAmountStart = new TextBox();
            label4 = new Label();
            label5 = new Label();
            CheckBox_FilterAmount = new CheckBox();
            GroupBox_FilterDate = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            DateTimePicker_FilterDateEnd = new DateTimePicker();
            DateTimePicker_FilterDateStart = new DateTimePicker();
            CheckBox_FilterDate = new CheckBox();
            Button_AddFine = new Button();
            Button_Save = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fineBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            GroupBox_FilterAmount.SuspendLayout();
            GroupBox_FilterDate.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 28);
            label1.TabIndex = 3;
            label1.Text = "Список штрафов сотрудника";
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
            DataGridView_Data.Columns.AddRange(new DataGridViewColumn[] { id, employeeIDDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, reasonDataGridViewTextBoxColumn, giverIDDataGridViewTextBoxColumn, employeeNavigationDataGridViewTextBoxColumn, DeleteButton });
            DataGridView_Data.DataSource = fineBindingSource;
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
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Сумма штрафа (в рублях)";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.Width = 220;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Дата получения";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            reasonDataGridViewTextBoxColumn.HeaderText = "Причина";
            reasonDataGridViewTextBoxColumn.MinimumWidth = 6;
            reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            reasonDataGridViewTextBoxColumn.Width = 400;
            // 
            // giverIDDataGridViewTextBoxColumn
            // 
            giverIDDataGridViewTextBoxColumn.DataPropertyName = "GiverID";
            giverIDDataGridViewTextBoxColumn.DataSource = employeeListBindingSource;
            giverIDDataGridViewTextBoxColumn.DisplayMember = "Text";
            giverIDDataGridViewTextBoxColumn.HeaderText = "Кем выдан";
            giverIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            giverIDDataGridViewTextBoxColumn.Name = "giverIDDataGridViewTextBoxColumn";
            giverIDDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            giverIDDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            giverIDDataGridViewTextBoxColumn.ValueMember = "ID";
            giverIDDataGridViewTextBoxColumn.Width = 400;
            // 
            // employeeListBindingSource
            // 
            employeeListBindingSource.DataSource = typeof(Data.IdToTextMap);
            // 
            // employeeNavigationDataGridViewTextBoxColumn
            // 
            employeeNavigationDataGridViewTextBoxColumn.DataPropertyName = "EmployeeNavigation";
            employeeNavigationDataGridViewTextBoxColumn.HeaderText = "EmployeeNavigation";
            employeeNavigationDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeNavigationDataGridViewTextBoxColumn.Name = "employeeNavigationDataGridViewTextBoxColumn";
            employeeNavigationDataGridViewTextBoxColumn.Visible = false;
            employeeNavigationDataGridViewTextBoxColumn.Width = 125;
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
            // fineBindingSource
            // 
            fineBindingSource.DataSource = typeof(Data.Fine);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Button_Filter);
            groupBox1.Controls.Add(TextBox_FilterReason);
            groupBox1.Controls.Add(CheckBox_FilterReason);
            groupBox1.Controls.Add(GroupBox_FilterAmount);
            groupBox1.Controls.Add(CheckBox_FilterAmount);
            groupBox1.Controls.Add(GroupBox_FilterDate);
            groupBox1.Controls.Add(CheckBox_FilterDate);
            groupBox1.Location = new Point(573, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 241);
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
            TextBox_FilterReason.Location = new Point(367, 56);
            TextBox_FilterReason.Multiline = true;
            TextBox_FilterReason.Name = "TextBox_FilterReason";
            TextBox_FilterReason.Size = new Size(150, 138);
            TextBox_FilterReason.TabIndex = 6;
            // 
            // CheckBox_FilterReason
            // 
            CheckBox_FilterReason.AutoSize = true;
            CheckBox_FilterReason.Location = new Point(367, 26);
            CheckBox_FilterReason.Name = "CheckBox_FilterReason";
            CheckBox_FilterReason.Size = new Size(116, 24);
            CheckBox_FilterReason.TabIndex = 5;
            CheckBox_FilterReason.Text = "По причине";
            CheckBox_FilterReason.UseVisualStyleBackColor = true;
            CheckBox_FilterReason.CheckedChanged += CheckBox_FilterReason_CheckedChanged;
            // 
            // GroupBox_FilterAmount
            // 
            GroupBox_FilterAmount.Controls.Add(TextBox_FilterAmountEnd);
            GroupBox_FilterAmount.Controls.Add(TextBox_FilterAmountStart);
            GroupBox_FilterAmount.Controls.Add(label4);
            GroupBox_FilterAmount.Controls.Add(label5);
            GroupBox_FilterAmount.Enabled = false;
            GroupBox_FilterAmount.Location = new Point(6, 56);
            GroupBox_FilterAmount.Name = "GroupBox_FilterAmount";
            GroupBox_FilterAmount.Size = new Size(140, 138);
            GroupBox_FilterAmount.TabIndex = 4;
            GroupBox_FilterAmount.TabStop = false;
            GroupBox_FilterAmount.Text = "Сумма";
            // 
            // TextBox_FilterAmountEnd
            // 
            TextBox_FilterAmountEnd.Location = new Point(7, 99);
            TextBox_FilterAmountEnd.Name = "TextBox_FilterAmountEnd";
            TextBox_FilterAmountEnd.Size = new Size(125, 27);
            TextBox_FilterAmountEnd.TabIndex = 5;
            // 
            // TextBox_FilterAmountStart
            // 
            TextBox_FilterAmountStart.Location = new Point(7, 46);
            TextBox_FilterAmountStart.Name = "TextBox_FilterAmountStart";
            TextBox_FilterAmountStart.Size = new Size(125, 27);
            TextBox_FilterAmountStart.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 76);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 3;
            label4.Text = "Верхний предел:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 23);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 2;
            label5.Text = "Нижний предел:";
            // 
            // CheckBox_FilterAmount
            // 
            CheckBox_FilterAmount.AutoSize = true;
            CheckBox_FilterAmount.Location = new Point(6, 26);
            CheckBox_FilterAmount.Name = "CheckBox_FilterAmount";
            CheckBox_FilterAmount.Size = new Size(99, 24);
            CheckBox_FilterAmount.TabIndex = 2;
            CheckBox_FilterAmount.Text = "По сумме";
            CheckBox_FilterAmount.UseVisualStyleBackColor = true;
            CheckBox_FilterAmount.CheckedChanged += CheckBox_FilterAmount_CheckedChanged;
            // 
            // GroupBox_FilterDate
            // 
            GroupBox_FilterDate.Controls.Add(label3);
            GroupBox_FilterDate.Controls.Add(label2);
            GroupBox_FilterDate.Controls.Add(DateTimePicker_FilterDateEnd);
            GroupBox_FilterDate.Controls.Add(DateTimePicker_FilterDateStart);
            GroupBox_FilterDate.Enabled = false;
            GroupBox_FilterDate.Location = new Point(156, 56);
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
            CheckBox_FilterDate.Location = new Point(156, 26);
            CheckBox_FilterDate.Name = "CheckBox_FilterDate";
            CheckBox_FilterDate.Size = new Size(85, 24);
            CheckBox_FilterDate.TabIndex = 0;
            CheckBox_FilterDate.Text = "По дате";
            CheckBox_FilterDate.UseVisualStyleBackColor = true;
            CheckBox_FilterDate.CheckedChanged += CheckBox_FilterDate_CheckedChanged;
            // 
            // Button_AddFine
            // 
            Button_AddFine.Location = new Point(12, 384);
            Button_AddFine.Name = "Button_AddFine";
            Button_AddFine.Size = new Size(150, 29);
            Button_AddFine.TabIndex = 7;
            Button_AddFine.Text = "Добавить штраф";
            Button_AddFine.UseVisualStyleBackColor = true;
            Button_AddFine.Click += Button_AddFine_Click;
            // 
            // Button_Save
            // 
            Button_Save.Location = new Point(168, 384);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(200, 29);
            Button_Save.TabIndex = 8;
            Button_Save.Text = "Сохранить изменения";
            Button_Save.UseVisualStyleBackColor = true;
            Button_Save.Click += Button_Save_Click;
            // 
            // FinesListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 421);
            Controls.Add(Button_Save);
            Controls.Add(Button_AddFine);
            Controls.Add(groupBox1);
            Controls.Add(DataGridView_Data);
            Controls.Add(Label_EmployeeName);
            Controls.Add(label1);
            Name = "FinesListForm";
            Text = "Сотрудники ресторана - Список штрафов сотрудника";
            ((System.ComponentModel.ISupportInitialize)DataGridView_Data).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fineBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            GroupBox_FilterAmount.ResumeLayout(false);
            GroupBox_FilterAmount.PerformLayout();
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
        private GroupBox GroupBox_FilterAmount;
        private Label label4;
        private Label label5;
        private CheckBox CheckBox_FilterAmount;
        private TextBox TextBox_FilterAmountEnd;
        private TextBox TextBox_FilterAmountStart;
        private TextBox TextBox_FilterReason;
        private CheckBox CheckBox_FilterReason;
        private Button Button_AddFine;
        private Button Button_Save;
        private Button Button_Filter;
        private BindingSource fineBindingSource;
        private BindingSource employeeListBindingSource;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn giverIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeNavigationDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn DeleteButton;
    }
}