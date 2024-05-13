using MySqlConnector;
using OfficeOpenXml;
using System;
using System.Data;
using static Simen1.Settings;

namespace Simen1
{
    public partial class MainForm : Form
    {



        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void mainform_Load(object sender, EventArgs e)
        {

        }

        #region Загрузка информации из базы данных
        private void LoadData()
        {
            string connectString = "Server=127.0.0.1;Port=3306;Database=hukodv;Uid=root;pwd=huko1432;charset=utf8;";

            LoadDataForDataGridView("SELECT * FROM YourTableName WHERE Name = 'Воздуховод'", dataGridView1, connectString);
            LoadDataForDataGridView("SELECT * FROM YourTableName WHERE Name = 'Отвод'", dataGridView2, connectString);
            LoadDataForDataGridView("SELECT * FROM YourTableName WHERE Name = 'Тройник'", dataGridView3, connectString);
        }

        private void LoadDataForDataGridView(string query, DataGridView dataGridView, string connectString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                if (reader.HasRows)
                {
                    dataGridView.Columns.Clear();

                    // Добавляем столбцы с русскоязычными названиями
                    dataGridView.Columns.Add("Name", "Имя");
                    dataGridView.Columns.Add("Area", "Площадь");
                    dataGridView.Columns.Add("Diameter", "Диаметр");
                    dataGridView.Columns.Add("WallThickness", "Толщина стенки");
                    dataGridView.Columns.Add("FlangeThickness", "Толщина фланца");
                    dataGridView.Columns.Add("MaterialPerKg", "Материал за кг");
                    dataGridView.Columns.Add("CostPerUnitWithVAT", "Стоимость за единицу с НДС");
                    dataGridView.Columns.Add("PricePerUnitWithVAT", "Цена за единицу с НДС");
                    dataGridView.Columns.Add("TotalCostWithVAT", "Общая стоимость с НДС");
                    dataGridView.Columns.Add("MaterialCost", "Стоимость материала");
                    dataGridView.Columns.Add("TotalCostWithoutMaterialAndVAT", "Общая стоимость без материала и НДС");
                    dataGridView.Columns.Add("PlannedProfit", "Планируемая прибыль");
                    dataGridView.Columns.Add("WorkCost", "Стоимость работы");
                    dataGridView.Columns.Add("ManHoursPerPerson", "Человеко-часов на человека");
                    dataGridView.Columns.Add("SheetMass", "Масса листа");
                    dataGridView.Columns.Add("QuantityPerMeter", "Количество на метр");

                    while (reader.Read())
                    {
                        string[] rowData = new string[reader.FieldCount - 1];
                        for (int i = 1; i < reader.FieldCount; i++)
                        {
                            rowData[i - 1] = reader[i].ToString();
                        }
                        data.Add(rowData);
                    }
                }
                reader.Close();

                foreach (string[] s in data)
                    dataGridView.Rows.Add(s);
            }
        }
        #endregion

