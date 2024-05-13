using Newtonsoft.Json;

namespace Simen1
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            settings = new AppSettings();
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }
        public class AppSettings
        {
            public string LocateDB { get; set; }
            public string Port { get; set; }
            public string Password { get; set; }
            public string DataBase { get; set; }
        }



        public const string SettingsFilePath = "appsettings.json";
        private AppSettings settings;


        private void LoadSettings()
        {
            if (File.Exists(SettingsFilePath))
            {
                string json = File.ReadAllText(SettingsFilePath);
                settings = JsonConvert.DeserializeObject<AppSettings>(json);
                UpdateUIFromSettings();
            }
            else
            {
                settings = new AppSettings();
            }
        }

        private void SaveSettings()
        {
            string json = JsonConvert.SerializeObject(settings);
            File.WriteAllText(SettingsFilePath, json);
        }

        private void UpdateUIFromSettings()
        {
            tbDataBase.Text = settings.DataBase;
            tbPassword.Text = settings.Password;
            tbPort.Text = settings.Port;
            tbLocateDB.Text = settings.LocateDB;
        }

        private void UpdateSettingsFromUI()
        {
            settings.DataBase = tbDataBase.Text;
            settings.Password = tbPassword.Text;
            settings.Port = tbPort.Text;
            settings.LocateDB = tbLocateDB.Text;
        }


        public string GetConnectionString()
        {
            // Формируем строку подключения на основе настроек
            string connectionString = $"Server={settings.LocateDB};Port={settings.Port};Database={settings.DataBase};Uid=root;Pwd={settings.Password};charset=utf8;";
            return connectionString;
        }


        private void btSaveSettings_Click(object sender, EventArgs e)
        {
            UpdateSettingsFromUI();
            SaveSettings();
            this.Hide();
        }
    }
}
