using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class ucNhanVien : UserControl
    {
        public ucNhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien xldl = new BUS_NhanVien();
        DTO_NhanVien dl = new DTO_NhanVien();

        private void ucNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {

        }

        private void dtgNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
