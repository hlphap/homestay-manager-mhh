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
using DAL_Hotel;
using BUS_Hotel;
using System.Net.NetworkInformation;
using Bunifu.UI.WinForms.BunifuButton;
using Hotel_Management.GUI_CaiDat;



namespace Hotel_Management.GUI_SoDoPhong
{
    public partial class GUI_SoDoPhong : UserControl
    {
        private BUS_Phong bus;
        private BUS_LoaiPhong buslp = new BUS_LoaiPhong();
        public GUI_SoDoPhong()
        {
            InitializeComponent();
            // LoadList();
        }

        private void LoadList()
        {

            flpnl_sodophong.Controls.Clear();
            List<DTO_Phong> lsobj = new List<DTO_Phong>();
            List<DTO_LoaiPhong> lsobjLP = new List<DTO_LoaiPhong>();
            string result = this.bus.SelectAll(lsobj);
            string result2 = this.buslp.SelectAll(lsobjLP);
            if (result != "0" || result2 != "0")
            {
                MessageBox.Show("Load list have been fail. \n" + result);
                return;
            }



            var tenlp = from x in lsobjLP
                        join y in lsobj on x.Malp equals y.Malp
                        select new
                        {
                            Gia = x.Gia.ToString(),
                            TenLP = x.Tenlp,
                            SoPhong = y.Sophong
                        };


            foreach (var item in tenlp)
            {

                GUI_x1Phong phong = new GUI_x1Phong();
                phong.lb_SoPhong.Text = item.SoPhong;
                phong.lb_Gia.Text = item.Gia;

                Console.WriteLine(item.Gia);
                phong.lb_LoaiPhong.Text = item.TenLP;
                flpnl_sodophong.Controls.Add(phong);
            }

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void GUI_SoDoPhong_Load(object sender, EventArgs e)
        {
            bus = new BUS_Phong();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}

