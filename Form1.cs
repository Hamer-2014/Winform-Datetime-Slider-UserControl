using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestApplication
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class TestApp : System.Windows.Forms.Form
	{
		//private TestControl.UserControl1 userControl11;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private string strRangeString;
        private CustomRangeSelectorControl.NotifyClient objNotifyClient;
        private CustomRangeSelectorControl.RangeSelectorControl rangeSelectorControl1;
        private System.Timers.Timer timer1;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private CustomRangeSelectorControl.RangeSelectorControl rangeSelectorControl2;
        private GroupBox groupBox3;
        private CustomRangeSelectorControl.RangeSelectorControl rangeSelectorControl3;
        private GroupBox groupBox4;
        private CustomRangeSelectorControl.RangeSelectorControl rangeSelectorControl4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private CustomRangeSelectorControl.RangeSelectorControl rangeSelectorControl5;
        private CustomRangeSelectorControl.RangeSelectorControl rangeSelectorControl6;
        private CustomRangeSelectorControl.RangeSelectorControl rangeSelectorControl7;
        private DateTimePicker dateTimePicker_Stop;
        private DateTimePicker dateTimePicker_Start;
        private Button button2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TestApp()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Timers.Timer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rangeSelectorControl1 = new CustomRangeSelectorControl.RangeSelectorControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rangeSelectorControl2 = new CustomRangeSelectorControl.RangeSelectorControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rangeSelectorControl3 = new CustomRangeSelectorControl.RangeSelectorControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rangeSelectorControl4 = new CustomRangeSelectorControl.RangeSelectorControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rangeSelectorControl5 = new CustomRangeSelectorControl.RangeSelectorControl();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rangeSelectorControl6 = new CustomRangeSelectorControl.RangeSelectorControl();
            this.rangeSelectorControl7 = new CustomRangeSelectorControl.RangeSelectorControl();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Stop = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Query custom control for the Selected Range";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(99, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "textBox1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Registered Notification for the Client";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(99, 21);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "textBox2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rangeSelectorControl1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 220);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Range Control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Output to the client application from the control assembly:";
            // 
            // rangeSelectorControl1
            // 
            this.rangeSelectorControl1.BackColor = System.Drawing.SystemColors.Control;
            this.rangeSelectorControl1.DelimiterForRange = ",";
            this.rangeSelectorControl1.DisabledBarColor = System.Drawing.Color.Olive;
            this.rangeSelectorControl1.DisabledRangeLabelColor = System.Drawing.Color.Gray;
            this.rangeSelectorControl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rangeSelectorControl1.GapFromLeftMargin = ((uint)(20u));
            this.rangeSelectorControl1.GapFromRightMargin = ((uint)(20u));
            this.rangeSelectorControl1.HeightOfThumb = 25F;
            this.rangeSelectorControl1.InFocusBarColor = System.Drawing.Color.DarkKhaki;
            this.rangeSelectorControl1.InFocusRangeLabelColor = System.Drawing.Color.DarkRed;
            this.rangeSelectorControl1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rangeSelectorControl1.LeftThumbImagePath = null;
            this.rangeSelectorControl1.Location = new System.Drawing.Point(11, 16);
            this.rangeSelectorControl1.MiddleBarWidth = ((uint)(4u));
            this.rangeSelectorControl1.Name = "rangeSelectorControl1";
            this.rangeSelectorControl1.OutputStringFontColor = System.Drawing.Color.Black;
            this.rangeSelectorControl1.Range1 = "20";
            this.rangeSelectorControl1.Range2 = "40";
            this.rangeSelectorControl1.RangeString = "Selected Range:";
            this.rangeSelectorControl1.RangeValues = "10,20,30,40,50";
            this.rangeSelectorControl1.RightThumbImagePath = null;
            this.rangeSelectorControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rangeSelectorControl1.Size = new System.Drawing.Size(407, 90);
            this.rangeSelectorControl1.TabIndex = 9;
            this.rangeSelectorControl1.ThumbColor = System.Drawing.Color.Blue;
            this.rangeSelectorControl1.WidthOfThumb = 10F;
            this.rangeSelectorControl1.XMLFileName = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rangeSelectorControl2);
            this.groupBox2.Location = new System.Drawing.Point(462, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 83);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A tiny one";
            // 
            // rangeSelectorControl2
            // 
            this.rangeSelectorControl2.BackColor = System.Drawing.Color.LightBlue;
            this.rangeSelectorControl2.DelimiterForRange = ",";
            this.rangeSelectorControl2.DisabledBarColor = System.Drawing.Color.Gray;
            this.rangeSelectorControl2.DisabledRangeLabelColor = System.Drawing.Color.Gray;
            this.rangeSelectorControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeSelectorControl2.GapFromLeftMargin = ((uint)(10u));
            this.rangeSelectorControl2.GapFromRightMargin = ((uint)(10u));
            this.rangeSelectorControl2.HeightOfThumb = 15F;
            this.rangeSelectorControl2.InFocusBarColor = System.Drawing.Color.Indigo;
            this.rangeSelectorControl2.InFocusRangeLabelColor = System.Drawing.Color.Green;
            this.rangeSelectorControl2.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.rangeSelectorControl2.LeftThumbImagePath = null;
            this.rangeSelectorControl2.Location = new System.Drawing.Point(7, 20);
            this.rangeSelectorControl2.MiddleBarWidth = ((uint)(1u));
            this.rangeSelectorControl2.Name = "rangeSelectorControl2";
            this.rangeSelectorControl2.OutputStringFontColor = System.Drawing.Color.Black;
            this.rangeSelectorControl2.Range1 = "2";
            this.rangeSelectorControl2.Range2 = "9";
            this.rangeSelectorControl2.RangeString = "Range";
            this.rangeSelectorControl2.RangeValues = "1,2,3,4,5,6,7,8,9,10";
            this.rangeSelectorControl2.RightThumbImagePath = null;
            this.rangeSelectorControl2.Size = new System.Drawing.Size(286, 54);
            this.rangeSelectorControl2.TabIndex = 0;
            this.rangeSelectorControl2.ThumbColor = System.Drawing.Color.Purple;
            this.rangeSelectorControl2.WidthOfThumb = 5F;
            this.rangeSelectorControl2.XMLFileName = null;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rangeSelectorControl3);
            this.groupBox3.Location = new System.Drawing.Point(769, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 83);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "A bold thick one - in miles";
            // 
            // rangeSelectorControl3
            // 
            this.rangeSelectorControl3.BackColor = System.Drawing.SystemColors.Control;
            this.rangeSelectorControl3.DelimiterForRange = ",";
            this.rangeSelectorControl3.DisabledBarColor = System.Drawing.Color.Gray;
            this.rangeSelectorControl3.DisabledRangeLabelColor = System.Drawing.Color.Gray;
            this.rangeSelectorControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeSelectorControl3.GapFromLeftMargin = ((uint)(10u));
            this.rangeSelectorControl3.GapFromRightMargin = ((uint)(10u));
            this.rangeSelectorControl3.HeightOfThumb = 15F;
            this.rangeSelectorControl3.InFocusBarColor = System.Drawing.Color.DeepSkyBlue;
            this.rangeSelectorControl3.InFocusRangeLabelColor = System.Drawing.Color.Green;
            this.rangeSelectorControl3.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.rangeSelectorControl3.LeftThumbImagePath = null;
            this.rangeSelectorControl3.Location = new System.Drawing.Point(7, 20);
            this.rangeSelectorControl3.MiddleBarWidth = ((uint)(3u));
            this.rangeSelectorControl3.Name = "rangeSelectorControl3";
            this.rangeSelectorControl3.OutputStringFontColor = System.Drawing.Color.Black;
            this.rangeSelectorControl3.Range1 = "2m";
            this.rangeSelectorControl3.Range2 = "8m";
            this.rangeSelectorControl3.RangeString = "Range";
            this.rangeSelectorControl3.RangeValues = "1m,2m,3m,4m,5m,6m,7m,8m,9m,10m";
            this.rangeSelectorControl3.RightThumbImagePath = null;
            this.rangeSelectorControl3.Size = new System.Drawing.Size(252, 54);
            this.rangeSelectorControl3.TabIndex = 0;
            this.rangeSelectorControl3.ThumbColor = System.Drawing.Color.Purple;
            this.rangeSelectorControl3.WidthOfThumb = 10F;
            this.rangeSelectorControl3.XMLFileName = null;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rangeSelectorControl4);
            this.groupBox4.Location = new System.Drawing.Point(462, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(574, 118);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "A Lengthy one in %";
            // 
            // rangeSelectorControl4
            // 
            this.rangeSelectorControl4.BackColor = System.Drawing.SystemColors.Control;
            this.rangeSelectorControl4.DelimiterForRange = ",";
            this.rangeSelectorControl4.DisabledBarColor = System.Drawing.Color.Gray;
            this.rangeSelectorControl4.DisabledRangeLabelColor = System.Drawing.Color.Gray;
            this.rangeSelectorControl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeSelectorControl4.GapFromLeftMargin = ((uint)(15u));
            this.rangeSelectorControl4.GapFromRightMargin = ((uint)(15u));
            this.rangeSelectorControl4.HeightOfThumb = 15F;
            this.rangeSelectorControl4.InFocusBarColor = System.Drawing.Color.Cyan;
            this.rangeSelectorControl4.InFocusRangeLabelColor = System.Drawing.Color.Teal;
            this.rangeSelectorControl4.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rangeSelectorControl4.LeftThumbImagePath = null;
            this.rangeSelectorControl4.Location = new System.Drawing.Point(15, 20);
            this.rangeSelectorControl4.MiddleBarWidth = ((uint)(1u));
            this.rangeSelectorControl4.Name = "rangeSelectorControl4";
            this.rangeSelectorControl4.OutputStringFontColor = System.Drawing.Color.Black;
            this.rangeSelectorControl4.Range1 = "3%";
            this.rangeSelectorControl4.Range2 = "8%";
            this.rangeSelectorControl4.RangeString = "Range";
            this.rangeSelectorControl4.RangeValues = "1%,2%,3%,4%,5%,6%,7%,8%,9%,10%";
            this.rangeSelectorControl4.RightThumbImagePath = null;
            this.rangeSelectorControl4.Size = new System.Drawing.Size(559, 89);
            this.rangeSelectorControl4.TabIndex = 0;
            this.rangeSelectorControl4.ThumbColor = System.Drawing.Color.DarkCyan;
            this.rangeSelectorControl4.WidthOfThumb = 14F;
            this.rangeSelectorControl4.XMLFileName = null;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rangeSelectorControl5);
            this.groupBox5.Location = new System.Drawing.Point(14, 252);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1022, 114);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "One from XML file";
            // 
            // rangeSelectorControl5
            // 
            this.rangeSelectorControl5.BackColor = System.Drawing.SystemColors.Control;
            this.rangeSelectorControl5.DelimiterForRange = ",";
            this.rangeSelectorControl5.DisabledBarColor = System.Drawing.Color.Gray;
            this.rangeSelectorControl5.DisabledRangeLabelColor = System.Drawing.Color.Gray;
            this.rangeSelectorControl5.GapFromLeftMargin = ((uint)(15u));
            this.rangeSelectorControl5.GapFromRightMargin = ((uint)(15u));
            this.rangeSelectorControl5.HeightOfThumb = 20F;
            this.rangeSelectorControl5.InFocusBarColor = System.Drawing.Color.DarkViolet;
            this.rangeSelectorControl5.InFocusRangeLabelColor = System.Drawing.Color.Indigo;
            this.rangeSelectorControl5.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rangeSelectorControl5.LeftThumbImagePath = null;
            this.rangeSelectorControl5.Location = new System.Drawing.Point(17, 20);
            this.rangeSelectorControl5.MiddleBarWidth = ((uint)(2u));
            this.rangeSelectorControl5.Name = "rangeSelectorControl5";
            this.rangeSelectorControl5.OutputStringFontColor = System.Drawing.Color.Black;
            this.rangeSelectorControl5.Range1 = "30 lb";
            this.rangeSelectorControl5.Range2 = "110 lb";
            this.rangeSelectorControl5.RangeString = "Range";
            this.rangeSelectorControl5.RangeValues = null;
            this.rangeSelectorControl5.RightThumbImagePath = null;
            this.rangeSelectorControl5.Size = new System.Drawing.Size(990, 87);
            this.rangeSelectorControl5.TabIndex = 0;
            this.rangeSelectorControl5.ThumbColor = System.Drawing.Color.Black;
            this.rangeSelectorControl5.WidthOfThumb = 10F;
            this.rangeSelectorControl5.XMLFileName = null;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rangeSelectorControl6);
            this.groupBox6.Location = new System.Drawing.Point(14, 394);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1014, 138);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Slider is Image - Salary Range";
            // 
            // rangeSelectorControl6
            // 
            this.rangeSelectorControl6.BackColor = System.Drawing.SystemColors.Control;
            this.rangeSelectorControl6.DelimiterForRange = ",";
            this.rangeSelectorControl6.DisabledBarColor = System.Drawing.Color.Gray;
            this.rangeSelectorControl6.DisabledRangeLabelColor = System.Drawing.Color.Gray;
            this.rangeSelectorControl6.GapFromLeftMargin = ((uint)(20u));
            this.rangeSelectorControl6.GapFromRightMargin = ((uint)(20u));
            this.rangeSelectorControl6.HeightOfThumb = 35F;
            this.rangeSelectorControl6.InFocusBarColor = System.Drawing.Color.DarkOliveGreen;
            this.rangeSelectorControl6.InFocusRangeLabelColor = System.Drawing.Color.Green;
            this.rangeSelectorControl6.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rangeSelectorControl6.LeftThumbImagePath = "arrowleft.jpg";
            this.rangeSelectorControl6.Location = new System.Drawing.Point(11, 15);
            this.rangeSelectorControl6.MiddleBarWidth = ((uint)(2u));
            this.rangeSelectorControl6.Name = "rangeSelectorControl6";
            this.rangeSelectorControl6.OutputStringFontColor = System.Drawing.Color.Black;
            this.rangeSelectorControl6.Range1 = "Good";
            this.rangeSelectorControl6.Range2 = "Great";
            this.rangeSelectorControl6.RangeString = "Range";
            this.rangeSelectorControl6.RangeValues = "100K,400K,800K,Good,900K,1Million,Great,10 M,1 B";
            this.rangeSelectorControl6.RightThumbImagePath = "arrow.jpg";
            this.rangeSelectorControl6.Size = new System.Drawing.Size(973, 116);
            this.rangeSelectorControl6.TabIndex = 0;
            this.rangeSelectorControl6.ThumbColor = System.Drawing.Color.Purple;
            this.rangeSelectorControl6.WidthOfThumb = 10F;
            this.rangeSelectorControl6.XMLFileName = null;
            // 
            // rangeSelectorControl7
            // 
            this.rangeSelectorControl7.BackColor = System.Drawing.Color.LightBlue;
            this.rangeSelectorControl7.DelimiterForRange = ",";
            this.rangeSelectorControl7.DisabledBarColor = System.Drawing.Color.Gray;
            this.rangeSelectorControl7.DisabledRangeLabelColor = System.Drawing.Color.Gray;
            this.rangeSelectorControl7.GapFromLeftMargin = ((uint)(10u));
            this.rangeSelectorControl7.GapFromRightMargin = ((uint)(10u));
            this.rangeSelectorControl7.HeightOfThumb = 20F;
            this.rangeSelectorControl7.InFocusBarColor = System.Drawing.Color.Magenta;
            this.rangeSelectorControl7.InFocusRangeLabelColor = System.Drawing.Color.Green;
            this.rangeSelectorControl7.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rangeSelectorControl7.LeftThumbImagePath = null;
            this.rangeSelectorControl7.Location = new System.Drawing.Point(164, 552);
            this.rangeSelectorControl7.MiddleBarWidth = ((uint)(3u));
            this.rangeSelectorControl7.Name = "rangeSelectorControl7";
            this.rangeSelectorControl7.OutputStringFontColor = System.Drawing.Color.Black;
            this.rangeSelectorControl7.Range1 = "0";
            this.rangeSelectorControl7.Range2 = "30";
            this.rangeSelectorControl7.RangeString = "Range";
            this.rangeSelectorControl7.RangeValues = "0,10,20,30,Good,50,60,70,Great,90,100";
            this.rangeSelectorControl7.RightThumbImagePath = null;
            this.rangeSelectorControl7.Size = new System.Drawing.Size(360, 80);
            this.rangeSelectorControl7.TabIndex = 16;
            this.rangeSelectorControl7.ThumbColor = System.Drawing.Color.Purple;
            this.rangeSelectorControl7.WidthOfThumb = 10F;
            this.rangeSelectorControl7.XMLFileName = null;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(143, 648);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_Start.TabIndex = 17;
            // 
            // dateTimePicker_Stop
            // 
            this.dateTimePicker_Stop.Location = new System.Drawing.Point(349, 648);
            this.dateTimePicker_Stop.Name = "dateTimePicker_Stop";
            this.dateTimePicker_Stop.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_Stop.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TestApp
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(875, 698);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker_Stop);
            this.Controls.Add(this.dateTimePicker_Start);
            this.Controls.Add(this.rangeSelectorControl7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "TestApp";
            this.Text = "Test Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TestApp_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new TestApp());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			timer1.Interval = 250;
			objNotifyClient = new CustomRangeSelectorControl.NotifyClient();
			
			rangeSelectorControl1.RegisterForChangeEvent(ref objNotifyClient);

			textBox2.Text = objNotifyClient.Range1 + " to " + objNotifyClient.Range2;
			textBox2.Update();

            InitTestRangSelector();
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			string strRange1;
			string strRange2;

			
//			userControl11.QueryRange(out strRange1, out strRange2);
						rangeSelectorControl1.QueryRange(out strRange1 , out strRange2);
			textBox1.Text = strRange1 + " - " + strRange2;
			textBox1.Update();

			object obj = strRange1;
			strRange1 = "100";
		}

		private void TestApp_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		
		}

		private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			textBox2.Text = objNotifyClient.Range1 + " to " + objNotifyClient.Range2;
			textBox2.Update();
		
		}

		private void rangeSelectorControl1_Load(object sender, System.EventArgs e)
		{
		
		}


        private void InitTestRangSelector()
        {
            rangeSelectorControl7.RangeValues = "12:00:00,12:00:20,17/10/10\n12:00:40,12:01:00,12:01:20";
            rangeSelectorControl7.Range1 = "12:00:20";
            rangeSelectorControl7.Range2 = "12:01:00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rangeSelectorControl7.RangeValues = "12:00:00,12:00:20,12:00:40,12:01:00,12:01:20,12:01:40";
            rangeSelectorControl7.Range1 = "12:00:40";
            rangeSelectorControl7.Range2 = "12:01:20";
        }
             
	}
}
