namespace App
{
    partial class AuthForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBox_Login = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TextBox_Password = new TextBox();
            Button_Login = new Button();
            SuspendLayout();
            // 
            // TextBox_Login
            // 
            TextBox_Login.Location = new Point(128, 135);
            TextBox_Login.Name = "TextBox_Login";
            TextBox_Login.Size = new Size(250, 27);
            TextBox_Login.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(144, 31);
            label1.Name = "label1";
            label1.Size = new Size(234, 28);
            label1.TabIndex = 1;
            label1.Text = "Сотрудники ресторана";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 76);
            label2.Name = "label2";
            label2.Size = new Size(255, 20);
            label2.TabIndex = 2;
            label2.Text = "Войдите в аккаунт администратора";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 112);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 3;
            label3.Text = "Логин:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 165);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 4;
            label4.Text = "Пароль:";
            // 
            // TextBox_Password
            // 
            TextBox_Password.Location = new Point(128, 188);
            TextBox_Password.Name = "TextBox_Password";
            TextBox_Password.PasswordChar = '*';
            TextBox_Password.Size = new Size(250, 27);
            TextBox_Password.TabIndex = 5;
            // 
            // Button_Login
            // 
            Button_Login.Location = new Point(198, 230);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new Size(94, 29);
            Button_Login.TabIndex = 6;
            Button_Login.Text = "Войти";
            Button_Login.UseVisualStyleBackColor = true;
            Button_Login.Click += Button_Login_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 285);
            Controls.Add(Button_Login);
            Controls.Add(TextBox_Password);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextBox_Login);
            Name = "AuthForm";
            Text = "Сотрудники ресторана - Форма входа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox_Login;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TextBox_Password;
        private Button Button_Login;
    }
}
