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

namespace Hotel_Management.GUI_NghiepVuPhong
{
    public partial class GUI_DatPhong : UserControl
    {
        private string _message;
        public GUI_DatPhong()
        {
            InitializeComponent();
        }
        bool kt_DatPhong = false;
        int tongtien=0;
        string get_MaCTHD;
        private void GUI_DatPhong_Load(object sender, EventArgs e)
        {
            LoadLoaiPhong();


        }
        BUS_CTHD bus_cthd = new BUS_CTHD();
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS_LoaiPhong bus_lp = new BUS_LoaiPhong();
        BUS_Phong bus_p = new BUS_Phong();
        BUS_DichVu bus_dv = new BUS_DichVu();
        BUS_CTDV bus_ctdv = new BUS_CTDV();
        BUS_HoaDon bus_hoadon = new BUS_HoaDon();

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private void LoadLoaiPhong()

        {
            List<DTO_LoaiPhong> lsobj_lp = new List<DTO_LoaiPhong>();
            string result = this.bus_lp.SelectAll(lsobj_lp);
            if (result != "0")
            {
                MessageBox.Show("Load list have been fail. \n" + result);
                return;
            }

            foreach (DTO_LoaiPhong item in lsobj_lp)
            {
                DropDown_LoaiPhong.Items.Add(item.Tenlp);
            }

        }
        private void LoadPhong()
        {

            List<DTO_Phong> lsobj = new List<DTO_Phong>();
            List<DTO_LoaiPhong> lsobjLP = new List<DTO_LoaiPhong>();
            
            string result = this.bus_p.SelectAll(lsobj);
            string result1 = this.bus_lp.SelectAll(lsobjLP);
           
            var listphong = from x in lsobj
                            join y in lsobjLP on x.Malp equals y.Malp
                          
                            where (y.Tenlp == DropDown_LoaiPhong.selectedValue) 
                            select new
                            {
                                Sophong = x.Sophong
                            };
            foreach (var item in listphong)
            {
                DropDown_Phong.Items.Add(item.Sophong);
            }


        }
        private void LoadDichVu()
        {
            List<DTO_DichVu> lsobj_dv = new List<DTO_DichVu>();
            string result = this.bus_dv.SelectAll(lsobj_dv);
            if (result != "0")
            {
                MessageBox.Show("Load list have been fail. \n" + result);
                return;
            }

            foreach (DTO_DichVu item in lsobj_dv)
            {
                DropDown_DV.Items.Add(item.Tendv);
            }
            DropDown_DV.selectedIndex = 0;
        }
        private void ShowThanhToan()
        {
            panelshow_ListDV.Controls.Clear();
            List<DTO_LoaiPhong> lsobj_lp = new List<DTO_LoaiPhong>();
            List<DTO_Phong> lsobj_p = new List<DTO_Phong>();
            List<DTO_CTHD> lsobj_cthd = new List<DTO_CTHD>();
            List<DTO_CTDV> lsobj_ctdv = new List<DTO_CTDV>();
            List<DTO_DichVu> lsobj_dv = new List<DTO_DichVu>();
            
            string result = bus_cthd.selectAll(lsobj_cthd);
            string result1 = bus_p.SelectAll(lsobj_p);
            string result2 = bus_lp.SelectAll(lsobj_lp);
            string result3 = bus_ctdv.SelectAll(lsobj_ctdv);
            string result4 = bus_dv.SelectAll(lsobj_dv);
            var query = (from lp in lsobj_lp
                         join p in lsobj_p on lp.Malp equals p.Malp
                         join cthd in lsobj_cthd on p.Sophong equals cthd.Sophong
                         select new
                         {
                             TenLP = lp.Tenlp,
                             GiaLP = lp.Gia
                         });

            foreach (var item in query)
            {
                txbTT_LoaiPhong.Text = item.TenLP;
                txbTT_Gia.Text = item.GiaLP;
                
            }
            tongtien = tongtien + Convert.ToInt32(txbTT_Gia.Text);

            var query2 = (from dv in lsobj_dv
                          join ctdv in lsobj_ctdv on dv.Madv equals ctdv.Madv
                          where ctdv.Macthd == get_MaCTHD
                          select new
                          {
                              TenDV = dv.Tendv,
                              MaDV = dv.Madv,
                              GiaDV = dv.Giadv
                          }
                          ) ;
            
            foreach(var item in query2)
            {

                GUI_NghiepVuPhong.GUI_ListDV x1DV = new GUI_NghiepVuPhong.GUI_ListDV();
                x1DV.lb_MaDV.Text = item.MaDV;
                x1DV.lb_TenDV.Text = item.TenDV;
                x1DV.lb_GiaDV.Text = item.GiaDV;
                tongtien = tongtien + Convert.ToInt32(x1DV.lb_GiaDV.Text);
                x1DV.bt_Xoa.Visible = false;
                panelshow_ListDV.Controls.Add(x1DV);
                x1DV.Dock = DockStyle.Top;
               
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bt_ToDichVu_Click(object sender, EventArgs e)
        {
            panel_ListDV.Controls.Clear();
            //ThemKH
            if (kt_DatPhong == false)
            {
            page_DatPhong.SetPage(1);
            DTO_CTHD obj_cthd = new DTO_CTHD();
            DTO_KhachHang obj_kh = new DTO_KhachHang();
            obj_kh.Makh = txb_MaKH.Text;
            obj_kh.Tenkh = txb_TenKhach.Text;
            obj_kh.Cmnd = txb_CMND.Text;
            obj_kh.Gioitinh = DropDown_GioiTinh.selectedValue;
            obj_kh.Sdt = txb_SDT.Text;
            obj_kh.Quoctich = txb_QuocTich.Text;
            obj_kh.Diachi = txb_DiaChi.Text;
            if (bus_kh.Insert(obj_kh) != "0")
            {
                MessageBox.Show("Thêm khách hàng thất bại");
            }
            //Them cthd
            obj_cthd.Macthd = bus_cthd.TaoMaCTHD();
            get_MaCTHD = obj_cthd.Macthd;
            obj_cthd.Makh = txb_MaKH.Text;
            obj_cthd.Ngaynhanphong = date_NgayNhan.Value.ToString();
            obj_cthd.Ngaydi = date_NgayDi.Value.ToString();
            obj_cthd.Sophong = DropDown_Phong.selectedValue;
            obj_cthd.Tratruoc = "0";
            obj_cthd.Manv = Message;
            if (bus_cthd.Insert(obj_cthd)!="0")
            {
                MessageBox.Show("Chọn phòng thất bại");
            }

            LoadDichVu();
            txbDV_MaKH.Text = obj_kh.Makh;
            txbTT_MaKH.Text = obj_kh.Makh;

            }
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void bt_Tiep2_Click(object sender, EventArgs e)
        {
            page_DatPhong.SetPage(2);
            ShowThanhToan();
            txb_TongTien.Text = tongtien.ToString();
            tongtien = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            page_DatPhong.SetPage(1);
            if (kt_DatPhong == true) return;
            else
            {
                DTO_CTDV obj = new DTO_CTDV();
                obj.Macthd = get_MaCTHD;
                bus_ctdv.DeleteAll(obj);
                panel_ListDV.Controls.Clear();
            }
           
        }

        //delete
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            page_DatPhong.SetPage(0);
            if (kt_DatPhong == true) return;
            else
            {
                DTO_CTHD obj_cthd = new DTO_CTHD();
                obj_cthd.Macthd = get_MaCTHD;
                if (bus_cthd.Delete(obj_cthd) != "0")
                {
                    MessageBox.Show("Lỗi");
                }
                //delete cthd
                DTO_KhachHang obj_kh = new DTO_KhachHang();
                obj_kh.Makh = txb_MaKH.Text;
                if (bus_kh.Delete(obj_kh) != "0")
                {
                    MessageBox.Show("Lỗi");
                }
            }
            

           
            //    delete kh
        }

        private void bt_DatPhong_Click(object sender, EventArgs e)
        {
            kt_DatPhong = true;
            DTO_HoaDon obj_hd = new DTO_HoaDon();
            obj_hd.MaCTHD = get_MaCTHD;
            obj_hd.Manv = Message;
            obj_hd.Mahd = bus_hoadon.TaoMaHD();
            obj_hd.Ngaythanhtoan = datetime_NgayNhanPhong.Value.ToString();
            obj_hd.Tratruoc = txb_TraTruoc.Text;
            if (bus_hoadon.Insert(obj_hd) != "0")
            {
                MessageBox.Show("Them Hoa Don That Bai");
                return;
            }
            MessageBox.Show("Dat phong thanh congs");
        }

        private void txb_Khach_Leave(object sender, EventArgs e)
        {
            kt_DatPhong = false;
            txb_MaKH.Text = bus_kh.TaoMaKH();
            DropDown_GioiTinh.selectedIndex = 1;
          
        }

        private void DropDown_LoaiPhong_onItemSelected(object sender, EventArgs e)
        {
            DropDown_Phong.Items.Clear();
            LoadPhong();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            List<DTO_DichVu> lsobj_dv = new List<DTO_DichVu>();
           
            string result = this.bus_dv.SelectAll(lsobj_dv);
            var selectitemDV = from x in lsobj_dv
                               where x.Tendv == DropDown_DV.selectedValue
                               select new
                               {
                                   MaDV = x.Madv,
                                   TenDV = x.Tendv,
                                   GiaDV = x.Giadv
                                };
            foreach (var item in selectitemDV)
            {

                DTO_CTDV obj_ctdv = new DTO_CTDV();
                obj_ctdv.Macthd = get_MaCTHD;
                obj_ctdv.Madv = item.MaDV;
                if (bus_ctdv.Insert(obj_ctdv) != "0")
                {
                    MessageBox.Show("Đã thêm dịch vụ này", "Lỗi thêm dịch vụ");
                    return;
                }
                GUI_NghiepVuPhong.GUI_ListDV x1DV = new GUI_NghiepVuPhong.GUI_ListDV();
                x1DV.lb_MaDV.Text = item.MaDV;
                x1DV.lb_TenDV.Text = item.TenDV;
                x1DV.lb_GiaDV.Text = item.GiaDV;
                panel_ListDV.Controls.Add(x1DV);
                x1DV.Dock = DockStyle.Top;
                x1DV.Message = obj_ctdv.Macthd;
            }


         
        }

        private void panel_ListDV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void DropDown_Phong_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}
