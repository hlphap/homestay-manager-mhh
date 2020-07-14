using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BUS_Hotel;
using DTO_Hotel;
namespace Hotel_Management.GUI_CaiDat
{
    public partial class GUI_QuanTri : Form
    {
        public GUI_QuanTri()
        {
            InitializeComponent();
        }
        BUS_ThongTinKS bus = new BUS_ThongTinKS();
        //1.Load thong tin ks
        private void GUI_QuanTri_Load(object sender, EventArgs e)
        {
            DTO_ThongTinKS ttks =  bus.SelectAll();
            txtTen.Text = ttks.Tenks;
            txtSoDT.Text = ttks.SDTks;
            txtEmail.Text = ttks.Emailks;
            txtWebSite.Text = ttks.Websiteks;
            txtDiaChi.Text = ttks.Diachiks;
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            pageQuanTri.SetPage(1);
        }

        private void btn_ThemQuyen_Click(object sender, EventArgs e)
        {
            GUI_CaiDat.GUI_ListQuyen guiListQuyen = new GUI_CaiDat.GUI_ListQuyen();
            panel_ListQuyen.Controls.Add(guiListQuyen);
            guiListQuyen.Dock = DockStyle.Top;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_NhanSu_Click(object sender, EventArgs e)
        {
            pageQuanTri.SetPage(2);
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            GUI_CaiDat.GUI_ListNhanSu guiListNS = new GUI_CaiDat.GUI_ListNhanSu();
            panel_ListNS.Controls.Add(guiListNS);
            guiListNS.Dock = DockStyle.Top;
        }

        private void bt_ThongTin_Click(object sender, EventArgs e)
        {
            pageQuanTri.SetPage(0);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
