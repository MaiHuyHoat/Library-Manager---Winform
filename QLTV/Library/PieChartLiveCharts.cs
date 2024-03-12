using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Library
{
    internal class PieChartLiveCharts
    {
        public LiveCharts.WinForms.PieChart pieChart;
        public SeriesCollection SeriesCollection { get; set; }
        public PieChartLiveCharts(SeriesCollection data)
        {
            SeriesCollection = data;
            setPieChartData();
        }

        public void setPieChartData()
        {
            // Khởi tạo PieChart
            pieChart = new LiveCharts.WinForms.PieChart
            {
                Dock = DockStyle.Fill
            };

            // Thêm dữ liệu vào PieChart
            if (SeriesCollection.Count() == 0)
            {
                SeriesCollection = new SeriesCollection
            {
                  new PieSeries
                {
                    Title = "Chrome",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(8) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Mozilla",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(6) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Opera",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(10) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Explorer",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(4) },
                    DataLabels = true
                }
            };
            }
            pieChart.Series = SeriesCollection;
            pieChart.LegendLocation = LegendLocation.Right;
        }

    }
}
