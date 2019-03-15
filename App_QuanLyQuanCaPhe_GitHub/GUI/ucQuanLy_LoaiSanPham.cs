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
using DAO;
using DTO;
namespace GUI
{
    public partial class ucQuanLy_LoaiSanPham : UserControl
    {
        public ucQuanLy_LoaiSanPham()
        {
            InitializeComponent();
        }
        BUS_QuanLy xldl = new BUS_QuanLy();
        DTO_QuanLy dl = new DTO_QuanLy();
        void Binding()
        {
            txtChonLoai.DataBindings.Clear();
            txtChonLoai.DataBindings.Add("Text", dtgMenu.DataSource, "TenLoai");
            txtMaLoai.DataBindings.Clear();
            txtMaLoai.DataBindings.Add("Text", dtgMenu.DataSource, "MaLoai");
        }
        void Clear()
        {
            txtChonLoai.ResetText();
            txtMaLoai.Clear();
        }
        private void Enable_False()
        {
            txtChonLoai.Enabled = false;
        }
        private void Enable_True()
        {
            txtChonLoai.Enabled = true;
        }
        private void btHuy_Click(object sender, EventArgs e)
        {

        }
        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }
        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void btPhucHoi_Click(object sender, EventArgs e)
        {

        }

        private void ucQuanLy_LoaiSanPham_Load(object sender, EventArgs e)
        {
            dtgMenu.DataSource = xldl.ChonLoai_Select(dl);
            Enable_False();
        }
        private void txtChonLoai_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        bool them = false;
    }
}
