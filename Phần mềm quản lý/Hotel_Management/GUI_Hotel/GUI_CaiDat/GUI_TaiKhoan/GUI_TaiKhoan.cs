using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.GUI_CaiDat
{
    public partial class GUI_TaiKhoan : Form
    {
        public GUI_TaiKhoan()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HideButton()
        {
            btnHuy.Visible = false;
            btnLuu.Visible = false;
        }

        private void ShowButton()
        {
            btnHuy.Visible = true;
            btnLuu.Visible = true;
        }
        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            if (btnHuy.Visible == false)
            {
                ShowButton();
             
            }
            else
            {
                HideButton();
             
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HideButton();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HideButton();
        }

        private void bt_HoSo_Click(object sender, EventArgs e)
        {
            page.SetPage(0);
        }

        private void bt_LichLamViec_Click(object sender, EventArgs e)
        {
            page.SetPage(1);
        }
    }
}
