using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateChart();
        }
        private void CreateChart()
        {
            // Создайте элемент Chart
            Chart chart = new Chart();
            chart.Parent = this;
            chart.Size = new System.Drawing.Size(400, 300);
            chart.Location = new System.Drawing.Point(10, 10);

            // Создайте область диаграммы
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Создайте ряд данных
            Series series = new Series();
            series.Points.AddXY("Категория 1", 10);
            series.Points.AddXY("Категория 2", 35);
            series.Points.AddXY("Категория 3", 15);
            series.ChartType = SeriesChartType.Column; // Тип диаграммы - столбчатая
            chart.Series.Add(series);
        }
    }
}
