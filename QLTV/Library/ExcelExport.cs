using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Library
{
    internal class ExcelExport<T>
    {
        public ExcelExport(List<T> dataList, string title)
        {

          string filePath = "";
        // tạo SaveFileDialog để lưu file excel
        SaveFileDialog dialog = new SaveFileDialog();

        // chỉ lọc ra các file có định dạng Excel
        dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }
            ToExcel(dataList, filePath, title);
        }
         
        private void ToExcel<T>(List<T> dataList, object fileName, string title)
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

                Microsoft.Office.Interop.Excel.Range head = worksheet.get_Range("C1", "I1");
                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Tahoma";

                head.Font.Size = "15";

                Microsoft.Office.Interop.Excel.Range header = worksheet.get_Range("A3", "J3");
                header.Interior.ColorIndex = 49;
                header.Font.Color = System.Drawing.Color.White;

                // Lấy thông tin về lớp đối tượng đầu tiên trong danh sách
                // Lấy kiểu của đối tượng trong danh sách
                Type objectType = dataList[0].GetType();

                // Lấy danh sách các trường (thuộc tính) của đối tượng
                FieldInfo[] fields = objectType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);



                // Export nội dung từ danh sách dataList
                for (int i = 0; i < dataList.Count; i++)
                {
                    for (int j = 0; j < fields.Length; j++)
                    {
                        object value = fields[j].GetValue(dataList[i]); // Lấy giá trị của trường
                        worksheet.Cells[i + 3, j + 1] = value != null ? value.ToString() : "";
                        // Đặt chữ đậm cho hàng cuối cùng
                        if (i == dataList.Count - 1)
                        {
                            Microsoft.Office.Interop.Excel.Range row = (Microsoft.Office.Interop.Excel.Range)worksheet.Rows[i + 3];
                            row.Font.Bold = true;
                        }
                    }

                }
                // Tự động điều chỉnh độ rộng của từng cột theo độ rộng của nội dung
                Microsoft.Office.Interop.Excel.Range entireRow = worksheet.Rows;
                entireRow.AutoFit();

                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công! : " + fileName);
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
