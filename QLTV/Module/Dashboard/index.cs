using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Defaults;
using LiveCharts.WinForms;
using System.Windows;
using QLTV.Data.Model;
using System.Linq.Expressions;
using System.Collections;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QLTV.Library;

namespace QLTV.Module.Dashboard
{
    public partial class index : UserControl
    {
        private static index _instance;
        private DBContext _dbContext;

        public static index Instance
        {
            get
            {
                if (_instance == null) _instance = new index();
                return _instance;
            }
        }
        public index()
        {
            InitializeComponent();
            _dbContext = new DBContext();
            setData1();
            setData2();

        }
        private void setData1()
        {
            var query1 = this._dbContext.Books.Count();
            this.labelSachTrongThuVien.Text = query1.ToString();
            var query2 = (from BorrowRequest in this._dbContext.BorrowRequests
                          where BorrowRequest.UpdatedAt.Month == DateTime.Now.Month
                          select BorrowRequest.BookId)
                         .Distinct()
                         .Count();
            this.labelSachChoMuon.Text = query2.ToString();
            var query3 = (from BorrowRequest in this._dbContext.BorrowRequests
                          where BorrowRequest.Status == 1
                          where BorrowRequest.UpdatedAt.Month == DateTime.Now.Month
                          select BorrowRequest.BookId)
                         .Distinct()
                         .Count();
            this.labelSachDaTra.Text = query3.ToString();
            var query4 = (from BorrowTracking in _dbContext.BorrowTrackings
                          where BorrowTracking.UpdatedAt.Month == DateTime.Now.Month
                          select BorrowTracking.FineAmound
                          )
                          .Sum();
            decimal totalMoneyInMonth = query4 ?? 0;
            this.labelDoanhThuThang.Text = totalMoneyInMonth.ToString("#,##0 ;(#,##0 )");



        }
        private void setData2()
        {

            setStackedAreaChart();

            setPieChart();

            setBasicColumnChart();
        }
        public void setPieChart()
        {
            var query1 = (from BorrowTracking in _dbContext.BorrowTrackings
                          where BorrowTracking.UpdatedAt >= DateTime.Now.AddMonths(-5) && BorrowTracking.UpdatedAt <= DateTime.Now
                          group BorrowTracking by BorrowTracking.ReturnStatus into groupItems
                          select new
                          {
                              returnCode = groupItems.Key,
                              count = groupItems.Count()
                          }
 );

            List<PieSeries> stacks = new List<PieSeries>();
            foreach (var item in query1)
            {
                PieSeries pie = new PieSeries();

                switch (item.returnCode)
                {
                    case 1:
                        pie.Title = "Bình thường";
                        pie.Values = new ChartValues<ObservableValue> { new ObservableValue(item.count) };
                        pie.DataLabels = true;
                        break;
                    case 2:
                        pie.Title = "Xấu";
                        pie.Values = new ChartValues<ObservableValue> { new ObservableValue(item.count) };
                        pie.DataLabels = true;
                        break;
                    case 3:
                        pie.Title = "Quá hạn";
                        pie.Values = new ChartValues<ObservableValue> { new ObservableValue(item.count) };
                        pie.DataLabels = true;
                        break;
                    case 4:
                        pie.Title = "Phải bồi thường hoàn toàn";
                        pie.Values = new ChartValues<ObservableValue> { new ObservableValue(item.count) };
                        pie.DataLabels = true;
                        break;
                    default:
                        break;
                }
                stacks.Add(pie);
            }



            SeriesCollection chartData = new SeriesCollection();
            foreach (PieSeries item in stacks) chartData.Add(item);
            PieChartLiveCharts component = new PieChartLiveCharts(chartData);

            this.pictureBoxPieChartDemo.Visible = false;
            // Thêm PieChart vào Panel trong UserControl
            panelPiechart.Controls.Add(component.pieChart);
        }
        public void setStackedAreaChart()
        {
            // set so tien gui tra sach
            var query1 = (from BorrowTracking in _dbContext.BorrowTrackings
                          where BorrowTracking.UpdatedAt >= DateTime.Now.AddMonths(-5) && BorrowTracking.UpdatedAt <= DateTime.Now
                          select BorrowTracking
                         );
            List<BorrowTracking> listData1 = query1.ToList();
            List<StackedAreaSeries> stacks = new List<StackedAreaSeries>();

            for (int i = 0; i < 3; i++)
            {
                StackedAreaSeries stackedArea = new StackedAreaSeries(); // Khởi tạo StackedAreaSeries mới
                switch (i)
                {
                    case 0:
                        stackedArea.Title = "Trả sách xấu";
                        break;
                    case 1:
                        stackedArea.Title = "Trả sách quá hạn";
                        break;
                    case 2:
                        stackedArea.Title = "Trả sách bồi thường";
                        break;
                    default:
                        break;
                }


                stackedArea.Values = new ChartValues<DateTimePoint>();
                for (int j = 5; j >= 0; j--)
                {
                    DateTime dateTime = DateTime.Now.AddMonths(-j);
                    decimal money = listData1.Where(bt
                        => bt.UpdatedAt.Month == dateTime.Month && bt.UpdatedAt.Year == dateTime.Year
                        && bt.ReturnStatus == i + 2
                        )
                                 .Sum(bt => bt.FineAmound) ?? 0;
                    stackedArea.Values.Add(new DateTimePoint(dateTime, Convert.ToDouble(money / 1000000)));

                }
                stackedArea.LineSmoothness = 0;
                stacks.Add(stackedArea);

            }




            SeriesCollection chartData = new SeriesCollection();
            foreach (StackedAreaSeries item in stacks) chartData.Add(item);


            StackedAreaLiveCharts component = new StackedAreaLiveCharts(chartData);
            pictureBoxDemoStackedAreaChart.Visible = false;
            panelStackAreaChart.Controls.Add(component.stackedAreaChart);

        }
        public void setBasicColumnChart()
        {
            List<ColumnSeries> stacks = new List<ColumnSeries>();
            var query = (from BorrowRequest in _dbContext.BorrowRequests
                         where BorrowRequest.UpdatedAt >= DateTime.Now.AddMonths(-5) && BorrowRequest.UpdatedAt <= DateTime.Now
                         select BorrowRequest
                         );
            List<BorrowRequest> listData = query.ToList();
            string[] labels = new string[6];
            ColumnSeries model = new ColumnSeries();

            model.Title = "Sách mượn ( Quyền)";

            model.Values = new ChartValues<double>();
            for (int j = 5; j >= 0; j--)
            {
                DateTime dateTime = DateTime.Now.AddMonths(-j);
                int count = listData.Where(br
                    => br.UpdatedAt.Month == dateTime.Month && br.UpdatedAt.Year == dateTime.Year
                    ).Count();
                model.Values.Add(Convert.ToDouble(count));
                labels[j] = dateTime.ToString("MM-yyyy");
            }
            Array.Reverse(labels);
            model.DataLabels = true;
            stacks.Add(model);

            SeriesCollection chartData = new SeriesCollection();
            foreach (ColumnSeries item in stacks) chartData.Add(item);
            BasicColumnLiveCharts component = new BasicColumnLiveCharts(chartData, labels);
            pictureBoxBasicColumnDemo.Visible = false;
            panelBasicColumnChart.Controls.Add(component.basicColumnChart);
        }



    }
}
