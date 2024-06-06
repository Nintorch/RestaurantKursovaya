namespace PasswordHasher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_CopyHash_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(App.PasswordHasher.Hash(TextBox_Password.Text));
            MessageBox.Show("Хеш пароля был скопирован в буфер обмена.");
        }
    }
}
