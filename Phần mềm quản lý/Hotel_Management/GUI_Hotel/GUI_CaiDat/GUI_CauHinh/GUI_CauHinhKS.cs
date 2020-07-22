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
using DTO_Hotel;
using BUS_Hotel;
//using DAL_Hotel;

namespace Hotel_Management.GUI_CaiDat
{
    public partial class GUI_CauHinhKS : Form
    {
        public GUI_CauHinhKS()
        {
            InitializeComponent();
        }
        private int new_lp = 0;
        private int new_p = 0;
        private BUS_Phong bus = new BUS_Phong();
        private BUS_LoaiPhong bus_lp = new BUS_LoaiPhong();
        private BUS_DichVu bus_dv = new BUS_DichVu();

        
          
        private void GUI_CauHinhKS_Load(object sender, EventArgs e)
        {
            LoadListPhong();
            LoadListLoaiPhong();
            LoadListDichVu();
            

        }
   
    
        public void LoadListPhong()
        {
            flp_lsphong.Controls.Clear();
            List<DTO_Phong> lsobj_p = new List<DTO_Phong>();
            List<DTO_LoaiPhong> lsobj_lp = new List<DTO_LoaiPhong>();
            string result = this.bus.SelectAll(lsobj_p);
            string result1 = this.bus_lp.SelectAll(lsobj_lp);
            if (result != "0")
            {
                MessageBox.Show("Load list have been fail. \n" + result);
                return;
            }
            int i = 0;
            var fullPhong = from x in lsobj_lp
                            join y in lsobj_p on x.Malp equals y.Malp
                            select new
                            {
                                Sophong = y.Sophong,
                                Status = y.Status,
                                Gia = x.Gia,
                                Tenlp = x.Tenlp
                            };
            foreach (var item in fullPhong)
            {
                GUI_ListPhong phong = new GUI_ListPhong();
                phong.txb_sophong.Text = item.Sophong;
                phong.combobox_lp.Text = item.Tenlp;
                phong.txb_tinhtrang.Text = item.Status;
                phong.txb_giaphong.Text = item.Gia;
                phong.lb_ten.Text = item.Sophong;
                phong.lb_status.Text = item.Status;
                i++;
                phong.lb_stt.Text = i.ToString();
                phong.Dock = DockStyle.Top;
                this.flp_lsphong.Controls.Add(phong);

            }
            new_p = i;
        }

        public void LoadListLoaiPhong()
        {
            panel_ListLP.Controls.Clear();
            List<DTO_LoaiPhong> lsobj_lp = new List<DTO_LoaiPhong>();
            string result = this.bus_lp.SelectAll(lsobj_lp);
            if (result != "0")
            {
                MessageBox.Show("Load list have been fail. \n" + result);
                return;
            }
            int i = 0;
            foreach (DTO_LoaiPhong item in lsobj_lp)
            {
                GUI_ListLoaiPhong loaiphong = new GUI_ListLoaiPhong();
                loaiphong.txb_tenloaiphong.Text = item.Tenlp;
                loaiphong.txb_malp.Text = item.Malp;
                loaiphong.txb_giaphong.Text = item.Gia;
                loaiphong.txb_trangthietbi.Text = item.Trangthietbi;
                loaiphong.lb_ten.Text = item.Tenlp;
                loaiphong.lb_gia.Text = item.Gia.ToString();
                i++;
                loaiphong.lb_stt.Text = i.ToString();
                this.panel_ListLP.Controls.Add(loaiphong);
                loaiphong.Dock = DockStyle.Top;
            }
            new_lp = i;
        }

        public void LoadListDichVu()
        {
            panel_ListDV.Controls.Clear();
            List<DTO_DichVu> lsobj_dv = new List<DTO_DichVu>();
            string result = this.bus_dv.SelectAll(lsobj_dv);
            if (result != "0")
            {
                MessageBox.Show("Load list have been fail. \n" + result);
                return;
            }
            int i = 0;
            foreach (DTO_DichVu item in lsobj_dv)
            {
                GUI_ListDichVu x1DV = new GUI_ListDichVu();
                x1DV.txb_MaDV.Text = item.Madv;
                x1DV.txb_TenDV.Text = item.Tendv;
                x1DV.txb_GiaDV.Text = item.Giadv;
                x1DV.lb_TenDV.Text = item.Tendv;
                x1DV.lb_GiaDV.Text = item.Giadv;
                x1DV.txb_MoTa.Text = "Hỗ trợ nhu cầu khách hàng";
                i++;
                x1DV.lb_stt.Text = i.ToString();
                this.panel_ListDV.Controls.Add(x1DV);
                x1DV.Dock = DockStyle.Top;

            }
        }
        
        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            pageCauHinh.SetPage(0);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            pageCauHinh.SetPage(1);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            pageCauHinh.SetPage(2);
            LoadListDichVu();
        }

        private void btnAddLoaiPhong_Click(object sender, EventArgs e)
        {
            GUI_CaiDat.GUI_ListLoaiPhong x1_LoaiPhong = new GUI_CaiDat.GUI_ListLoaiPhong();
            new_lp++;
            x1_LoaiPhong.ReadOnlyTb();
            x1_LoaiPhong.txb_malp.Text = bus_lp.TaoMaLP();
            x1_LoaiPhong.txb_malp.ReadOnly = true;
            x1_LoaiPhong.lb_stt.Text = new_lp.ToString();
            x1_LoaiPhong.ShowPanel();
            x1_LoaiPhong.btn_luu.Visible = true;
            x1_LoaiPhong.btn_luu.Location = x1_LoaiPhong.bt_Sua.Location;
            x1_LoaiPhong.bt_Sua.Visible = false;
            panel_ListLP.Controls.Add(x1_LoaiPhong);
            x1_LoaiPhong.Dock = DockStyle.Top;
        }

        private void btnAddPhong_Click(object sender, EventArgs e)
        {
            GUI_CaiDat.GUI_ListPhong x1Phong = new GUI_CaiDat.GUI_ListPhong();
            new_p++;
            x1Phong.ReadOnlyTb();
            x1Phong.txb_tinhtrang.ReadOnly = true;
            x1Phong.txb_giaphong.ReadOnly = true;
            x1Phong.lb_stt.Text = new_p.ToString();
            x1Phong.ShowPanel();
            x1Phong.bt_Luu.Visible = true;
            x1Phong.bt_Luu.Location = x1Phong.bt_Sua.Location;
            x1Phong.bt_Sua.Visible = false;
            flp_lsphong.Controls.Add(x1Phong);
            x1Phong.Dock = DockStyle.Top;
        }

        private void btnAddDV_Click(object sender, EventArgs e)
        {
            GUI_CaiDat.GUI_ListDichVu guiListDV = new GUI_CaiDat.GUI_ListDichVu();
            panel_ListDV.Controls.Add(guiListDV);
            guiListDV.Dock = DockStyle.Top;
        }

     
        private void btn_LoadListPhong_Click_1(object sender, EventArgs e)
        {
            LoadListPhong();
        }

        private void btn_LoadListLP_Click(object sender, EventArgs e)
        {
            LoadListLoaiPhong();
        }
    }       
    
}
