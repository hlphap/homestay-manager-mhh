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
namespace Hotel_Management.GUI_DanhSach
{
    public partial class GUI_DSDonDatPhong : UserControl
    {
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS_CTHD bus_cthd = new BUS_CTHD();
        BUS_LoaiPhong bus_lp = new BUS_LoaiPhong();
        BUS_Phong bus_p = new BUS_Phong();
        BUS_CTDV bus_ctdv = new BUS_CTDV();
        BUS_HoaDon bus_hd = new BUS_HoaDon();

        public GUI_DSDonDatPhong()
        {
            InitializeComponent();
        }
        private void LoadDonDatPhong()
        {
            panel_DonDatPhong.Controls.Clear();
       
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
                         select new
                         {
                             MaKH = kh.Makh,
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
                ) ;
            foreach (var item in query)
            {
                GUI_DanhSach.x1DonDatPhong x1_DDP = new GUI_DanhSach.x1DonDatPhong();
                x1_DDP.lb_MaKH.Text = item.MaKH;
                x1_DDP.lb_TenKH.Text = item.TenKH;
                x1_DDP.lb_NgayDen.Text = item.NgayNhanPhong;
                x1_DDP.lb_NgayDi.Text = item.NgayDi;
                x1_DDP.lb_SoPhong.Text = item.SoPhong;
                this.panel_DonDatPhong.Controls.Add(x1_DDP);
                x1_DDP.Dock = DockStyle.Top;

            }
        } 

        private void GUI_DSDonDatPhong_Load(object sender, EventArgs e)
        {
            LoadDonDatPhong();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadDonDatPhong();
        }
    }
}
