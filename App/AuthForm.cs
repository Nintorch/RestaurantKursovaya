using App.Data;

namespace App
{
    public partial class AuthForm : Form
    {
        RestaurantContext context = new();

        public AuthForm()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            string login = TextBox_Login.Text;
            string password = TextBox_Password.Text;
            Administator? admin = context.Administrators.FirstOrDefault(a => a.Login == login);
            if (admin == null || !PasswordHasher.Verify(password, admin.Passwordhash))
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }

            // Авторизация прошла успешно
            // Создаем экземпляр формы "Основное меню"
            // и показываем ее
            Hide();
            MainMenuForm form = new();
            form.Show();
            form.FormClosed += (s, args) => Close();
        }
    }
}
