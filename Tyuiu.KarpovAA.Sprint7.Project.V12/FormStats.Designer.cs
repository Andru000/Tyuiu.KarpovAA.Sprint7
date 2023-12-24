
namespace Tyuiu.KarpovAA.Sprint7.Project.V12
{
    partial class FormStats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_KAA = new System.Windows.Forms.Panel();
            this.buttonOK_KAA = new System.Windows.Forms.Button();
            this.tabControlGraph_KAA = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartCircle_KAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartColumnar_KAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelAvgPrice_KAA = new System.Windows.Forms.Label();
            this.labelMaxPrice_KAA = new System.Windows.Forms.Label();
            this.labelMin__KAA = new System.Windows.Forms.Label();
            this.textBoxAvgPrice_KAA = new System.Windows.Forms.TextBox();
            this.textBoxMaxPrice_KAA = new System.Windows.Forms.TextBox();
            this.textBoxMinPrice_KAA = new System.Windows.Forms.TextBox();
            this.panel_KAA.SuspendLayout();
            this.tabControlGraph_KAA.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCircle_KAA)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumnar_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_KAA
            // 
            this.panel_KAA.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel_KAA.Controls.Add(this.buttonOK_KAA);
            this.panel_KAA.Controls.Add(this.tabControlGraph_KAA);
            this.panel_KAA.Controls.Add(this.labelAvgPrice_KAA);
            this.panel_KAA.Controls.Add(this.labelMaxPrice_KAA);
            this.panel_KAA.Controls.Add(this.labelMin__KAA);
            this.panel_KAA.Controls.Add(this.textBoxAvgPrice_KAA);
            this.panel_KAA.Controls.Add(this.textBoxMaxPrice_KAA);
            this.panel_KAA.Controls.Add(this.textBoxMinPrice_KAA);
            this.panel_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_KAA.Location = new System.Drawing.Point(0, 0);
            this.panel_KAA.Name = "panel_KAA";
            this.panel_KAA.Size = new System.Drawing.Size(800, 450);
            this.panel_KAA.TabIndex = 0;
            // 
            // buttonOK_KAA
            // 
            this.buttonOK_KAA.BackColor = System.Drawing.Color.Pink;
            this.buttonOK_KAA.Location = new System.Drawing.Point(694, 392);
            this.buttonOK_KAA.Name = "buttonOK_KAA";
            this.buttonOK_KAA.Size = new System.Drawing.Size(87, 47);
            this.buttonOK_KAA.TabIndex = 9;
            this.buttonOK_KAA.Text = "OK";
            this.buttonOK_KAA.UseVisualStyleBackColor = false;
            this.buttonOK_KAA.Click += new System.EventHandler(this.buttonOK_KAA_Click);
            // 
            // tabControlGraph_KAA
            // 
            this.tabControlGraph_KAA.Controls.Add(this.tabPage1);
            this.tabControlGraph_KAA.Controls.Add(this.tabPage2);
            this.tabControlGraph_KAA.Location = new System.Drawing.Point(12, 12);
            this.tabControlGraph_KAA.Name = "tabControlGraph_KAA";
            this.tabControlGraph_KAA.SelectedIndex = 0;
            this.tabControlGraph_KAA.Size = new System.Drawing.Size(776, 364);
            this.tabControlGraph_KAA.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartCircle_KAA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Круговая";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartCircle_KAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCircle_KAA.ChartAreas.Add(chartArea1);
            this.chartCircle_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartCircle_KAA.Legends.Add(legend1);
            this.chartCircle_KAA.Location = new System.Drawing.Point(3, 3);
            this.chartCircle_KAA.Name = "chartCircle_KAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCircle_KAA.Series.Add(series1);
            this.chartCircle_KAA.Size = new System.Drawing.Size(762, 332);
            this.chartCircle_KAA.TabIndex = 7;
            this.chartCircle_KAA.Text = "Круговая";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartColumnar_KAA);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Столбчатая";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartColumnar_KAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartColumnar_KAA.ChartAreas.Add(chartArea2);
            this.chartColumnar_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartColumnar_KAA.Legends.Add(legend2);
            this.chartColumnar_KAA.Location = new System.Drawing.Point(3, 3);
            this.chartColumnar_KAA.Name = "chartColumnar_KAA";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartColumnar_KAA.Series.Add(series2);
            this.chartColumnar_KAA.Size = new System.Drawing.Size(762, 332);
            this.chartColumnar_KAA.TabIndex = 6;
            this.chartColumnar_KAA.Text = "Грфик";
            // 
            // labelAvgPrice_KAA
            // 
            this.labelAvgPrice_KAA.AutoSize = true;
            this.labelAvgPrice_KAA.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelAvgPrice_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelAvgPrice_KAA.Location = new System.Drawing.Point(226, 379);
            this.labelAvgPrice_KAA.Name = "labelAvgPrice_KAA";
            this.labelAvgPrice_KAA.Size = new System.Drawing.Size(195, 24);
            this.labelAvgPrice_KAA.TabIndex = 5;
            this.labelAvgPrice_KAA.Text = "Средняя стоимость:";
            // 
            // labelMaxPrice_KAA
            // 
            this.labelMaxPrice_KAA.AutoSize = true;
            this.labelMaxPrice_KAA.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelMaxPrice_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelMaxPrice_KAA.ForeColor = System.Drawing.Color.Black;
            this.labelMaxPrice_KAA.Location = new System.Drawing.Point(12, 379);
            this.labelMaxPrice_KAA.Name = "labelMaxPrice_KAA";
            this.labelMaxPrice_KAA.Size = new System.Drawing.Size(167, 24);
            this.labelMaxPrice_KAA.TabIndex = 4;
            this.labelMaxPrice_KAA.Text = "Макс. стоимость:";
            // 
            // labelMin__KAA
            // 
            this.labelMin__KAA.AutoSize = true;
            this.labelMin__KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelMin__KAA.Location = new System.Drawing.Point(469, 379);
            this.labelMin__KAA.Name = "labelMin__KAA";
            this.labelMin__KAA.Size = new System.Drawing.Size(160, 24);
            this.labelMin__KAA.TabIndex = 3;
            this.labelMin__KAA.Text = "Мин. стоимость:";
            // 
            // textBoxAvgPrice_KAA
            // 
            this.textBoxAvgPrice_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxAvgPrice_KAA.Location = new System.Drawing.Point(230, 404);
            this.textBoxAvgPrice_KAA.Multiline = true;
            this.textBoxAvgPrice_KAA.Name = "textBoxAvgPrice_KAA";
            this.textBoxAvgPrice_KAA.ReadOnly = true;
            this.textBoxAvgPrice_KAA.Size = new System.Drawing.Size(191, 32);
            this.textBoxAvgPrice_KAA.TabIndex = 2;
            // 
            // textBoxMaxPrice_KAA
            // 
            this.textBoxMaxPrice_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxMaxPrice_KAA.Location = new System.Drawing.Point(16, 406);
            this.textBoxMaxPrice_KAA.Multiline = true;
            this.textBoxMaxPrice_KAA.Name = "textBoxMaxPrice_KAA";
            this.textBoxMaxPrice_KAA.ReadOnly = true;
            this.textBoxMaxPrice_KAA.Size = new System.Drawing.Size(163, 30);
            this.textBoxMaxPrice_KAA.TabIndex = 1;
            // 
            // textBoxMinPrice_KAA
            // 
            this.textBoxMinPrice_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxMinPrice_KAA.Location = new System.Drawing.Point(473, 404);
            this.textBoxMinPrice_KAA.Multiline = true;
            this.textBoxMinPrice_KAA.Name = "textBoxMinPrice_KAA";
            this.textBoxMinPrice_KAA.ReadOnly = true;
            this.textBoxMinPrice_KAA.Size = new System.Drawing.Size(156, 35);
            this.textBoxMinPrice_KAA.TabIndex = 0;
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_KAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.panel_KAA.ResumeLayout(false);
            this.panel_KAA.PerformLayout();
            this.tabControlGraph_KAA.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCircle_KAA)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartColumnar_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_KAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColumnar_KAA;
        private System.Windows.Forms.Label labelAvgPrice_KAA;
        private System.Windows.Forms.Label labelMaxPrice_KAA;
        private System.Windows.Forms.Label labelMin__KAA;
        private System.Windows.Forms.TextBox textBoxAvgPrice_KAA;
        private System.Windows.Forms.TextBox textBoxMaxPrice_KAA;
        private System.Windows.Forms.TextBox textBoxMinPrice_KAA;
        private System.Windows.Forms.TabControl tabControlGraph_KAA;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCircle_KAA;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonOK_KAA;
    }
}