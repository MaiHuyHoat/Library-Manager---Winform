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


namespace QLTV.Module.TaiNguyen.TacGia
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
            var query = from author in dbContext.Authors
                        select new { author };


            if (constraint != null)
            {
                if (constraint.TryGetValue("name", out string name))
                    query = query.Where(data => data.author.Name.ToLower().Contains(name.ToLower()));
            }


            List<TacGiaShow> listData = query.Select(data => new TacGiaShow
            {
                Id = data.author.Id,
                Name = data.author.Name
            }).ToList();

            this.dgvAuthors.Rows.Clear();
            foreach (TacGiaShow tgs in listData)
            {                
                    this.dgvAuthors.Rows.Add(tgs.Id.ToString(), tgs.Name);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
