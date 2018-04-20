using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проф_ХОБЛ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackTips(trackBar1);
        }
        private void TrackTips(TrackBar tr)
        {
            toolTip1.SetToolTip(tr, tr.Value.ToString());
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            TrackTips(trackBar2);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            TrackTips(trackBar3);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            TrackTips(trackBar4);
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            TrackTips(trackBar5);
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            TrackTips(trackBar6);
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            TrackTips(trackBar7);
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            TrackTips(trackBar8);
        }
    }
}
