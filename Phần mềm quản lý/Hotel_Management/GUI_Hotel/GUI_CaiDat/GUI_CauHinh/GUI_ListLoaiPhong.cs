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
using BUS_Hotel;
namespace Hotel_Management.GUI_CaiDat
{
    public partial class GUI_ListLoaiPhong : UserControl
    {
        public GUI_ListLoaiPhong()
        {
            InitializeComponent();
            ShowPanel();
        }
        int kt=0;
        BUS_LoaiPhong bus_lp = new BUS_LoaiPhong();
        public void ReadOnlyTb()
        {
            if (txb_tenloaiphong.ReadOnly == true)
            {
                txb_giaphong.ReadOnly = false;
                txb_tenloaiphong.ReadOnly = false;
                txb_trangthietbi.ReadOnly = false;
                txb_malp.ReadOnly = true;
            }
            else
            {
                txb_giaphong.ReadOnly = true;
                txb_malp.ReadOnly = true;
                txb_tenloaiphong.ReadOnly = true;
                txb_trangthietbi.ReadOnly = true;
            }
        }
   
        public void ShowPanel()
        {
            this.Size = new Size(910, 219);
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
            ReadOnlyTb();
            btn_luu.Visible = true;
            kt = 1;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            //AddDuLieu
            DTO_LoaiPhong objlp = new DTO_LoaiPhong();
            objlp.Malp = txb_malp.Text;
            objlp.Tenlp = this.txb_tenloaiphong.Text;
            objlp.Gia = this.txb_giaphong.Text;
            objlp.Trangthietbi = this.txb_trangthietbi.Text;
            lb_ten.Text = txb_tenloaiphong.Text;
            lb_gia.Text = txb_giaphong.Text;
            if (kt == 0)
            {
                if(txb_malp.Text=="")
                {
                    MessageBox.Show("Chưa nhập mã loại phòng","Erro");
                    return;
                }
                if (txb_tenloaiphong.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên loại phòng", "Erro");
                    return;
                }
                if (txb_giaphong.Text == "")
                {
                    MessageBox.Show("Chưa nhập giá loại phòng", "Erro");
                    return;
                }
             
                if (bus_lp.Insert(objlp) != "0")
                {
                    MessageBox.Show(bus_lp.Insert(objlp), "Lỗi thêm phòng");
                    return;
                }
            }
            else
            {
 
                if (bus_lp.Update(objlp) != "0")
                {
                    MessageBox.Show("Cập nhật phòng thất bại", "Lỗi sửa phòng");
                    return;
                }
            }
               
            btn_luu.Visible = false;
            ReadOnlyTb();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DTO_LoaiPhong objlp = new DTO_LoaiPhong();
            objlp.Malp = txb_malp.Text;
            objlp.Tenlp = txb_tenloaiphong.Text;
            objlp.Gia = txb_giaphong.Text;
            objlp.Trangthietbi = txb_trangthietbi.Text;
            if (bus_lp.Delete(objlp)!="0")
            {
                MessageBox.Show("Vẫn còn phòng thuộc loại phòng này", "Lỗi xóa phòng");
                return;
            }
            this.Hide();
        }

        private void panelSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
