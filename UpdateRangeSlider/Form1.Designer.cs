namespace UpdateRangeSlider
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Notice = new System.Windows.Forms.Label();
            this.rangeDatetime = new UpdateRangeSlider.Controls.RangeDatetimeSlider();
            this.SuspendLayout();
            // 
            // lbl_Notice
            // 
            this.lbl_Notice.AutoSize = true;
            this.lbl_Notice.Location = new System.Drawing.Point(99, 116);
            this.lbl_Notice.Name = "lbl_Notice";
            this.lbl_Notice.Size = new System.Drawing.Size(41, 12);
            this.lbl_Notice.TabIndex = 1;
            this.lbl_Notice.Text = "label1";
            // 
            // rangeDatetime
            // 
            this.rangeDatetime.BackColor = System.Drawing.Color.LightBlue;
            this.rangeDatetime.DisabledBarColor = System.Drawing.Color.Gray;
            this.rangeDatetime.DisabledRangeLabelColor = System.Drawing.Color.Gray;
            this.rangeDatetime.GapFromLeftMargin = ((uint)(10u));
            this.rangeDatetime.GapFromRightMargin = ((uint)(10u));
            this.rangeDatetime.HeightOfThumb = 20F;
            this.rangeDatetime.InFocusBarColor = System.Drawing.Color.Magenta;
            this.rangeDatetime.InFocusRangeLabelColor = System.Drawing.Color.Green;
            this.rangeDatetime.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rangeDatetime.LeftThumbImagePath = null;
            this.rangeDatetime.Location = new System.Drawing.Point(12, 12);
            this.rangeDatetime.MiddleBarWidth = ((uint)(3u));
            this.rangeDatetime.Name = "rangeDatetime";
            this.rangeDatetime.OutputStringFontColor = System.Drawing.Color.Black;
            this.rangeDatetime.Range1 = new System.DateTime(((long)(0)));
            this.rangeDatetime.Range2 = new System.DateTime(((long)(0)));
            this.rangeDatetime.RightThumbImagePath = null;
            this.rangeDatetime.Size = new System.Drawing.Size(666, 80);
            this.rangeDatetime.TabIndex = 2;
            this.rangeDatetime.ThumbColor = System.Drawing.Color.Purple;
            this.rangeDatetime.WidthOfThumb = 10F;
            this.rangeDatetime.RangeChange += new UpdateRangeSlider.Controls.RangeDatetimeSlider.RangeChangeDelegate(this.rangeDatetimeSlider1_RangeChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 380);
            this.Controls.Add(this.rangeDatetime);
            this.Controls.Add(this.lbl_Notice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Notice;
        private Controls.RangeDatetimeSlider rangeDatetime;
    }
}

