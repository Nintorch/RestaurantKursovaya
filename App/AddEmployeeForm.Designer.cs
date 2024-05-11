namespace App
{
    partial class AddEmployeeForm
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
            TextBox_LastName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TextBox_FirstName = new TextBox();
            label4 = new Label();
            TextBox_MiddleName = new TextBox();
            label5 = new Label();
            TextBox_Role = new TextBox();
            label6 = new Label();
            DateTimePicker_Birthday = new DateTimePicker();
            label7 = new Label();
            TextBox_WorkHoursPerDay = new TextBox();
            label8 = new Label();
            TextBox_WorkDaysPerWeek = new TextBox();
            DateTimePicker_RoleWorkStart = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            TextBox_BaseSalaryPerHour = new TextBox();
            Button_Add = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(252, 28);
            label1.TabIndex = 3;
            label1.Text = "Добавление сотрудника";
            // 
            // TextBox_LastName
            // 
            TextBox_LastName.Location = new Point(12, 60);
            TextBox_LastName.Name = "TextBox_LastName";
            TextBox_LastName.Size = new Size(250, 27);
            TextBox_LastName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Фамилия:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 7;
            label3.Text = "Имя:";
            // 
            // TextBox_FirstName
            // 
            TextBox_FirstName.Location = new Point(12, 113);
            TextBox_FirstName.Name = "TextBox_FirstName";
            TextBox_FirstName.Size = new Size(250, 27);
            TextBox_FirstName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 9;
            label4.Text = "Отчество (если имеется):";
            // 
            // TextBox_MiddleName
            // 
            TextBox_MiddleName.Location = new Point(12, 166);
            TextBox_MiddleName.Name = "TextBox_MiddleName";
            TextBox_MiddleName.Size = new Size(250, 27);
            TextBox_MiddleName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 249);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 11;
            label5.Text = "Должность:";
            // 
            // TextBox_Role
            // 
            TextBox_Role.Location = new Point(12, 272);
            TextBox_Role.Name = "TextBox_Role";
            TextBox_Role.Size = new Size(250, 27);
            TextBox_Role.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 196);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 12;
            label6.Text = "Дата рождения:";
            // 
            // DateTimePicker_Birthday
            // 
            DateTimePicker_Birthday.Location = new Point(12, 219);
            DateTimePicker_Birthday.Name = "DateTimePicker_Birthday";
            DateTimePicker_Birthday.Size = new Size(225, 27);
            DateTimePicker_Birthday.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(290, 37);
            label7.Name = "label7";
            label7.Size = new Size(249, 20);
            label7.TabIndex = 17;
            label7.Text = "Количество рабочих часов в день:";
            // 
            // TextBox_WorkHoursPerDay
            // 
            TextBox_WorkHoursPerDay.Location = new Point(290, 60);
            TextBox_WorkHoursPerDay.Name = "TextBox_WorkHoursPerDay";
            TextBox_WorkHoursPerDay.Size = new Size(125, 27);
            TextBox_WorkHoursPerDay.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(290, 90);
            label8.Name = "label8";
            label8.Size = new Size(263, 20);
            label8.TabIndex = 19;
            label8.Text = "Количество рабочих дней в неделю:";
            // 
            // TextBox_WorkDaysPerWeek
            // 
            TextBox_WorkDaysPerWeek.Location = new Point(290, 113);
            TextBox_WorkDaysPerWeek.Name = "TextBox_WorkDaysPerWeek";
            TextBox_WorkDaysPerWeek.Size = new Size(125, 27);
            TextBox_WorkDaysPerWeek.TabIndex = 18;
            // 
            // DateTimePicker_RoleWorkStart
            // 
            DateTimePicker_RoleWorkStart.Location = new Point(290, 166);
            DateTimePicker_RoleWorkStart.Name = "DateTimePicker_RoleWorkStart";
            DateTimePicker_RoleWorkStart.Size = new Size(225, 27);
            DateTimePicker_RoleWorkStart.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(290, 143);
            label9.Name = "label9";
            label9.Size = new Size(289, 20);
            label9.TabIndex = 20;
            label9.Text = "Дата начала работы на этой должности:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(290, 196);
            label10.Name = "label10";
            label10.Size = new Size(249, 20);
            label10.TabIndex = 23;
            label10.Text = "Базовая зарплата (в рублях в час):";
            // 
            // TextBox_BaseSalaryPerHour
            // 
            TextBox_BaseSalaryPerHour.Location = new Point(290, 219);
            TextBox_BaseSalaryPerHour.Name = "TextBox_BaseSalaryPerHour";
            TextBox_BaseSalaryPerHour.Size = new Size(125, 27);
            TextBox_BaseSalaryPerHour.TabIndex = 22;
            // 
            // Button_Add
            // 
            Button_Add.Location = new Point(196, 321);
            Button_Add.Name = "Button_Add";
            Button_Add.Size = new Size(200, 29);
            Button_Add.TabIndex = 24;
            Button_Add.Text = "Добавить";
            Button_Add.UseVisualStyleBackColor = true;
            Button_Add.Click += Button_Add_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 369);
            Controls.Add(Button_Add);
            Controls.Add(label10);
            Controls.Add(TextBox_BaseSalaryPerHour);
            Controls.Add(DateTimePicker_RoleWorkStart);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(TextBox_WorkDaysPerWeek);
            Controls.Add(label7);
            Controls.Add(TextBox_WorkHoursPerDay);
            Controls.Add(DateTimePicker_Birthday);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TextBox_Role);
            Controls.Add(label4);
            Controls.Add(TextBox_MiddleName);
            Controls.Add(label3);
            Controls.Add(TextBox_FirstName);
            Controls.Add(label2);
            Controls.Add(TextBox_LastName);
            Controls.Add(label1);
            Name = "AddEmployeeForm";
            Text = "Сотрудники ресторана - Добавление сотрудника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBox_LastName;
        private Label label2;
        private Label label3;
        private TextBox TextBox_FirstName;
        private Label label4;
        private TextBox TextBox_MiddleName;
        private Label label5;
        private TextBox TextBox_Role;
        private Label label6;
        private DateTimePicker DateTimePicker_Birthday;
        private Label label7;
        private TextBox TextBox_WorkHoursPerDay;
        private Label label8;
        private TextBox TextBox_WorkDaysPerWeek;
        private DateTimePicker DateTimePicker_RoleWorkStart;
        private Label label9;
        private Label label10;
        private TextBox TextBox_BaseSalaryPerHour;
        private Button Button_Add;
    }
}