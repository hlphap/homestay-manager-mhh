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
    public partial class GUI_ListDV : UserControl
    {
        BUS_CTDV bus_ctdv = new BUS_CTDV();
        public GUI_ListDV()
        {
            InitializeComponent();
        }
        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DTO_CTDV obj_ctdv = new DTO_CTDV();
            obj_ctdv.Macthd = this.Message;
            obj_ctdv.Madv = lb_MaDV.Text;
           
            if (bus_ctdv.Delete(obj_ctdv) != "0")
            {
                MessageBox.Show("Lỗi xóa dịch vụ");
                return;
            }
            this.Hide();
            
        }
    }
}
