using QLTV.Data.Entity;
using QLTV.Data.Model;
using QLTV.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.Module.BaoCao.DocGiaHetHan
{
    public partial class index : UserControl
    {

        private DBContext dbContext;
        private List<DocGiaHetHanShow> listDataShow;
        private static index _instance;
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
            this.loadData(null);
            this.setComboboxChucvu();

        }
        private void loadData(Dictionary<string, string> constraint)
        {
            //var query = from reader in dbContext.Readers
            //            join role in dbContext.RoleReaders on reader.RoleId equals role.Id
            //            where reader.Deleted == 0 && reader.EndDay <= DateTime.Now
            //            select new { reader, role };

            var query = from reader in dbContext.Readers
                        join role in dbContext.RoleReaders on reader.RoleId equals role.Id
                        where reader.Deleted == 0 && reader.EndDay <= DateTime.Now
                        select new
                        {
                            reader,
                            role,
                            SoSachDaMuon = dbContext.BorrowRequests.Where(br => br.ReaderId == reader.Id).Count(),
                            SoSachDaTra = dbContext.BorrowRequests.Where(br => br.ReaderId == reader.Id && br.Status == 1).Count(),
                            SoSachChuaTra = dbContext.BorrowRequests.Where(br => br.ReaderId == reader.Id).Count() - dbContext.BorrowRequests.Where(br => br.ReaderId == reader.Id && br.Status == 1).Count()
                        };


            if (constraint != null)
            {
                if (constraint.TryGetValue("name", out string name))
                    query = query.Where(data => data.reader.Name.ToLower().Contains(name.ToLower()));
                //if (constraint.TryGetValue("dateofbirth", out string dateofbirth))
                //    query = query.Where(data => data.reader.DateOfBirth.ToLower().Contains(dateofbirth.ToLower()));
                if (constraint.TryGetValue("dateofbirth", out string dateofbirth))
                {
                    if (dateofbirth.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        query = query.OrderByDescending(data => data.reader.DateOfBirth);

                    if (dateofbirth.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        query = query.OrderBy(data => data.reader.DateOfBirth);
                }
                if (constraint.TryGetValue("identitycard", out string identityCard))
                    query = query.Where(data => data.reader.IdentityCard.ToLower().Contains(identityCard.ToLower()));
                if (constraint.TryGetValue("roleName", out string roleName))
                    query = query.Where(data => data.role.Name.ToLower().Contains(roleName.ToLower()));
                if (constraint.TryGetValue("startedDate", out string startedDate))
                {
                    if (startedDate.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        query = query.OrderByDescending(data => data.reader.StartDay);

                    if (startedDate.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        query = query.OrderBy(data => data.reader.StartDay);
                }
            }
            List<DocGiaHetHanShow> listDocGiaHH = query.Select(data => new DocGiaHetHanShow
            {
                Id = data.reader.Id,
                Name = data.reader.Name,
                DateOfBirth = data.reader.DateOfBirth.ToString("dd-MM-yyyy"),
                IdentityCard = data.reader.IdentityCard,
                Role = data.role.Name,
                StartDate = data.reader.StartDay.ToString("dd-MM-yyyy"),
                EndDate = data.reader.EndDay.ToString("dd-MM-yyyy"),
                BorrowRequestCount = data.SoSachDaMuon,
                BookReturned = data.SoSachDaTra,
                BookNotReturned = data.SoSachChuaTra
            }).ToList();


            listDataShow = listDocGiaHH;


            this.dataGridViewData.Rows.Clear();
            foreach (DocGiaHetHanShow dgs in listDocGiaHH)
            {
                this.dataGridViewData.Rows.Add(dgs.Id.ToString(), dgs.Name, dgs.DateOfBirth, dgs.IdentityCard, dgs.Role, dgs.StartDate, dgs.EndDate, dgs.BorrowRequestCount, dgs.BookReturned, dgs.BookNotReturned);
            }
        }
        private void reLoadData(object sender, EventArgs e)
        {
            this.loadData(null);
        }
        private void setComboboxChucvu()
        {
            this.comboBoxChucVu.Items.Clear();
            this.comboBoxChucVu.Items.Add("Tất cả");
            List<RoleReader> roleList = dbContext.RoleReaders.ToList();

            foreach (RoleReader role in roleList)
            {
                this.comboBoxChucVu.Items.Add(role.Name);
            }
            this.comboBoxChucVu.SelectedIndex = 0;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> constraint = new Dictionary<string, string>();
            if (this.comboBoxChucVu.SelectedIndex != 0) constraint.Add("roleName", this.comboBoxChucVu.SelectedItem.ToString());
            if (!string.IsNullOrEmpty(this.textBoxTimkiem.Text)) constraint.Add("identitycard", this.textBoxTimkiem.Text);
            this.loadData(constraint);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            List<DocGiaHetHanExportExcel> exportData= new List<DocGiaHetHanExportExcel> ();
            exportData.Add(new DocGiaHetHanExportExcel("Id", "Tên", "CMT", "Ngày sinh", "Chức vụ", "Ngày cấp thẻ", "Ngày hết hạn", "Số sách đã mượn", "Số sách đã trả", "Số sách chưa trả"));
            foreach (DocGiaHetHanShow dgs in this.listDataShow)
            {
                exportData.Add(new DocGiaHetHanExportExcel(dgs.Id.ToString(),dgs.Name,dgs.IdentityCard,dgs.DateOfBirth,dgs.Role,dgs.StartDate,dgs.EndDate,dgs.BorrowRequestCount.ToString(),dgs.BookReturned.ToString(),dgs.BookNotReturned.ToString()));
            }
            ExcelExport<DocGiaHetHanShow> excel = new ExcelExport<DocGiaHetHanShow>(this.listDataShow, "Danh sách độc giả hết hạn");
        }
    }
}
