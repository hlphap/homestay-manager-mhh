using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Hotel;
using Bunifu.UI.WinForms.BunifuButton;
using BUS_Hotel;
namespace Hotel_Management.GUI_CaiDat
{
    public partial class GUI_ListPhong : UserControl
    {
        public GUI_ListPhong()
        {
            InitializeComponent();
            ShowPanel();
        }
        BUS_Phong busp = new BUS_Phong();
        private int kt = 0;
        public void ReadOnlyTb()
        {
            if (txb_giaphong.ReadOnly == true)
            {
                txb_giaphong.ReadOnly = false;
                txb_loaiphong.ReadOnly = false;
                txb_sophong.ReadOnly = true;
                txb_tinhtrang.ReadOnly = false;
            }
            else
            {
                txb_giaphong.ReadOnly = true;
                txb_loaiphong.ReadOnly = true;
                txb_sophong.ReadOnly = true;
                txb_tinhtrang.ReadOnly = true;
            }
        }
        public void ShowPanel()
        {
            
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
                this.Size = new Size(910, 45);

            }
            else
            {
                panelSubMenu.Visible = true;
                this.Size = new Size(910, 219);
            }


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowPanel();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Luu.Visible = true; 
            ReadOnlyTb();
            kt = 1;

        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
     
            DTO_Phong objp = new DTO_Phong();
            objp.Sophong = this.txb_sophong.Text;
            objp.Gia = this.txb_giaphong.Text;
            objp.Status = this.txb_tinhtrang.Text;
            objp.Malp = this.txb_loaiphong.Text;
           
            lb_ten.Text = txb_sophong.Text;
            lb_status.Text = txb_tinhtrang.Text;
            if (kt == 0)
            {
                if (txb_sophong.Text == "")
                {
                    MessageBox.Show("Chưa nhập số phòng", "Erro");
                    return;
                }
                if (txb_loaiphong.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã loại phòng", "Erro");
                    return;
                }

                if (busp.Insert(objp) != "0")
                {
                    MessageBox.Show("Đã tồn tại mã phòng trên hệ thống", "Lỗi thêm phòng");
                    return;
                }
               
            }
            else
            {

                if (busp.Update(objp) != "0")
                {
                    MessageBox.Show("Cập nhật phòng thất bại", "Lỗi sửa phòng");
                    return;
                }
            }
            bt_Luu.Visible = false;
            ReadOnlyTb();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            DTO_Phong objp = new DTO_Phong();
            objp.Sophong = txb_sophong.Text;
            
            if (busp.Delete(objp) != "0")
            {
                MessageBox.Show("Vẫn còn phòng thuộc loại phòng này", "Lỗi xóa phòng");
                return;
            }
            this.Hide();
        }
    }
}
