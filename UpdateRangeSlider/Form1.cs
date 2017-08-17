using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UpdateRangeSlider.Controls;

namespace UpdateRangeSlider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initRange();
        }

        private void initRange()
        {

            //  时间滑动条
            this.rangeDatetime.SetRange(DateTime.Now.AddHours(-1), DateTime.Now);
            this.rangeDatetime.GapFromLeftMargin = 40;
            this.rangeDatetime.GapFromRightMargin = 40;
        }

        private void rangeDatetimeSlider1_RangeChange(object sender, EventArgs e)
        {
            DateTime start;
            DateTime stop;
            ((RangeDatetimeSlider)sender).QueryRange(out start, out stop);

            StringBuilder sb = new StringBuilder();
            sb.Append(start.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.Append(" - ");
            sb.Append(stop.ToString("yyyy-MM-dd HH:mm:ss"));

            lbl_Notice.Text = sb.ToString();
        }
    }
}
