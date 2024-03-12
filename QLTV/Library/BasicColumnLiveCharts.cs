using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Library
{
    internal class BasicColumnLiveCharts
    {

        public LiveCharts.WinForms.CartesianChart basicColumnChart;
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public BasicColumnLiveCharts(SeriesCollection data, string[] labelComlumns)
        {
            SeriesCollection = data;
            Labels = labelComlumns;
            setBasicColumn();
        }

        public void setBasicColumn()
        {

            basicColumnChart = new LiveCharts.WinForms.CartesianChart();
            basicColumnChart.Dock = DockStyle.Fill;
            if (SeriesCollection.Count() == 0)
            {
                SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Sách mượn ( Quyền)",
                    Values = new ChartValues<double> { 10, 50, 39, 50 }
                }
            };
            }

            if (Labels.Count() == 0)
                Labels = new[] { "Maria", "Susan", "Charles", "Frida" };

            Formatter = value => value.ToString("N");


            // Gán dữ liệu và định dạng cho biểu đồ
            basicColumnChart.Series = SeriesCollection;
            basicColumnChart.AxisX.Add(new Axis
            {
                Title = "Tháng - Năm",
                Labels = Labels
            });

            basicColumnChart.LegendLocation = LegendLocation.Bottom;


        }



        public Func<double, string> Formatter { get; set; }
    }
}