        #region grid4
        private void dataGridView4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            // Проверяем, что изменение произошло в столбце "Количество" и что строка была выбрана
            if (e.ColumnIndex == dataGridView4.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                // Получаем текущее значение количества из ячейки
                string? quantityString = dataGridView4.Rows[e.RowIndex].Cells["Quantity"].Value?.ToString();

                // Парсим значение количества в число
                if (int.TryParse(quantityString, out int quantity))
                {
                    // Получаем цену за единицу из ячейки
                    string? pricePerUnitString = dataGridView4.Rows[e.RowIndex].Cells["PricePerUnitWithVAT"].Value?.ToString();

                    // Парсим значение цены за единицу в число
                    if (decimal.TryParse(pricePerUnitString, out decimal pricePerUnit))
                    {
                        // Вычисляем новое значение общей стоимости
                        decimal TotalCostWithVAT = quantity * pricePerUnit;

                        // Обновляем значение общей стоимости в соответствующей ячейке
                        dataGridView4.Rows[e.RowIndex].Cells["TotalCostWithVAT"].Value = TotalCostWithVAT.ToString();
                    }
                }

                // После изменения данных в DataGridView, вызываем метод UpdateTotalRow для обновления строки "Итого"
                RemoveTotalRow(dataGridView4);
                UpdateTotalRow(dataGridView4);


            }
        }





        private void RemoveTotalRow(DataGridView dataGridView)
        {
            // Проверяем, что есть хотя бы одна строка в dataGridView
            if (dataGridView.Rows.Count > 0)
            {
                // Перебираем строки dataGridView с конца до начала
                for (int i = dataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dataGridView.Rows[i];
                    // Проверяем, является ли текущая строка строкой "Итого"
                    if (row.Cells[0].Value?.ToString() == "Итого")
                    {
                        // Удаляем строку "Итого"
                        dataGridView.Rows.RemoveAt(i);
                        // Прерываем цикл, так как "Итого" удалена
                        break;
                    }
                }
            }
        }

        private void UpdateTotalRow(DataGridView dataGridView)
        {
            decimal totalCost = 0;
            int totalQuantity = 0;

            // Пересчитываем общую стоимость и количество
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0].Value?.ToString() != "Итого") // Пропускаем строку "Итого"
                {
                    int quantity;
                    decimal cost;
                    if (int.TryParse(row.Cells["Quantity"].Value?.ToString(), out quantity))
                    {
                        totalQuantity += quantity;
                    }
                    if (decimal.TryParse(row.Cells["TotalCostWithVAT"].Value?.ToString(), out cost))
                    {
                        totalCost += cost;
                    }
                }
            }

            // Создаем новую строку "Итого" с актуальными значениями
            DataGridViewRow totalRow = new DataGridViewRow();
            totalRow.CreateCells(dataGridView);
            totalRow.Cells[0].Value = "Итого";
            totalRow.Cells[1].Value = totalQuantity.ToString(); // Количество
            totalRow.Cells[3].Value = totalCost.ToString(); // Общая стоимость

            totalRow.DefaultCellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold); // Жирный шрифт
            totalRow.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#ff5964");
            totalRow.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ffe74c"); // Цвет фона



            // Добавляем строку "Итого" в dataGridView
            dataGridView.Rows.Add(totalRow);
        }


        public static void CloneSelectedRows(DataGridView source, DataGridView destination)
        {

            if (destination.Columns.Count == 0)
            {
                destination.Columns.Add("Name", "Имя");
                destination.Columns.Add("Quantity", "Количество");
                destination.Columns.Add("PricePerUnitWithVAT", "Цена за единицу с НДС");
                destination.Columns.Add("TotalCostWithVAT", "Общая стоимость с НДС");
            }

            if (source.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in source.SelectedRows)
                {
                    // Получаем значения определенных столбцов (например, Имя, Цена за единицу и Общая стоимость)
                    string? type = selectedRow.Cells["Name"].Value?.ToString();
                    int diameter = Convert.ToInt32(selectedRow.Cells["Diameter"].Value);
                    int wallThickness = Convert.ToInt32(selectedRow.Cells["WallThickness"].Value);


                    string name;


                    if (type == "Тройник")
                    {
                        name = $"{type} ПП Ø{diameter}-Ф";
                    }
                    else if (type == "Отвод")
                    {
                        name = $"{type} 90° ПП Ø{diameter}-Ф";
                    }
                    else
                    {
                        name = $"{type} ПП Ø{diameter}×{wallThickness}-Ф";
                    }

                    string? quantity = "1";
                    string? pricePerUnit = selectedRow.Cells["PricePerUnitWithVAT"].Value?.ToString();
                    string? totalCost = selectedRow.Cells["TotalCostWithVAT"].Value?.ToString();

                    // Добавляем скопированные данные в dataGridView4
                    destination.Rows.Add(name, quantity, pricePerUnit, totalCost);
                    destination.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

            }
            else
            {
                MessageBox.Show("Выберите хотя бы одну строку для добавления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region btn
        private void CommonButtonClickHandler(object sender, EventArgs e)
        {
            Form ss = new add_del_upp();
            ss.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            RemoveTotalRow(dataGridView4);
            CloneSelectedRows(dataGridView1, dataGridView4);
            UpdateTotalRow(dataGridView4);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            RemoveTotalRow(dataGridView4);
            CloneSelectedRows(dataGridView2, dataGridView4);
            UpdateTotalRow(dataGridView4);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            RemoveTotalRow(dataGridView4);
            CloneSelectedRows(dataGridView3, dataGridView4);
            UpdateTotalRow(dataGridView4);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridView4);
        }

        private void ExportToExcel(DataGridView dataGridView)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            sfd.FileName = "export.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage pck = new ExcelPackage())
                    {
                        ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Sheet1");

                        // заголовки столбцов
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            ws.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                        }

                        // данные
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView.Columns.Count; j++)
                            {
                                ws.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;
                            }
                        }

                        FileInfo fi = new(sfd.FileName);
                        pck.SaveAs(fi);
                    }
                    ShowNotification("Успешный экспорт", "Выбранные данные успешно экспортированны в файл по выбранному пути");
                }
                catch (Exception ex)
                {
                    // Выводим сообщение об ошибке в диалоговом окне
                    MessageBox.Show("Ошибка при экспорте данных в Excel: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Добавляем вывод сообщения об ошибке в консоль
                    Console.WriteLine("Ошибка при экспорте данных в Excel: " + ex.Message);

                    // Добавляем запись сообщения об ошибке в лог-файл
                    string logFilePath = "error.log";
                    using (StreamWriter writer = new StreamWriter(logFilePath, true))
                    {
                        writer.WriteLine(DateTime.Now.ToString() + " : " + ex.Message);
                        writer.WriteLine("Stack Trace: " + ex.StackTrace);
                        writer.WriteLine("--------------------------------------------------");
                    }
                }
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

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли выбранная строка
            if (dataGridView4.SelectedRows.Count > 0)
            {
                // Удаляем выбранную строку
                dataGridView4.Rows.RemoveAt(dataGridView4.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
 
