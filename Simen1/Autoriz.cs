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

        private void �����������_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

            try
            {
                var splasher = new Splasher("��� �������", "v1.0.0");
                splasher.Show();
                Thread.Sleep(3000);
                splasher.Close();
                this.Activate();

                // ������� ��������� Settings
                settingsForm = new Settings();

                // �������� ������ ����������� �� ������� ��������
                string connectionString = "Server=localhost;Port=3306;Database=hukodv;Uid=root;pwd=huko1432;charset=utf8;";

                try
                {
                    // �������� ������� ���������� � ����� ������
                    conn.ConnectionString = connectionString;
                    conn.Open();
                }
                catch (Exception ex)
                {
                    // � ������ ������ ����������� � ���� ������, ���������� �����������
                    ShowNotification("������ �����������", ex.Message);
                }
            }
            catch (Exception ex)
            {
                // � ������ ������ ����������� � ���� ������, ���������� �����������
                ShowNotification("������ �����������", ex.Message);
            }
        }






        private static void ShowNotification(string title, string message)
        {
            // ������� ������ �����������
            NotifyIcon notification = new()
            {
                Icon = SystemIcons.Error,
                Visible = true,

                // ������������� ����� �����������
                BalloonTipTitle = title,
                BalloonTipText = message,
                BalloonTipIcon = ToolTipIcon.Error
            };

            // ���������� ����������� �� ��������� ������
            notification.ShowBalloonTip(30);

            // ������� ������� ����� �������������
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
                                // �������� ��� ������������ � ��� ���� �� ���� ������
                                string name = reader["name"].ToString();
                                string role = reader["role"].ToString();

                                // ������� ������ ������������ � ������ � �����
                                return new User { Name = name, Role = role };
                            }
                        }
                    }   
                }
            }
            catch (Exception ex)
            {
                // ��������� ������ ��������������, ���� ����������
                Console.WriteLine("������ ��� ��������������: " + ex.Message);
            }
            // ���� ������������ �� ������ ��� ��������� ������, ���������� null
            return null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            try
            {
                // ��������� ����������� ���� ������
                if (CheckDatabaseConnection())
                {
                    // �������� ����������������� ������������
                    User user = AuthenticateUser(username, password, settingsForm);

                    if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                    {

                            // ���� ������������ �������������, ��������� ������� ����� � ����� "admin"
                            MainForm mainform = new();
                            mainform.Show();
                            this.Hide();

                        
                    }
                    else
                    {
                        MessageBox.Show("������������ ��� ������������ ��� ������.", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ShowNotification("������ �����������", "��� ������� � ���� ������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
