using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.DataViz;

namespace Hotel_Management.GUI_ThongTinChung
{
    public partial class GUI_ThongTinChung : UserControl
    {
        public GUI_ThongTinChung()
        {
            InitializeComponent();
        }

        private void GUI_ThongTinChung_Load(object sender, EventArgs e)
        {
            RenderChar_TTC();

        }
      
        void RenderChar_TTC()
        {
            var canvas = new Bunifu.DataViz.WinForms.Canvas();
            Bunifu.DataViz.WinForms.DataPoint values = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);
            var r = new Random();

            values.addLabely("SUN", "50");

            values.addLabely("MON", "100");

            values.addLabely("TUE", "60");

            values.addLabely("WED", "20");

            values.addLabely("THU", "40");

            values.addLabely("FRI", "70");

            values.addLabely("SAT", "150");

            // Add data sets to canvas

            canvas.addData(values);

            //render canvas

            Chart_ThongTinChung.Render(canvas);
        }

      
    }
}
