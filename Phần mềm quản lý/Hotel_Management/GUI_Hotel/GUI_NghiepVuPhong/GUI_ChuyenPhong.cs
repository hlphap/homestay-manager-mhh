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
    public partial class GUI_ChuyenPhong : UserControl
    {
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS_CTHD bus_cthd = new BUS_CTHD();
        BUS_LoaiPhong bus_lp = new BUS_LoaiPhong();
        BUS_Phong bus_p = new BUS_Phong();
        BUS_CTDV bus_ctdv = new BUS_CTDV();
        BUS_HoaDon bus_hd = new BUS_HoaDon();
        string get_MACTHD;
        public GUI_ChuyenPhong()
        {
            InitializeComponent();
            LoadLoaiPhong();
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
                dropDown_LoaiPhong.Items.Add(item.Tenlp);
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
                            where y.Tenlp == dropDown_LoaiPhong.selectedValue
                            select new
                            {
                                Sophong = x.Sophong
                            };
            foreach (var item in listphong)
            {
                dropDown_Phong.Items.Add(item.Sophong);
            }


        }
        private void LoadThongTinKHTuMAKH()
        {
            List<DTO_KhachHang> lsobj_kh = new List<DTO_KhachHang>();
            List<DTO_CTHD> lsobj_cthd = new List<DTO_CTHD>();
            List<DTO_LoaiPhong> lsobj_lp = new List<DTO_LoaiPhong>();
            List<DTO_Phong> lsobj_p = new List<DTO_Phong>();

            string result = bus_kh.SelectAll(lsobj_kh);
            string result1 = bus_cthd.selectAll(lsobj_cthd);
            string result2 = bus_lp.SelectAll(lsobj_lp);
            string result3 = bus_p.SelectAll(lsobj_p);
            var query = (from kh in lsobj_kh
                         join cthd in lsobj_cthd on kh.Makh equals cthd.Makh
                         join p in lsobj_p on cthd.Sophong equals p.Sophong
                         join lp in lsobj_lp on p.Malp equals lp.Malp
                         where kh.Makh == txb_MaKH.Text
                         select new
                         {
                             TenKH = kh.Tenkh,
                             CMND = kh.Cmnd,
                             GioiTinh = kh.Gioitinh,
                             SDT = kh.Sdt,
                             QuocTich = kh.Quoctich,
                             DiaChi = kh.Diachi,
                             NgayNhanPhong = cthd.Ngaynhanphong,
                             NgayDi = cthd.Ngaydi,
                             LoaiPhong = lp.Tenlp,
                             SoPhong = p.Sophong,
                             SoNguoi = "1",
                             MACTHD = cthd.Macthd
                         }
                );

            foreach (var item in query)
            {
                txb_TenKH.Text = item.TenKH;
                txb_CMND.Text = item.CMND;
                txb_GioiTinh.Text = item.GioiTinh;
                txb_SDT.Text = item.SDT;
                txb_QuocTich.Text = item.QuocTich;
                txb_DiaChi.Text = item.DiaChi;
                txb_NgayNhanPhong.Text = item.NgayNhanPhong;
                txb_NgayDi.Text = item.NgayDi;
                txb_LoaiPhong.Text = item.LoaiPhong;
                txb_SoPhong.Text = item.SoPhong;
                txb_SoNguoi.Text = item.SoNguoi;
                get_MACTHD = item.MACTHD;
            }
        }
        private void LoadThongTinTuCMND()
        {
            List<DTO_KhachHang> lsobj_kh = new List<DTO_KhachHang>();
            List<DTO_CTHD> lsobj_cthd = new List<DTO_CTHD>();
            List<DTO_LoaiPhong> lsobj_lp = new List<DTO_LoaiPhong>();
            List<DTO_Phong> lsobj_p = new List<DTO_Phong>();

            string result = bus_kh.SelectAll(lsobj_kh);
            string result1 = bus_cthd.selectAll(lsobj_cthd);
            string result2 = bus_lp.SelectAll(lsobj_lp);
            string result3 = bus_p.SelectAll(lsobj_p);
            var query = (from kh in lsobj_kh
                         join cthd in lsobj_cthd on kh.Makh equals cthd.Makh
                         join p in lsobj_p on cthd.Sophong equals p.Sophong
                         join lp in lsobj_lp on p.Malp equals lp.Malp
                         where kh.Cmnd == txb_CMND.Text
                         select new
                         {
                             TenKH = kh.Tenkh,
                             CMND = kh.Cmnd,
                             GioiTinh = kh.Gioitinh,
                             SDT = kh.Sdt,
                             QuocTich = kh.Quoctich,
                             DiaChi = kh.Diachi,
                             NgayNhanPhong = cthd.Ngaynhanphong,
                             NgayDi = cthd.Ngaydi,
                             LoaiPhong = lp.Tenlp,
                             SoPhong = p.Sophong,
                             SoNguoi = "1",
                             MACTHD = cthd.Macthd
                         }
                );

            foreach (var item in query)
            {
                txb_TenKH.Text = item.TenKH;
                txb_CMND.Text = item.CMND;
                txb_GioiTinh.Text = item.GioiTinh;
                txb_SDT.Text = item.SDT;
                txb_QuocTich.Text = item.QuocTich;
                txb_DiaChi.Text = item.DiaChi;
                txb_NgayNhanPhong.Text = item.NgayNhanPhong;
                txb_NgayDi.Text = item.NgayDi;
                txb_LoaiPhong.Text = item.LoaiPhong;
                txb_SoPhong.Text = item.SoPhong;
                txb_SoNguoi.Text = item.SoNguoi;
                get_MACTHD = item.MACTHD;
            }
        }

        private void txb_MaKH_Leave(object sender, EventArgs e)
        {
            LoadThongTinKHTuMAKH();
        }

        private void txb_CMND_Leave(object sender, EventArgs e)
        {
            LoadThongTinTuCMND();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dropDown_LoaiPhong_onItemSelected(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void BT_Chuyen_Click(object sender, EventArgs e)
        {
            DTO_CTHD obj_cthd = new DTO_CTHD();
            obj_cthd.Macthd = get_MACTHD;
            obj_cthd.Sophong = dropDown_Phong.selectedValue;
            if(bus_cthd.Update(obj_cthd)!="0")
            {
                MessageBox.Show("Chuyển phòng thất bại");
                return;
            }
            MessageBox.Show("Chuyển phòng thành công, từ phòng " + txb_SoPhong.Text + " đến " + dropDown_Phong.selectedValue);
        }
    }
}
