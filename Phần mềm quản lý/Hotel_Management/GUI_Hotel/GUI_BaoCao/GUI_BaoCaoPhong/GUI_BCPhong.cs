using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.GUI_BaoCao.GUI_BaoCaoPhong
{
    public partial class GUI_BCPhong : UserControl
    {
        public GUI_BCPhong()
        {
            InitializeComponent();
        }

      
        void RenderCharBC()
        {
            var canvas = new Bunifu.DataViz.WinForms.Canvas();
            Bunifu.DataViz.WinForms.DataPoint values = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);
          

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

            Chart_BaoCao.Render(canvas);
        }

        private void Chart_BaoCao_Load(object sender, EventArgs e)
        {
            RenderCharBC();
        }
    }
}
