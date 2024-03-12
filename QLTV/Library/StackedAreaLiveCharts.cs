using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QLTV.Library
{
    internal class StackedAreaLiveCharts : INotifyPropertyChanged
    {
        public LiveCharts.WinForms.CartesianChart stackedAreaChart;
        private Func<double, string> _yFormatter;
        public SeriesCollection SeriesCollection { get; set; }
        public StackedAreaLiveCharts(SeriesCollection data)
        {
            SeriesCollection = data;
            setStackedArea();
        }

        public void setStackedArea()
        {

            stackedAreaChart = new LiveCharts.WinForms.CartesianChart();
            stackedAreaChart.Dock = DockStyle.Fill;
            if (SeriesCollection.Count() == 0)
            {
                SeriesCollection = new SeriesCollection
            {
                new StackedAreaSeries
                {
                    Title = "Dữ liệu trống",
                    Values = new ChartValues<DateTimePoint>
                    {
                        new DateTimePoint(new DateTime(1950, 1, 1), .228),
                        new DateTimePoint(new DateTime(1960, 1, 1), .285),
                        new DateTimePoint(new DateTime(1970, 1, 1), .366),
                        new DateTimePoint(new DateTime(1980, 1, 1), .478),
                        new DateTimePoint(new DateTime(1990, 1, 1), .629),
                        new DateTimePoint(new DateTime(2000, 1, 1), .808),
                        new DateTimePoint(new DateTime(2010, 1, 1), 1.031),
                        new DateTimePoint(new DateTime(2013, 1, 1), 1.110)
                    },
                    LineSmoothness = 0
                }

            };
            }


            XFormatter = val => new DateTime((long)val).ToString("yyyy-MM");
            YFormatter = val => val.ToString("N") + " M";

            stackedAreaChart.Series = SeriesCollection;
            stackedAreaChart.LegendLocation = LegendLocation.Bottom;
            stackedAreaChart.AxisX.Add(new Axis { LabelFormatter = XFormatter });
            stackedAreaChart.AxisY.Add(new Axis { LabelFormatter = YFormatter });




        }

        public Func<double, string> XFormatter { get; set; }

        public Func<double, string> YFormatter
        {
            get { return _yFormatter; }
            set
            {
                _yFormatter = value;
                OnPropertyChanged();
            }
        }

        public StackMode StackMode { get; set; }

        private void ChangeStackModeOnClick(object sender, RoutedEventArgs e)
        {
            foreach (var series in SeriesCollection.Cast<StackedAreaSeries>())
            {
                series.StackMode = series.StackMode == StackMode.Percentage
                    ? StackMode.Values
                    : StackMode.Percentage;
            }

            if (((StackedAreaSeries)SeriesCollection[0]).StackMode == StackMode.Values)
            {
                YFormatter = val => val.ToString("N") + " M";
            }
            else
            {
                YFormatter = val => val.ToString("P");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
