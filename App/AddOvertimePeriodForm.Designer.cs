namespace App
{
    partial class AddOvertimePeriodForm
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
            Button_Add = new Button();
            Button_TodayDate = new Button();
            DateTimePicker_Date = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            TextBox_Amount = new TextBox();
            Label_EmployeeName = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Button_Add
            // 
            Button_Add.Location = new Point(85, 238);
            Button_Add.Name = "Button_Add";
            Button_Add.Size = new Size(200, 29);
            Button_Add.TabIndex = 33;
            Button_Add.Text = "Добавить";
            Button_Add.UseVisualStyleBackColor = true;
            Button_Add.Click += Button_Add_Click;
            // 
            // Button_TodayDate
            // 
            Button_TodayDate.Location = new Point(12, 124);
            Button_TodayDate.Name = "Button_TodayDate";
            Button_TodayDate.Size = new Size(200, 29);
            Button_TodayDate.TabIndex = 32;
            Button_TodayDate.Text = "Установить на сегодня";
            Button_TodayDate.UseVisualStyleBackColor = true;
            Button_TodayDate.Click += Button_TodayDate_Click;
            // 
            // DateTimePicker_Date
            // 
            DateTimePicker_Date.Location = new Point(12, 91);
            DateTimePicker_Date.Name = "DateTimePicker_Date";
            DateTimePicker_Date.Size = new Size(250, 27);
            DateTimePicker_Date.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 30;
            label3.Text = "Дата получения:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 29;
            label2.Text = "Количество часов:";
            // 
            // TextBox_Amount
            // 
            TextBox_Amount.Location = new Point(12, 193);
            TextBox_Amount.Name = "TextBox_Amount";
            TextBox_Amount.Size = new Size(125, 27);
            TextBox_Amount.TabIndex = 28;
            // 
            // Label_EmployeeName
            // 
            Label_EmployeeName.AutoSize = true;
            Label_EmployeeName.Location = new Point(12, 37);
            Label_EmployeeName.Name = "Label_EmployeeName";
            Label_EmployeeName.Size = new Size(172, 20);
            Label_EmployeeName.TabIndex = 27;
            Label_EmployeeName.Text = "(имя сотрудника здесь)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(345, 28);
            label1.TabIndex = 26;
            label1.Text = "Добавление сверхурочных часов";
            // 
            // AddOvertimePeriodForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 282);
            Controls.Add(Button_Add);
            Controls.Add(Button_TodayDate);
            Controls.Add(DateTimePicker_Date);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TextBox_Amount);
            Controls.Add(Label_EmployeeName);
            Controls.Add(label1);
            Name = "AddOvertimePeriodForm";
            Text = "Сотрудники ресторана - Добавление сверхурочных часов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Add;
        private Button Button_TodayDate;
        private DateTimePicker DateTimePicker_Date;
        private Label label3;
        private Label label2;
        private TextBox TextBox_Amount;
        private Label Label_EmployeeName;
        private Label label1;
    }
}