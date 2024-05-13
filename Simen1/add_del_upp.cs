using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;

namespace Simen1
{
    public partial class add_del_upp : Form
    {
        YourDataVariables yourDataVariables;
        private ComboBox comboBox;
        private string? selectedItem;



        public add_del_upp()

        {
            InitializeComponent();

        }



        #region comboBox



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedItem = comboBox1.SelectedItem as string;


            switch (selectedItem)
            {
                case "Воздуховод":

                    textBox1.Enabled= false;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    break;
                case "Отвод":

                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;

                    break;
                case "Тройник":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    break;
            }
        }

        #endregion







        private void add_del_upp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }









        #region Основные вычисления
        public class YourDataVariables
        {
            // Наименование материала
            public string? Name { get; set; }

            // Площадь
            public double Area { get; set; }

            // Диаметр
            public double Diameter { get; set; }

            // Толщина стенки
            public double WallThickness { get; set; }

            // Толщина фланца
            public double FlangeThickness { get; set; }

            // Количество материала на 1 единицу, кг
            public double MaterialPerKg { get; set; } //++

            // Стоимость 1 единицы, руб. с НДС
            public int CostPerUnitWithVAT { get; set; } //++

            // Цена за 1 шт., руб. с НДС
            public int PricePerUnitWithVAT { get; set; } //++

            // Стоимость, руб. с НДС
            public int TotalCostWithVAT { get; set; } //++

            // Стоимость материала, руб. с НДС
            public int MaterialCost { get; set; } //++

            // Сумма без материала и НДС, руб
            public int TotalCostWithoutMaterialAndVAT { get; set; } //++ 

            // Планируемая прибыль, руб.
            public int PlannedProfit { get; set; }

            // Стоимость работ, руб.
            public int WorkCost { get; set; }

            // Количество человеко-часов
            public double ManHoursPerPerson { get; set; }

            // Масса листа, кг
            public double SheetMass { get; set; }

            // Количество листов/труб на 1 м
            public double QuantityPerMeter { get; set; }



        }

        const double constant1 = 0.09;
        const double constant2 = 920;
        const double constant3 = 1.2;
        const double constant4 = 320;
        const double constant5 = 1420;
        const double constant6 = 4.5;


        private YourDataVariables CreateYourDataVariablesInstance()
        {
            return new YourDataVariables
            {
                Name = selectedItem,
                Area = 0,
                Diameter = Convert.ToDouble(textBox2.Text),
                WallThickness = Convert.ToDouble(textBox3.Text),
                FlangeThickness = Convert.ToDouble(textBox4.Text),
            };
        }


        //Основная логика расчетов
        private void AssignValuesFromLabels(YourDataVariables yourDataVariables)
        {

            switch (yourDataVariables.Name)
            {
                case "Воздуховод":



                    double term1 = yourDataVariables.Diameter * yourDataVariables.WallThickness;
                    double term2 = Math.Pow((yourDataVariables.Diameter + constant1) / 2, 2) - Math.Pow(yourDataVariables.Diameter / 2, 2);
                    double term3 = yourDataVariables.FlangeThickness * term2;
                    double term4 = double.Parse(term3.ToString("F9")) * 2 * Math.PI * constant2 * constant3;

                    yourDataVariables.MaterialPerKg = Math.Round(((term1 + term4) * 10), 1);

                    //Проверка на диаметр // Стоимость 1 единицы, руб. с НДС
                    if (yourDataVariables.Diameter >= 0.21 && yourDataVariables.Diameter <= 0.4)
                    {
                        yourDataVariables.CostPerUnitWithVAT = (int)(yourDataVariables.MaterialPerKg * constant4 * 2.3);
                    }
                    else
                    {
                        yourDataVariables.CostPerUnitWithVAT = (int)(yourDataVariables.MaterialPerKg * constant4 * 2);
                    }

                    break;
                case "Отвод":
                    yourDataVariables.Area = Convert.ToDouble(textBox1.Text);
                    double temp1 = yourDataVariables.Area * yourDataVariables.WallThickness * constant2 * constant3;
                    double temp2 = Math.Pow((yourDataVariables.Diameter + constant1) / 2, 2) - Math.Pow(yourDataVariables.Diameter / 2, 2);
                    double temp3 = temp2 * yourDataVariables.FlangeThickness * 2 * Math.PI * constant2 * constant3;




                    yourDataVariables.MaterialPerKg = Math.Round((temp1 + temp3), 1);

                    //Проверка на диаметр // Стоимость 1 единицы, руб. с НДС


                    Dictionary<Tuple<double, double>, double> diameterRanges = new Dictionary<Tuple<double, double>, double>
                    {
                        { Tuple.Create(0.11, 0.24), 6.0 },
                        { Tuple.Create(0.25, 0.31), 5.0 },
                        { Tuple.Create(0.315, 0.39), 3.5 },
                        { Tuple.Create(0.4, 0.46), 3.0 },
                    };

                    double costPerUnitWithVATCoefficient = 2.0; // Значение по умолчанию

                    foreach (var range in diameterRanges)
                    {
                        var (min, max) = range.Key;

                        if (yourDataVariables.Diameter >= min && yourDataVariables.Diameter <= max)
                        {
                            costPerUnitWithVATCoefficient = range.Value;
                            break; // Выходим из цикла после первого соответствия
                        }
                    }

                    yourDataVariables.CostPerUnitWithVAT = (int)(constant4 * yourDataVariables.MaterialPerKg * costPerUnitWithVATCoefficient);
                    break;
                case "Тройник":
                    yourDataVariables.Area = Convert.ToDouble(textBox1.Text);

                    double tem1 = yourDataVariables.Area * yourDataVariables.WallThickness * constant2 * constant3;
                    double tem2 = Math.Pow((yourDataVariables.Diameter + constant1) / 2, 2) - Math.Pow(yourDataVariables.Diameter / 2, 2);
                    double tem3 = tem2 * yourDataVariables.FlangeThickness * 3 * Math.PI * constant2 * constant3;

                    yourDataVariables.MaterialPerKg = tem1 + tem3;


                    Dictionary<Tuple<double, double>, double> diameterRangesForTee = new Dictionary<Tuple<double, double>, double>
                    {
                        { Tuple.Create(0.11, 0.29), 4.5 },
                        { Tuple.Create(0.3, 0.46), 3.0 },
                        { Tuple.Create(0.47, 0.52), 2.5 },
                        // Добавьте другие диапазоны при необходимости
                    };

                    double costPerUnitWithVATCoefficientForTee = 2.0; // Значение по умолчанию


                    foreach (var range in diameterRangesForTee)
                    {
                        var (min, max) = range.Key;

                        if (yourDataVariables.Diameter >= min && yourDataVariables.Diameter <= max)
                        {
                            costPerUnitWithVATCoefficientForTee = range.Value;
                            break; // Выходим из цикла после первого соответствия
                        }
                    }

                    yourDataVariables.CostPerUnitWithVAT = (int)(constant4 * yourDataVariables.MaterialPerKg * costPerUnitWithVATCoefficientForTee);

                    break;
                default:
                    MessageBox.Show("Ошибка: Вы не выбрали наименование.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            // Стоимость 1 единицы, руб. с НДС


            //Цена, за 1 шт., руб. с НДС    
            yourDataVariables.PricePerUnitWithVAT = (int)(yourDataVariables.CostPerUnitWithVAT * 1);


            //Стоимость, руб. с НДС
            yourDataVariables.TotalCostWithVAT = (int)(yourDataVariables.CostPerUnitWithVAT * 1);

            //Стоимость материала, руб. с НДС
            yourDataVariables.MaterialCost = (int)(yourDataVariables.MaterialPerKg * constant4 * 1);//позже будет использовано для улучшения формулы

            //Сумма без материала и НДС, руб
            yourDataVariables.TotalCostWithoutMaterialAndVAT = (int)((yourDataVariables.CostPerUnitWithVAT - yourDataVariables.MaterialCost) * (5.0 / 6.0));


            //Планируемая прибыль, руб.
            yourDataVariables.PlannedProfit = (int)Math.Ceiling(yourDataVariables.CostPerUnitWithVAT * 0.1);


            // Стоимость работ, руб.
            yourDataVariables.WorkCost = yourDataVariables.TotalCostWithoutMaterialAndVAT - yourDataVariables.PlannedProfit;


            // Количество человеко-часов
            yourDataVariables.ManHoursPerPerson = Math.Round((yourDataVariables.WorkCost / constant5), 1);

            //Не понятная формула
            yourDataVariables.SheetMass = constant2 * yourDataVariables.WallThickness * constant6;


            yourDataVariables.QuantityPerMeter = 0;



            //
        }

        #endregion



        #region Интеграция в базу данных
        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем объект уведомления
            NotifyIcon notification = new NotifyIcon();
            notification.Icon = SystemIcons.Information;
            notification.Visible = true;

            // Устанавливаем текст уведомления
            notification.BalloonTipTitle = "Состояние данных";
            notification.BalloonTipText = "Данные добавлены в базу, пожалуйста добавьте еще или выйдите из формы";
            notification.BalloonTipIcon = ToolTipIcon.Info;

            // Показываем уведомление на несколько секунд
            notification.ShowBalloonTip(30);

            // Очищаем ресурсы после использования
            notification.Dispose();








            YourDataVariables yourDataVariables = CreateYourDataVariablesInstance();
            AssignValuesFromLabels(yourDataVariables);
            InsertDataIntoDatabase(yourDataVariables);
        }
        private void InsertDataIntoDatabase(YourDataVariables yourDataVariables)
        {
            string? connectionString = "Server=127.0.0.1;Port=3306;Database=hukodv;Uid=root;pwd=huko1432;charset=utf8;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string? query = "INSERT INTO YourTableName (Name, Area, Diameter, WallThickness, FlangeThickness, MaterialPerKg, CostPerUnitWithVAT, " +
                             "PricePerUnitWithVAT, TotalCostWithVAT, MaterialCost, TotalCostWithoutMaterialAndVAT, PlannedProfit, " +
                             "WorkCost, ManHoursPerPerson, SheetMass, QuantityPerMeter) " +
                             "VALUES (@Name, @Area, @Diameter, @WallThickness, @FlangeThickness, @MaterialPerKg, @CostPerUnitWithVAT, " +
                             "@PricePerUnitWithVAT, @TotalCostWithVAT, @MaterialCost, @TotalCostWithoutMaterialAndVAT, @PlannedProfit, " +
                             "@WorkCost, @ManHoursPerPerson, @SheetMass, @QuantityPerMeter)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", yourDataVariables.Name);
                    command.Parameters.AddWithValue("@Area", yourDataVariables.Area);
                    command.Parameters.AddWithValue("@Diameter", yourDataVariables.Diameter);
                    command.Parameters.AddWithValue("@WallThickness", yourDataVariables.WallThickness);
                    command.Parameters.AddWithValue("@FlangeThickness", yourDataVariables.FlangeThickness);
                    command.Parameters.AddWithValue("@MaterialPerKg", yourDataVariables.MaterialPerKg);
                    command.Parameters.AddWithValue("@CostPerUnitWithVAT", yourDataVariables.CostPerUnitWithVAT);
                    command.Parameters.AddWithValue("@PricePerUnitWithVAT", yourDataVariables.PricePerUnitWithVAT);
                    command.Parameters.AddWithValue("@TotalCostWithVAT", yourDataVariables.TotalCostWithVAT);
                    command.Parameters.AddWithValue("@MaterialCost", yourDataVariables.MaterialCost);
                    command.Parameters.AddWithValue("@TotalCostWithoutMaterialAndVAT", yourDataVariables.TotalCostWithoutMaterialAndVAT);
                    command.Parameters.AddWithValue("@PlannedProfit", yourDataVariables.PlannedProfit);
                    command.Parameters.AddWithValue("@WorkCost", yourDataVariables.WorkCost);
                    command.Parameters.AddWithValue("@ManHoursPerPerson", yourDataVariables.ManHoursPerPerson);
                    command.Parameters.AddWithValue("@SheetMass", yourDataVariables.SheetMass);
                    command.Parameters.AddWithValue("@QuantityPerMeter", yourDataVariables.QuantityPerMeter);

                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion




    }
}
