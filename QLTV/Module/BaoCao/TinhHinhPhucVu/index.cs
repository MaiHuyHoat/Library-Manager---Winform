using QLTV.Data.Entity;
using QLTV.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;


namespace QLTV.Module.BaoCao.TinhHinhPhucVu
{
    public partial class index : UserControl
    {
        private DBContext dbContext;
        private static index _instance;
        private string pathApp;
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
            dbContext = new DBContext();
            pathApp = this.getDrictoryApp();
            this.loadData(null);
        }
        public string getDrictoryApp()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string[] words = projectDirectory.Split(new char[] { '\\' });
            Array.Resize(ref words, words.Length - 4);
            return string.Join("\\", words);
        }
        private void loadData(Dictionary<string, string> constraint)
        {
            var query = from book in dbContext.Books
                        join borrowRequest in dbContext.BorrowRequests on book.Id equals borrowRequest.BookId

                        join borrowTracking in dbContext.BorrowTrackings on borrowRequest.Id equals borrowTracking.RequestId
                        where book.Deleted == 0 && borrowRequest.DueDate >= DateTime.Now.AddMonths(-6) && borrowRequest.DueDate <= DateTime.Now
                        group new { book, borrowRequest, borrowTracking } by new { book.Id, book.Image, book.Name, book.Amount } into bookGroup
                        select new
                        {
                            Id = bookGroup.Key.Id,
                            Image = bookGroup.Key.Image,
                            NameBook = bookGroup.Key.Name,
                            AmountBook = bookGroup.Key.Amount,
                            CountServed = bookGroup.Count(),
                            Borrow = bookGroup.Sum(data => data.borrowRequest.Status == 0 ? 1 : 0),
                            ReturnGood = bookGroup.Sum(data => data.borrowTracking.ReturnStatus == 1 ? 1 : 0),
                            ReturnBad = bookGroup.Sum(data => data.borrowTracking.ReturnStatus == 2 ? 1 : 0),
                            ReturnVeryBad = bookGroup.Sum(data => data.borrowTracking.ReturnStatus == 3 ? 1 : 0),
                            TotalFineAmount = bookGroup.Sum(data => data.borrowTracking.FineAmound ?? 0)
                        };
            if (constraint != null)
            {


                if (constraint.TryGetValue("name", out string name))
                    query = query.Where(data => data.NameBook.ToLower().Contains(name.ToLower()));


            }
            List<BaoCaoShow> listData = query.Select(data => new BaoCaoShow
            {
                Id = data.Id,
                PathImage = System.IO.Path.Combine(this.pathApp ?? this.getDrictoryApp(), "Resources", "image", data.Image),
                Name = data.NameBook,
                Amount = data.AmountBook,
                CountServed = data.CountServed,
                Borrow = data.Borrow,
                ReturnGood = data.ReturnGood,
                ReturnBad = data.ReturnBad,
                ReturnVeryBad = data.ReturnVeryBad,
                TotalFineAmount = (int)data.TotalFineAmount
            }).ToList();

            this.dataGridViewData.Rows.Clear();

            foreach (BaoCaoShow bs in listData)
            {
                // Đảm bảo rằng đường dẫn hình ảnh tồn tại trước khi thêm vào DataGridView
                if (File.Exists(bs.PathImage))
                {
                    this.dataGridViewData.Rows.Add(bs.Id.ToString(), Image.FromFile(bs.PathImage), bs.Name, bs.Amount, bs.CountServed, bs.Borrow, bs.ReturnGood, bs.ReturnBad, bs.ReturnVeryBad, bs.TotalFineAmount);
                }
                else
                {

                    this.dataGridViewData.Rows.Add(bs.Id.ToString(),
                        Image.FromFile(System.IO.Path.Combine(this.pathApp ?? this.getDrictoryApp(), "Resources", "image", "book.png"))
                        , bs.Name, bs.Amount.ToString(), bs.Borrow.ToString(), bs.ReturnGood.ToString(), bs.ReturnBad.ToString(), bs.ReturnVeryBad.ToString(), bs.TotalFineAmount.ToString());
                }
                for (int i = 3; i < 9; i++)
                {
                    dataGridViewData.Columns[i].DefaultCellStyle.Format = "0 Quyển";
                }
                dataGridViewData.Columns[9].DefaultCellStyle.Format = "0 Đồng";
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> constraint = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(this.textBoxTimkiem.Text)) constraint.Add("name", this.textBoxTimkiem.Text);
            this.loadData(constraint);
        }
        //private void ToExcel(DataGridView dataGridView,string fileName)
        //{
            
        //}
        private void buttonExport_Click(object sender, EventArgs e)
        {
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    ToExcel(dataGridViewData, saveFileDialog1.fileName);
            //}
        }

        private void ToExcel(DataGridView dataGridViewData, object fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Báo cáo";

                // export header trong DataGridView
                for (int i = 0; i < dataGridViewData.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridViewData.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridViewData.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewData.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridViewData.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
    }
}
