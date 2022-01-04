using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            //month 1-12
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 12;
            //temperature 
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = -50;
            objChart.AxisY.Maximum = 50;
            //clear
            chart.Series.Clear();
            //random color
            Random random = new Random();
            //loop rows
            foreach (Temperature t in temperatureBindingSource.DataSource as List<Temperature>)
            {
                chart.Series.Add(t.Location);
                chart.Series[t.Location].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                chart.Series[t.Location].Legend = "Legend1";
                chart.Series[t.Location].ChartArea = "ChartArea1";
                chart.Series[t.Location].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //adding data
                for (int i = 1; i <= 12; i++)
                    chart.Series[t.Location].Points.AddXY(i, Convert.ToInt32(t[$"M{i}"]));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temperatureBindingSource.DataSource = new List<Temperature>();
        }
    }
}
