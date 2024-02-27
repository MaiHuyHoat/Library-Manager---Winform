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

namespace QLTV.Module.TaiNguyen.TheLoai
{
    public partial class index : UserControl
    {
        private DBContext dbContext;
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
        }
        private void loadData(Dictionary<string, string> constraint)
        {
            var query = from category in dbContext.Categories
                       
                        select new { category };


            if (constraint != null)
            {
               

                if (constraint.TryGetValue("name", out string name))
                    query = query.Where(data => data.category.Name.ToLower().Contains(name.ToLower()));

               
            }


            List<TheLoaiShow> listData = query.Select(data => new TheLoaiShow
            {
                Id = data.category.Id,
          
                Name = data.category.Name,
               
              
            }).ToList();

            this.dataGridViewData.Rows.Clear();

            foreach (TheLoaiShow tls in listData)
            {
                // Đảm bảo rằng đường dẫn hình ảnh tồn tại trước khi thêm vào DataGridView
               
               
                    this.dataGridViewData.Rows.Add(tls.Id.ToString(),  tls.Name);
                
               
            }
        }
    }
}
