namespace App
{
    partial class AddSickPeriodForm
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
            Label_EmployeeName = new Label();
            label3 = new Label();
            DateTimePicker_StartDate = new DateTimePicker();
            Button_StartTodayDate = new Button();
            label4 = new Label();
            TextBox_Reason = new TextBox();
            Button_Add = new Button();
            Button_EndTodayDate = new Button();
            DateTimePicker_EndDate = new DateTimePicker();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(475, 28);
            label1.TabIndex = 4;
            label1.Text = "Добавление больничного периода сотруднику";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(258, 20);
            label3.TabIndex = 8;
            label3.Text = "Дата начала больничного периода:";
            // 
            // DateTimePicker_StartDate
            // 
            DateTimePicker_StartDate.Location = new Point(12, 91);
            DateTimePicker_StartDate.Name = "DateTimePicker_StartDate";
            DateTimePicker_StartDate.Size = new Size(250, 27);
            DateTimePicker_StartDate.TabIndex = 9;
            // 
            // Button_StartTodayDate
            // 
            Button_StartTodayDate.Location = new Point(12, 124);
            Button_StartTodayDate.Name = "Button_StartTodayDate";
            Button_StartTodayDate.Size = new Size(200, 29);
            Button_StartTodayDate.TabIndex = 10;
            Button_StartTodayDate.Text = "Установить на сегодня";
            Button_StartTodayDate.UseVisualStyleBackColor = true;
            Button_StartTodayDate.Click += Button_StartTodayDate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 273);
            label4.Name = "label4";
            label4.Size = new Size(346, 20);
            label4.TabIndex = 11;
            label4.Text = "Причина больничного периода (опционально):";
            // 
            // TextBox_Reason
            // 
            TextBox_Reason.Location = new Point(12, 296);
            TextBox_Reason.Multiline = true;
            TextBox_Reason.Name = "TextBox_Reason";
            TextBox_Reason.Size = new Size(346, 50);
            TextBox_Reason.TabIndex = 12;
            // 
            // Button_Add
            // 
            Button_Add.Location = new Point(149, 359);
            Button_Add.Name = "Button_Add";
            Button_Add.Size = new Size(200, 29);
            Button_Add.TabIndex = 25;
            Button_Add.Text = "Добавить";
            Button_Add.UseVisualStyleBackColor = true;
            Button_Add.Click += Button_Add_Click;
            // 
            // Button_EndTodayDate
            // 
            Button_EndTodayDate.Location = new Point(12, 226);
            Button_EndTodayDate.Name = "Button_EndTodayDate";
            Button_EndTodayDate.Size = new Size(200, 29);
            Button_EndTodayDate.TabIndex = 28;
            Button_EndTodayDate.Text = "Установить на сегодня";
            Button_EndTodayDate.UseVisualStyleBackColor = true;
            Button_EndTodayDate.Click += Button_EndTodayDate_Click;
            // 
            // DateTimePicker_EndDate
            // 
            DateTimePicker_EndDate.Location = new Point(12, 193);
            DateTimePicker_EndDate.Name = "DateTimePicker_EndDate";
            DateTimePicker_EndDate.Size = new Size(250, 27);
            DateTimePicker_EndDate.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(251, 20);
            label2.TabIndex = 26;
            label2.Text = "Дата конца больничного периода:";
            // 
            // AddSickPeriodForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 400);
            Controls.Add(Button_EndTodayDate);
            Controls.Add(DateTimePicker_EndDate);
            Controls.Add(label2);
            Controls.Add(Button_Add);
            Controls.Add(TextBox_Reason);
            Controls.Add(label4);
            Controls.Add(Button_StartTodayDate);
            Controls.Add(DateTimePicker_StartDate);
            Controls.Add(label3);
            Controls.Add(Label_EmployeeName);
            Controls.Add(label1);
            Name = "AddSickPeriodForm";
            Text = "Сотрудники ресторана - Добавление больничного периода сотруднику";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Label_EmployeeName;
        private Label label3;
        private DateTimePicker DateTimePicker_StartDate;
        private Button Button_StartTodayDate;
        private Label label4;
        private TextBox TextBox_Reason;
        private Button Button_Add;
        private Button Button_EndTodayDate;
        private DateTimePicker DateTimePicker_EndDate;
        private Label label2;
    }
}