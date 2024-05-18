namespace App
{
    partial class AddFineForm
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
            TextBox_Amount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            DateTimePicker_Date = new DateTimePicker();
            Button_TodayDate = new Button();
            label4 = new Label();
            TextBox_Reason = new TextBox();
            Button_Add = new Button();
            label5 = new Label();
            ComboBox_Giver = new ComboBox();
            employeeListBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)employeeListBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(334, 28);
            label1.TabIndex = 4;
            label1.Text = "Добавление штрафа сотруднику";
            // 
            // Label_EmployeeName
            // 
            Label_EmployeeName.AutoSize = true;
            Label_EmployeeName.Location = new Point(12, 37);
            Label_EmployeeName.Name = "Label_EmployeeName";
            Label_EmployeeName.Size = new Size(172, 20);
            Label_EmployeeName.TabIndex = 5;
            Label_EmployeeName.Text = "(имя сотрудника здесь)";
            // 
            // TextBox_Amount
            // 
            TextBox_Amount.Location = new Point(12, 92);
            TextBox_Amount.Name = "TextBox_Amount";
            TextBox_Amount.Size = new Size(125, 27);
            TextBox_Amount.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 7;
            label2.Text = "Сумма штрафа (в рублях):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 8;
            label3.Text = "Дата получения:";
            // 
            // DateTimePicker_Date
            // 
            DateTimePicker_Date.Location = new Point(12, 154);
            DateTimePicker_Date.Name = "DateTimePicker_Date";
            DateTimePicker_Date.Size = new Size(250, 27);
            DateTimePicker_Date.TabIndex = 9;
            // 
            // Button_TodayDate
            // 
            Button_TodayDate.Location = new Point(12, 187);
            Button_TodayDate.Name = "Button_TodayDate";
            Button_TodayDate.Size = new Size(200, 29);
            Button_TodayDate.TabIndex = 10;
            Button_TodayDate.Text = "Установить на сегодня";
            Button_TodayDate.UseVisualStyleBackColor = true;
            Button_TodayDate.Click += Button_TodayDate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 230);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 11;
            label4.Text = "Причина штрафа:";
            // 
            // TextBox_Reason
            // 
            TextBox_Reason.Location = new Point(12, 253);
            TextBox_Reason.Multiline = true;
            TextBox_Reason.Name = "TextBox_Reason";
            TextBox_Reason.Size = new Size(400, 50);
            TextBox_Reason.TabIndex = 12;
            // 
            // Button_Add
            // 
            Button_Add.Location = new Point(110, 372);
            Button_Add.Name = "Button_Add";
            Button_Add.Size = new Size(200, 29);
            Button_Add.TabIndex = 25;
            Button_Add.Text = "Добавить";
            Button_Add.UseVisualStyleBackColor = true;
            Button_Add.Click += Button_Add_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 315);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 26;
            label5.Text = "Кем выдан:";
            // 
            // ComboBox_Giver
            // 
            ComboBox_Giver.DataSource = employeeListBindingSource;
            ComboBox_Giver.DisplayMember = "Text";
            ComboBox_Giver.FormattingEnabled = true;
            ComboBox_Giver.Location = new Point(12, 338);
            ComboBox_Giver.Name = "ComboBox_Giver";
            ComboBox_Giver.Size = new Size(400, 28);
            ComboBox_Giver.TabIndex = 27;
            ComboBox_Giver.ValueMember = "ID";
            // 
            // employeeListBindingSource
            // 
            employeeListBindingSource.DataSource = typeof(Data.IdToTextMap);
            // 
            // AddFineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 407);
            Controls.Add(ComboBox_Giver);
            Controls.Add(label5);
            Controls.Add(Button_Add);
            Controls.Add(TextBox_Reason);
            Controls.Add(label4);
            Controls.Add(Button_TodayDate);
            Controls.Add(DateTimePicker_Date);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TextBox_Amount);
            Controls.Add(Label_EmployeeName);
            Controls.Add(label1);
            Name = "AddFineForm";
            Text = "Сотрудники ресторана - Добавление штрафа сотруднику";
            ((System.ComponentModel.ISupportInitialize)employeeListBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Label_EmployeeName;
        private TextBox TextBox_Amount;
        private Label label2;
        private Label label3;
        private DateTimePicker DateTimePicker_Date;
        private Button Button_TodayDate;
        private Label label4;
        private TextBox TextBox_Reason;
        private Button Button_Add;
        private Label label5;
        private ComboBox ComboBox_Giver;
        private BindingSource employeeListBindingSource;
    }
}