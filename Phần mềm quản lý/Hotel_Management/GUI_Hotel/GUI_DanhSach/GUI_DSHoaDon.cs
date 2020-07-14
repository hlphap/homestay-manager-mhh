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
    public partial class GUI_DSHoaDon : UserControl
    {
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS_CTHD bus_cthd = new BUS_CTHD();
        BUS_LoaiPhong bus_lp = new BUS_LoaiPhong();
        BUS_Phong bus_p = new BUS_Phong();
        BUS_CTDV bus_ctdv = new BUS_CTDV();
        BUS_HoaDon bus_hd = new BUS_HoaDon();
        BUS_NhanVien bus_nv = new BUS_NhanVien();
        public GUI_DSHoaDon()
        {
            InitializeComponent();
        }
        string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private void LoadDonDatPhong()
        {
            panel_HoaDon.Controls.Clear();

            List<DTO_KhachHang> lsobj_kh = new List<DTO_KhachHang>();
            List<DTO_CTHD> lsobj_cthd = new List<DTO_CTHD>();
            List<DTO_LoaiPhong> lsobj_lp = new List<DTO_LoaiPhong>();
            List<DTO_Phong> lsobj_p = new List<DTO_Phong>();
            List<DTO_HoaDon> lsobj_hd = new List<DTO_HoaDon>();
            List<DTO_NhanVien> lsobj_nv = new List<DTO_NhanVien>();

            string result = bus_kh.SelectAll(lsobj_kh);
            string result1 = bus_cthd.selectAll(lsobj_cthd);
            string result2 = bus_lp.SelectAll(lsobj_lp);
            string result3 = bus_p.SelectAll(lsobj_p);
            string result4 = bus_hd.SelectAll(lsobj_hd);
            string result5 = bus_nv.SelectAll(lsobj_nv);


            var query = (from kh in lsobj_kh
                         join cthd in lsobj_cthd on kh.Makh equals cthd.Makh
                         join p in lsobj_p on cthd.Sophong equals p.Sophong
                         join hd in lsobj_hd on cthd.Macthd equals hd.MaCTHD
                         where cthd.Manv == Message
          
                         select new
                         {
                            MaKH = kh.Makh,
                            TenKH = kh.Tenkh,
                            SoPhong = p.Sophong,
                            NgayTT = hd.Ngaythanhtoan,
                            TraTruoc = hd.Tratruoc
                         }
                );
            foreach (var item in query)
            {
                GUI_DanhSach.x1HoaDon x1_HD = new GUI_DanhSach.x1HoaDon();
                x1_HD.lb_MaKH.Text = item.MaKH;
                x1_HD.lb_TenKH.Text = item.TenKH;
                x1_HD.lb_SoPhong.Text = item.SoPhong;
                x1_HD.lb_NgayThanhToan.Text = item.NgayTT;
                x1_HD.lb_TraTruoc.Text = item.TraTruoc;
                this.panel_HoaDon.Controls.Add(x1_HD);
                x1_HD.Dock = DockStyle.Top;

            }
        }
        private void GUI_DSHoaDon_Load(object sender, EventArgs e)
        {
            LoadDonDatPhong();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadDonDatPhong();
        }
    }
}
