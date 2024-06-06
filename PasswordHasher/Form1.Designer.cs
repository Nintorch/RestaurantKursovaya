namespace PasswordHasher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            TextBox_Password = new TextBox();
            label3 = new Label();
            Button_CopyHash = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(272, 32);
            label1.TabIndex = 0;
            label1.Text = "Хеширование пароля";
            // 
            // label2
            // 
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(444, 105);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // TextBox_Password
            // 
            TextBox_Password.Location = new Point(87, 183);
            TextBox_Password.Name = "TextBox_Password";
            TextBox_Password.PasswordChar = '*';
            TextBox_Password.Size = new Size(250, 27);
            TextBox_Password.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 160);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Пароль:";
            // 
            // Button_CopyHash
            // 
            Button_CopyHash.Location = new Point(134, 216);
            Button_CopyHash.Name = "Button_CopyHash";
            Button_CopyHash.Size = new Size(150, 29);
            Button_CopyHash.TabIndex = 4;
            Button_CopyHash.Text = "Скопировать хеш";
            Button_CopyHash.UseVisualStyleBackColor = true;
            Button_CopyHash.Click += Button_CopyHash_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 274);
            Controls.Add(Button_CopyHash);
            Controls.Add(label3);
            Controls.Add(TextBox_Password);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Хеширование пароля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextBox_Password;
        private Label label3;
        private Button Button_CopyHash;
    }
}
