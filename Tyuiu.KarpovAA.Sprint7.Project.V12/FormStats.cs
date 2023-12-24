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
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();
            var ds = new DataService();
            var priceColumnIndex = 7;
            var pathPC = @"..\IVM.csv";
            var data = ds.GetData(pathPC);
            var prices = new double[data.GetLength(0)];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                var priceString = data[i, priceColumnIndex].Replace('.', ',');
                var parseSuccess = double.TryParse(priceString, out double price);
                if (!parseSuccess)
                {
                    MessageBox.Show("Цена имеет неверный формат");
                    return;
                }

                prices[i] = price;
            }

            this.textBoxMinPrice_KAA.Text = prices.Min().ToString();
            this.textBoxMaxPrice_KAA.Text = prices.Max().ToString();
            this.textBoxAvgPrice_KAA.Text = prices.Average().ToString();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                this.chartColumnar_KAA.Series[0].Points.AddXY(data[i, 0], data[i, 7]);
                this.chartCircle_KAA.Series[0].Points.AddXY(data[i, 0], data[i, 7]);
            }
        }

        private void buttonOK_KAA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
