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

namespace Hotel_Management.GUI_CaiDat
{
    public partial class GUI_ListDichVu : UserControl
    {
        public GUI_ListDichVu()
        {
            InitializeComponent();
            ShowPanel();
        }

        private void ShowPanel()
        {
            this.Size = new Size(910, 189);
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
                this.Size = new Size(910, 45);

            }
            else
            {
                panelSubMenu.Visible = true;
                this.Size = new Size(910, 189);
            }
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowPanel();
        }

        private void GUI_ListDichVu_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {

        }
    }
}
