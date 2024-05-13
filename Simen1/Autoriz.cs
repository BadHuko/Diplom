using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using MySqlConnector;
using SplashScreen.WindowsForms;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;



namespace Simen1
{
    public partial class Autoriz : Form
    {

        private Settings settingsForm;
        MySqlConnection conn = new MySqlConnection();

        public Autoriz()
        {
            InitializeComponent();
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

            try
            {
                var splasher = new Splasher("НПО Процесс", "v1.0.0");
                splasher.Show();
                Thread.Sleep(3000);
                splasher.Close();
                this.Activate();

                // Создаем экземпляр Settings
                settingsForm = new Settings();

                // Получаем строку подключения из объекта настроек
                string connectionString = "Server=localhost;Port=3306;Database=hukodv;Uid=root;pwd=huko1432;charset=utf8;";

                try
                {
                    // Пытаемся открыть соединение с базой данных
                    conn.ConnectionString = connectionString;
                    conn.Open();
                }
                catch (Exception ex)
                {
                    // В случае ошибки подключения к базе данных, отображаем уведомление
                    ShowNotification("Ошибка подключения", ex.Message);
                }
            }
            catch (Exception ex)
            {
                // В случае ошибки подключения к базе данных, отображаем уведомление
                ShowNotification("Ошибка подключения", ex.Message);
            }
        }






        private static void ShowNotification(string title, string message)
        {
            // Создаем объект уведомления
            NotifyIcon notification = new()
            {
                Icon = SystemIcons.Error,
                Visible = true,

                // Устанавливаем текст уведомления
                BalloonTipTitle = title,
                BalloonTipText = message,
                BalloonTipIcon = ToolTipIcon.Error
            };

            // Показываем уведомление на несколько секунд
            notification.ShowBalloonTip(30);

            // Очищаем ресурсы после использования
            notification.Dispose();
        }

        public class User
        {
            public required string Name { get; set; }
            public required string Role { get; set; }
        }

        private static bool CheckDatabaseConnection()
        {
            string connectionString = "Server=localhost;Port=3306;Database=hukodv;Uid=root;pwd=huko1432;charset=utf8;";

            try
            {
                using MySqlConnection connection = new(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }




        private static User? AuthenticateUser(string username, string password, Settings settingsForm)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=hukodv;Uid=root;pwd=huko1432;charset=utf8;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT name, role FROM user WHERE name = @name AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Получаем имя пользователя и его роль из базы данных
                                string name = reader["name"].ToString();
                                string role = reader["role"].ToString();

                                // Создаем объект пользователя с именем и ролью
                                return new User { Name = name, Role = role };
                            }
                        }
                    }   
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок аутентификации, если необходимо
                Console.WriteLine("Ошибка при аутентификации: " + ex.Message);
            }
            // Если пользователь не найден или произошла ошибка, возвращаем null
            return null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            try
            {
                // Проверяем доступность базы данных
                if (CheckDatabaseConnection())
                {
                    // Пытаемся аутентифицировать пользователя
                    User user = AuthenticateUser(username, password, settingsForm);

                    if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                    {

                            // Если пользователь администратор, открываем главную форму с ролью "admin"
                            MainForm mainform = new();
                            mainform.Show();
                            this.Hide();

                        
                    }
                    else
                    {
                        MessageBox.Show("Неправильное имя пользователя или пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ShowNotification("Ошибка подключения", "Нет доступа к базе данных");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
