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
    public partial class GUI_HuyPhong : UserControl
    {
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS_CTHD bus_cthd = new BUS_CTHD();
        BUS_LoaiPhong bus_lp = new BUS_LoaiPhong();
        BUS_Phong bus_p = new BUS_Phong();
        BUS_CTDV bus_ctdv = new BUS_CTDV();
        BUS_HoaDon bus_hd = new BUS_HoaDon();
        string get_MACTHD;
        public GUI_HuyPhong()
        {
            InitializeComponent();
          
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
                             NgaySinh = kh.Ngaysinh,
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
                ) ;

            foreach (var item in query)
            {
                txb_TenKH.Text = item.TenKH;
                txb_CMND.Text = item.CMND;
                txb_GioiTinh.Text = item.GioiTinh;
                txb_SinhNhat.Text = item.NgaySinh;
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
                             NgaySinh = kh.Ngaysinh,
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
                txb_SinhNhat.Text = item.NgaySinh;
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
        private void bt_Huy_Click(object sender, EventArgs e)
        {
            if (txb_MaKH.Text =="")
            {
                MessageBox.Show("Chưa nhập thông tin đơn đặt phòng cần hủy", "Erro");
                return;
            }
            DTO_CTHD obj_cthd = new DTO_CTHD();
            DTO_CTDV obj_ctdv = new DTO_CTDV();
            DTO_HoaDon obj_hd = new DTO_HoaDon();
            obj_hd.MaCTHD = get_MACTHD;
            obj_ctdv.Macthd = get_MACTHD;
            obj_cthd.Macthd = get_MACTHD;
            

            if (bus_ctdv.DeleteAll(obj_ctdv)!="0")
            {
                MessageBox.Show("Huy phong that bai");
                return;
            }
            if(bus_hd.Delete(obj_hd)!="0")
            {
                MessageBox.Show("Huy phong that bai");
                return;
            }
            if (bus_cthd.Delete(obj_cthd)!="0")
            {
                MessageBox.Show("Huy phong that bai");
                return;
            }
            List<DTO_LoaiPhong> lsobj_lp = new List<DTO_LoaiPhong>();
            List<DTO_Phong> lsobj_p = new List<DTO_Phong>();

            string result = bus_p.SelectAll(lsobj_p);
            string result1 = bus_lp.SelectAll(lsobj_lp);

            var Malp = from x in lsobj_p
                       join y in lsobj_lp on x.Malp equals y.Malp
                       where x.Sophong == txb_SoPhong.Text
                       select new
                       {
                           SoPhong = x.Sophong,
                           TrangThai = "EMPTY",
                           MaLP = x.Malp,
                       };

            DTO_Phong objp = new DTO_Phong();
            foreach (var x in Malp)
            {
                objp.Sophong = x.SoPhong;
                objp.Malp = x.MaLP;
                objp.Status = x.TrangThai;
            }
            bus_p.Update(objp);
            MessageBox.Show("Huy phong thanh cong");


        }

        private void txb_MaKH_Leave(object sender, EventArgs e)
        {
            LoadThongTinKHTuMAKH();
        }

        private void txb_CMND_Leave(object sender, EventArgs e)
        {
            LoadThongTinTuCMND();
        }
    }
}
