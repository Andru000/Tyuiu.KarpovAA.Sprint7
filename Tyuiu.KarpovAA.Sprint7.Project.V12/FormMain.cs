using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KarpovAA.Sprint7.Project.V12.Lib;
using System.IO;

namespace Tyuiu.KarpovAA.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {


        public FormMain()
        {
            InitializeComponent();          
            dateTimePickerRelease_KAA.CustomFormat = "DD MM YYYY";
        }

        DataService ds = new DataService();
        
        string pathPC = @"C:..\IVM.csv";
        string pathSeller = @"..\Distributors.csv";


        


        private void buttonFindDistributors_KAA_Click(object sender, EventArgs e)
        {
            var data = ds.GetData(pathSeller);
            var searchText = textBoxFind_KAA.Text.ToLower();
            if (string.IsNullOrEmpty(searchText)) return;
            var filteredData = new List<string[]>();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0].ToLower().Contains(searchText) || data[i, 1].ToLower().Contains(searchText))
                {
                    var row = new string[data.GetLength(1)];
                    for (int j = 0; j < row.Length; j++)
                    {
                        row[j] = data[i, j];
                    }
                    filteredData.Add(row);
                }
            }

            var filteredDataArray = filteredData.ToArray();
            dataGridViewDistributors_KAA.RowCount = filteredDataArray.Length;
            dataGridViewDistributors_KAA.ColumnCount = filteredDataArray.Length == 0 ? 0 : filteredDataArray[0].Length;

            for (int r = 0; r < filteredDataArray.Length; r++)
            {
                for (int c = 0; c < filteredDataArray[0].Length; c++)
                {
                    dataGridViewDistributors_KAA.Rows[r].Cells[c].Value = filteredDataArray[r][c];
                }
            }
        }
        private void buttonFind_KAA_Click(object sender, EventArgs e)
        {
            var data = ds.GetData(pathPC);
            var searchText = textBoxFind_KAA.Text.ToLower();
            if (string.IsNullOrEmpty(searchText)) return;
            var filteredData = new List<string[]>();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0].ToLower().Contains(searchText) || data[i, 1].ToLower().Contains(searchText))
                {
                    var row = new string[data.GetLength(1)];
                    for (int j = 0; j < row.Length; j++)
                    {
                        row[j] = data[i, j];
                    }
                    filteredData.Add(row);
                }
            }

            var filteredDataArray = filteredData.ToArray();
            dataGridViewIVM_KAA.RowCount = filteredDataArray.Length;
            dataGridViewIVM_KAA.ColumnCount = filteredDataArray.Length == 0 ? 0 : filteredDataArray[0].Length;

            for (int r = 0; r < filteredDataArray.Length; r++)
            {
                for (int c = 0; c < filteredDataArray[0].Length; c++)
                {
                    dataGridViewIVM_KAA.Rows[r].Cells[c].Value = filteredDataArray[r][c];
                }
            }
        }

        private void buttonAddDistributor_KAA_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxURL_KAA.Text == "" || textBoxPhoneNumber_KAA.Text == "" || textBoxSeller_KAA.Text == "" || textBoxAddress_KAA.Text == "")
                {
                    MessageBox.Show("Введите все данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] row = new string[] { $"{textBoxSeller_KAA.Text}", $"{textBoxAddress_KAA.Text}",
                    $"{textBoxPhoneNumber_KAA.Text}", $"{textBoxURL_KAA.Text}" };
                    dataGridViewDistributors_KAA.Rows.Add(row);
                    bool completed = ds.AddNewData(pathSeller, row);
                    if (completed)
                    {
                        MessageBox.Show("Данные добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    textBoxSeller_KAA.Clear();
                    textBoxAddress_KAA.Clear();
                    textBoxPhoneNumber_KAA.Clear();
                    textBoxURL_KAA.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStats_KAA_Click(object sender, EventArgs e)
        {
            FormStats statistic = new FormStats();
            statistic.Show();
        }

        private void buttonDistributors_KAA_Click(object sender, EventArgs e)
        {

            dataGridViewIVM_KAA.Visible = false;
            dataGridViewDistributors_KAA.Visible = true;
            labelSearch_KAA.Visible = true;
            textBoxFind_KAA.Visible = true;
            buttonFind_KAA.Visible = false;
            buttonFindDistributors_KAA.Visible = true;
            textBoxDistributor_KAA.Visible = false;
            textBoxSpeed_KAA.Visible = false;
            textBoxROM_KAA.Visible = false;
            textBoxCPU_KAA.Visible = false;
            textBoxPrice_KAA.Visible = false;
            numericUpDownCore_KAA.Visible = false;
            numericUpDownRAM_KAA.Visible = false;
            dateTimePickerRelease_KAA.Visible = false;
            buttonAddIVM_KAA.Visible = false;
            buttonSaveIVM_KAA.Visible = false;
            buttonStats_KAA.Visible = false;
            labelSpeed_KAA.Visible = false;
            labelCore_KAA.Visible = false;
            labelROM_KAA.Visible = false;
            labelRAM_KAA.Visible = false;
            labelDistributor_KAA.Visible = false;
            labelPrice_KAA.Visible = false;
            labelCPU_KAA.Visible = false;
            labelRelease_KAA.Visible = false;
            dataGridViewDistributors_KAA.Visible = true;
            textBoxSeller_KAA.Visible = true;
            textBoxPhoneNumber_KAA.Visible = true;
            textBoxURL_KAA.Visible = true;
            textBoxAddress_KAA.Visible = true;
            buttonAddDistributor_KAA.Visible = true;
            buttonSaveDistributors_KAA.Visible = true;
            labelAddress_KAA.Visible = true;
            labelNameSeller_KAA.Visible = true;
            labelPhoneNumber_KAA.Visible = true;
            labelURL_KAA.Visible = true;
            textBoxTitle_KAA.Text = "Фирмы-реализаторы";

            try
            {

                string[,] DataMatrix = ds.GetData(pathSeller);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewDistributors_KAA.RowCount = rows;
                dataGridViewDistributors_KAA.ColumnCount = columns;

                dataGridViewDistributors_KAA.Columns[0].HeaderText = "Наименование";
                dataGridViewDistributors_KAA.Columns[1].HeaderText = "Адрес";
                dataGridViewDistributors_KAA.Columns[2].HeaderText = "Номер телефона";
                dataGridViewDistributors_KAA.Columns[3].HeaderText = "Ссылка на сайт";

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewDistributors_KAA.Columns[i].Width = 150;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewDistributors_KAA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBoxFind_KAA_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxFind_KAA.Text.ToLower(); 

            foreach (DataGridViewRow row in dataGridViewIVM_KAA.Rows)
            {
                if (row.IsNewRow) continue; 

                bool found = false;

                for (int j = 0; j < dataGridViewIVM_KAA.Columns.Count; j++)
                {
                    if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().ToLower().Contains(searchValue))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found; 
            }
        }

        private void buttonDone_KAA_Click(object sender, EventArgs e)
        {
            
            dataGridViewIVM_KAA.Visible = true;
            dataGridViewDistributors_KAA.Visible = false;
            labelSearch_KAA.Visible = true;
            textBoxFind_KAA.Visible = true;
            buttonFind_KAA.Visible = true;
            buttonFindDistributors_KAA.Visible = false;
            textBoxDistributor_KAA.Visible = true;
            textBoxSpeed_KAA.Visible = true;
            textBoxROM_KAA.Visible = true;
            textBoxCPU_KAA.Visible = true;
            textBoxPrice_KAA.Visible = true;
            numericUpDownCore_KAA.Visible = true;
            numericUpDownRAM_KAA.Visible = true;
            dateTimePickerRelease_KAA.Visible = true;
            buttonAddIVM_KAA.Visible = true;
            buttonSaveIVM_KAA.Visible = true;
            buttonStats_KAA.Visible = true;
            labelROM_KAA.Visible = true;
            labelCore_KAA.Visible = true;
            labelSpeed_KAA.Visible = true;
            labelRAM_KAA.Visible = true;
            labelDistributor_KAA.Visible = true;
            labelPrice_KAA.Visible = true;
            labelCPU_KAA.Visible = true;
            labelRelease_KAA.Visible = true;
            dataGridViewDistributors_KAA.Visible = false;
            textBoxSeller_KAA.Visible = false;
            textBoxPhoneNumber_KAA.Visible = false;
            textBoxURL_KAA.Visible = false;
            textBoxAddress_KAA.Visible = false;
            buttonAddDistributor_KAA.Visible = false;
            buttonSaveDistributors_KAA.Visible = false;
            labelAddress_KAA.Visible = false;
            labelNameSeller_KAA.Visible = false;
            labelPhoneNumber_KAA.Visible = false;
            labelURL_KAA.Visible = false;
            textBoxTitle_KAA.Text = "Электронно-вычислительные машины";

            try
            {

                string[,] DataMatrix = ds.GetData(pathPC);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewIVM_KAA.RowCount = rows;
                dataGridViewIVM_KAA.ColumnCount = columns;

                dataGridViewIVM_KAA.Columns[0].HeaderText = "Производитель";
                dataGridViewIVM_KAA.Columns[1].HeaderText = "Тип процессора";
                dataGridViewIVM_KAA.Columns[2].HeaderText = "Кол-во ядер";
                dataGridViewIVM_KAA.Columns[3].HeaderText = "Тактовая частота";
                dataGridViewIVM_KAA.Columns[4].HeaderText = "Объем ОЗУ";
                dataGridViewIVM_KAA.Columns[5].HeaderText = "Объем ЖД";
                dataGridViewIVM_KAA.Columns[6].HeaderText = "Дата выпуска";
                dataGridViewIVM_KAA.Columns[7].HeaderText = "Цена";

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewIVM_KAA.Columns[i].Width = 150;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewIVM_KAA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonSaveDistributors_KAA_Click(object sender, EventArgs e)
        {
            string[,] data = new string[dataGridViewDistributors_KAA.RowCount, dataGridViewDistributors_KAA.ColumnCount];
            for (int i = 0; i < dataGridViewDistributors_KAA.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewDistributors_KAA.ColumnCount; j++)
                {
                    data[i, j] = dataGridViewDistributors_KAA.Rows[i].Cells[j].Value.ToString();
                }
            }
            bool completed = ds.UpdateData(pathSeller, data);

            if (completed)
            {
                MessageBox.Show("Данные обновлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAddIVM_KAA_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDistributor_KAA.Text == "" || textBoxCPU_KAA.Text == "" || numericUpDownCore_KAA.Text == "" ||
                    textBoxSpeed_KAA.Text == "" || numericUpDownRAM_KAA.Text == "" || textBoxROM_KAA.Text == "" ||
                    dateTimePickerRelease_KAA.Text == "" || textBoxPrice_KAA.Text == "")
                {
                    MessageBox.Show("Введите все данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] row = new string[] { $"{textBoxDistributor_KAA.Text}", $"{textBoxCPU_KAA.Text}",
                    $"{numericUpDownCore_KAA.Text}", $"{textBoxSpeed_KAA.Text}",
                    $"{numericUpDownRAM_KAA.Text}", $"{textBoxROM_KAA.Text}",
                    $"{dateTimePickerRelease_KAA.Text}", $"{textBoxPrice_KAA.Text}" };
                    dataGridViewIVM_KAA.Rows.Add(row);
                    bool completed = ds.AddNewData(pathPC, row);
                    if (completed)
                    {
                        MessageBox.Show("Данные добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    textBoxDistributor_KAA.Clear();
                    textBoxCPU_KAA.Clear();
                    numericUpDownCore_KAA.Text = "0";
                    textBoxSpeed_KAA.Clear();
                    numericUpDownRAM_KAA.Text = "0";
                    textBoxROM_KAA.Clear();
                    dateTimePickerRelease_KAA.Text = $"{DateTime.Now}";
                    textBoxPrice_KAA.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveIVM_KAA_Click(object sender, EventArgs e)
        {
            string[,] data = new string[dataGridViewIVM_KAA.RowCount, dataGridViewIVM_KAA.ColumnCount];
            for (int i = 0; i < dataGridViewIVM_KAA.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewIVM_KAA.ColumnCount; j++)
                {
                    data[i, j] = dataGridViewIVM_KAA.Rows[i].Cells[j].Value.ToString();
                }
            }
            bool completed = ds.UpdateData(pathPC, data);

            if (completed)
            {
                MessageBox.Show("Данные обновлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonInfo_KAA_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
        private void buttonHelp_KAA_Click(object sender, EventArgs e)
        {
            FormHelp info = new FormHelp();
            info.ShowDialog();
        }
    }
}
