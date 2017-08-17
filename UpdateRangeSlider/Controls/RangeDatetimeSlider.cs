using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UpdateRangeSlider.Controls
{
    //  该控件参考来源： https://www.codeproject.com/Articles/28717/A-custom-range-selector-control-in-C-with-a-little 

    [ToolboxBitmap(typeof(UpdateRangeSlider.Controls.RangeDatetimeSlider), "RangeScale.bmp")]
    public partial class RangeDatetimeSlider : UserControl
    {

        #region Design Time Control Variables -- Private Variables

        private Font fntLabelFont;					// Font of the Label
        private FontStyle fntLabelFontStyle;				// Font Style of the Label 
        private float fLabelFontSize;					// Size of the Label 
        private FontFamily fntLabelFontFamily;				// Font Family of the Label 
        private string strLeftImagePath;				// Left Thumb Image Path
        private string strRightImagePath;				// Right Thumb Image Path
        private float fHeightOfThumb;					// Height Of  the Thumb
        private float fWidthOfThumb;					// Width of the Thumb
        private Color clrThumbColor;					// Color of the Thumb, If not Image
        private Color clrInFocusBarColor;				// In Focus Bar Colour
        private Color clrDisabledBarColor;			// Disabled Bar Color
        private Color clrInFocusRangeLabelColor;		// In Focus Range Label Color
        private Color clrDisabledRangeLabelColor;		// Disabled Range label Color
        private uint unSizeOfMiddleBar;				// Thickness of the Middle bar
        private uint unGapFromLeftMargin;			// Gap from the Left Margin to draw the Bar
        private uint unGapFromRightMargin;			// Gap from the Right Margin to draw the Bar
        private DateTime dateRange1;						// Thumb 1 Position bar
        private DateTime dateRange2;						// Thumb 2 Position in the bar
        private DateTime dateStart;                    //  init start date;
        private DateTime dateStop;                    //   init stop date;         

        private Font fntRangeOutputStringFont;		// Range Output string font
        private float fStringOutputFontSize;			// String Output Font Size
        private Color clrStringOutputFontColor;		// Color of the Output Font 
        private FontFamily fntStringOutputFontFamily;		// Font Family to display the Range string

        #endregion



        #region public attribute
        /// <LabelFont>
        /// The user can specify the font to use for the labels. The Setter and getter methods are as below
        /// </Label Font>
        /// 
        public Font LabelFont
        {
            set
            {
                fntLabelFont = value;

                CalculateValues();
                this.Refresh();
                OnPaint(ePaintArgs);

            }

            get
            {
                return fntLabelFont;
            }
        }

        /// <LeftThumbImagepath>
        /// The user can specify the Left Thumb Image path to use. The Setter and getter methods are as below
        /// </LeftThumbImagePath>
        /// 

        public string LeftThumbImagePath
        {
            set
            {
                try
                {
                    strLeftImagePath = value;

                    CalculateValues();
                    this.Refresh();
                    OnPaint(ePaintArgs);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Invalid Image Path.  Please Re-Enter", "Error!");
                }
            }

            get
            {
                return strLeftImagePath;
            }
        }

        /// <RightThumbImagepath>
        /// The user can specify the Right Thumb Image path to use. The Setter and getter methods are as below
        /// </RightThumbImagePath>
        /// 

        public string RightThumbImagePath
        {
            set
            {
                try
                {
                    strRightImagePath = value;

                    CalculateValues();
                    this.Refresh();
                    OnPaint(ePaintArgs);
                }
                catch
                {
                    strRightImagePath = null;

                    System.Windows.Forms.MessageBox.Show("Invalid Image Path.  Please Re-Enter", "Error!");
                }
            }

            get
            {
                return strRightImagePath;
            }
        }


        /// <HeightOfThumb>
        /// The user can specify the Height of the Thumb Image path to use. The Setter and getter methods are as below
        /// </HeightOfThumb>
        /// 	   

        public float HeightOfThumb
        {
            set
            {
                fHeightOfThumb = value;

                CalculateValues();
                this.Refresh();
                OnPaint(ePaintArgs);
            }

            get
            {
                return fHeightOfThumb;
            }

        }

        /// <WidthOfThumb>
        /// The user can specify the Width of the Thumb Image path to use. The Setter and getter methods are as below
        /// </WidthOfThumb>
        /// 	   

        public float WidthOfThumb
        {
            set
            {
                fWidthOfThumb = value;

                CalculateValues();
                this.Refresh();
                OnPaint(ePaintArgs);
            }

            get
            {
                return fWidthOfThumb;
            }

        }

        /// <InFocusBarColor>
        /// The user can specify the Infocus Bar Color to use. The Setter and getter methods are as below
        /// </InFocusBarColor>
        /// 


        public Color InFocusBarColor
        {
            set
            {
                clrInFocusBarColor = value;

                CalculateValues();
                this.Refresh();
                OnPaint(ePaintArgs);
            }

            get
            {
                return clrInFocusBarColor;
            }

        }

        /// <DisabledBarColor>
        /// The user can specify the Disabled Bar Color to use. The Setter and getter methods are as below
        /// </DisabledBarColor>
        /// 

        public Color DisabledBarColor
        {
            set
            {
                clrDisabledBarColor = value;

                CalculateValues();
                this.Refresh();
                OnPaint(ePaintArgs);
            }

            get
            {
                return clrDisabledBarColor;
            }

        }

        /// <ThumbColor>
        /// The user can specify the Thumb Color to use. The Setter and getter methods are as below
        /// </ThumbColor>
        /// 

        public Color ThumbColor
        {
            set
            {
                clrThumbColor = value;

                CalculateValues();
                this.Refresh();
                OnPaint(ePaintArgs);
            }

            get
            {
                return clrThumbColor;

            }
        }


        /// <InFocusRangeLabelColor>
        /// The user can specify the InFocus Range Label Color to use. The Setter and getter methods are as below
        /// </InFocusRangeLabelColor>
        /// 

        public Color InFocusRangeLabelColor
        {
            set
            {
                clrInFocusRangeLabelColor = value;

                CalculateValues();
                this.Refresh();
                OnPaint(ePaintArgs);
            }

            get
            {
                return clrInFocusRangeLabelColor;
            }
        }

        /// <DisabledRangeLabelColor>
        /// The user can specify the InFocus Range Label Color to use. The Setter and getter methods are as below
        /// </DisabledRangeLabelColor>
        /// 

        public Color DisabledRangeLabelColor
        {
            set
            {
                clrDisabledRangeLabelColor = value;

                CalculateValues();
                this.Refresh();
                OnPaint(ePaintArgs);
            }

            get
            {
                return clrDisabledRangeLabelColor;
            }
        }

        /// <SizeOfMiddleBar>
        /// The user can specify the Sizeof Middle Bar to use. The Setter and getter methods are as below
        /// </SizeOfMiddleBar>
        /// 

        public uint MiddleBarWidth
        {
            set
            {
                unSizeOfMiddleBar = value;

                CalculateValues();
                this.Refresh();
                OnPaint(ePaintArgs);
            }

            get
            {
                return unSizeOfMiddleBar;
            }
        }

        /// <GapFromLeftMargin>
        /// The user can specify the Gap from Left margin. The Setter and getter methods are as below
        /// </GapFromLeftMargin>
        /// 	

        public uint GapFromLeftMargin
        {
            set
            {
                unGapFromLeftMargin = value;

                CalculateValues();
                this.Refresh();
                OnPaint(ePaintArgs);
            }

            get
            {
                return unGapFromLeftMargin;
            }
        }

        /// <GapFromRightMargin>
        /// The user can specify the Gap from Left margin. The Setter and getter methods are as below
        /// </GapFromRightMargin>
        /// 	

        public uint GapFromRightMargin
        {
            set
            {
                unGapFromRightMargin = value;

                CalculateValues();
                this.Refresh();
                OnPaint(ePaintArgs);
            }

            get
            {
                return unGapFromRightMargin;
            }
        }

        /// <Range1>
        /// The user can specify the Range1 Value. The Setter and getter methods are as below
        /// </Range1>
        /// 	

        public DateTime Range1
        {
            set
            {

                dateStart = value;
                if (strSplitLabels.Length != 0)
                {

                    dateRange1 = value;
                    CalculateValues();
                    this.Refresh();
                    OnPaint(ePaintArgs);
                }
            }

            get
            {
                return dateStart;
            }
        }

        /// <Range2>
        /// The user can specify the Range2 Value. The Setter and getter methods are as below
        /// </Range2>
        /// 	

        public DateTime Range2
        {
            set
            {
                dateStop = value;

                if (strSplitLabels.Length != 0)
                {
                    dateRange2 = value;
                    CalculateValues();
                    this.Refresh();
                    OnPaint(ePaintArgs);
                }
            }

            get
            {
                return dateStop;
            }
        }
            

        /// <OutputStringFontColor>
        /// The user can specify the Output String Font Color Value. The Setter and getter methods are as below
        /// </OutputStringFontColor>
        /// 	
        public Color OutputStringFontColor
        {
            set
            {
                clrStringOutputFontColor = value;
                CalculateValues();
                this.Refresh();
                OnPaint(ePaintArgs);
            }

            get
            {
                return clrStringOutputFontColor;
            }
        }

        /// <ControlProperties>
        /// The Above are Design time (Also Runtime) Control Variable properties.  These variables 
        /// can be used by the client to change the appearance of the control.
        /// </ControlProperties>
        /// 

        public void SetRange(DateTime startTime, DateTime stopTime)
        {
            //  startRange
            dateStart = startTime;
            //  stopRange
            dateStop = stopTime;

            if (strSplitLabels.Length != 0)
            {
                dateRange1 = startTime;
                dateRange2 = stopTime;
                CalculateValues();
                this.Refresh();
                OnPaint(ePaintArgs);
            }
        }

        #endregion


        #region Variables Used for Computation

        private Image imImageLeft;				//Variable for Left Image
        private Image imImageRight;				// Variable for Right Image
        private NotifyDatetimeClient objNotifyClient;			// This is For Client Notification object
        private bool bMouseEventThumb1;			// Variable for Thumb1Click
        private bool bMouseEventThumb2;			// Variable for Thumb2Click
        private float fThumb1Point;				// Variable to hold Mouse point on Thumb1
        private float fThumb2Point;				// Variable to hold Mouse point on Thumb2

        private float fLeftCol;					// Left Column
        private float fLeftRow;					// Left Row
        private float fRightCol;					// Right Column
        private float fRightRow;					// Right Row
        private float fTotalWidth;				// Total Width
        private float fDividedWidth;				// Divided Width

        private PaintEventArgs ePaintArgs;					// Paint Args
        private int nNumberOfLabels;			// Total Number of Labels
        private string[] strSplitLabels;				// To store the Split Labels
        private PointF[] ptThumbPoints1;				// To Store Thumb Point1
        private PointF[] ptThumbPoints2;				// To Store Thumb2 Point

        private bool bAnimateTheSlider;          // Animate the Control
        private float fThumbPoint1Prev;			// To Store Thumb Point1
        private float fThumbPoint2Prev;			// To Store Thumb2 Point

        private int nTotalLabel;                 //  Labels Total
        private int nSecondGap;                  //  Per label time second gap
        private float fTimeUnit;                   //  per pixel time second unit  (20s/1px)


        #endregion

        public RangeDatetimeSlider()
        {
            InitializeComponent();

            #region Initialization of Variables to its Default Values

            if (null != strLeftImagePath)
            {
                imImageLeft = System.Drawing.Image.FromFile(strLeftImagePath);
            }
            if (null != strRightImagePath)
            {
                imImageRight = System.Drawing.Image.FromFile(strRightImagePath);
            }
            objNotifyClient = null;
            //strRangeString = "Range";
            //strDelimiter = ",";  // Because in Germany decimal point is represented as , i.e., "10.50 in US" is "10,50 in Germany"
            //strRange = "0,10,20,30,Good,50,60,70,Great,90,100";
            //strRange1 = "10";
            //strRange2 = "90";
            strLeftImagePath = null;
            strRightImagePath = null;
            fHeightOfThumb = 20.0f;
            fWidthOfThumb = 10.0f;
            this.BackColor = System.Drawing.Color.LightBlue;
            clrInFocusBarColor = System.Drawing.Color.Magenta;
            clrDisabledBarColor = System.Drawing.Color.Gray;
            clrInFocusRangeLabelColor = System.Drawing.Color.Green;
            clrDisabledRangeLabelColor = System.Drawing.Color.Gray;
            clrThumbColor = System.Drawing.Color.Purple;
            fStringOutputFontSize = 10.0f;
            clrStringOutputFontColor = System.Drawing.Color.Black;
            fntStringOutputFontFamily = System.Drawing.FontFamily.GenericSerif;
            fntRangeOutputStringFont = new System.Drawing.Font(fntStringOutputFontFamily, fStringOutputFontSize, System.Drawing.FontStyle.Bold);

            unSizeOfMiddleBar = 3;
            unGapFromLeftMargin = 10;
            unGapFromRightMargin = 10;
            fntLabelFontFamily = System.Drawing.FontFamily.GenericSansSerif;
            fLabelFontSize = 8.25f;
            fntLabelFontStyle = System.Drawing.FontStyle.Bold;
            fntLabelFont = new System.Drawing.Font(fntLabelFontFamily, fLabelFontSize, fntLabelFontStyle);

            strSplitLabels = new string[1024];
            ptThumbPoints1 = new System.Drawing.PointF[3];
            ptThumbPoints2 = new System.Drawing.PointF[3];

            bMouseEventThumb1 = false;
            bMouseEventThumb2 = false;
            bAnimateTheSlider = false;
            #endregion

            /// <VariableInit>
            /// The Below are Initialization of Variables to its Default values.  
            /// </VariableInit>
            /// 
        }


        #region Methods Exposed to client at runtime

        /// <QueryRange>
        /// The client can query this method to get the range
        /// </QueryRange>
        /// 
        public void QueryRange(out DateTime dateGetRange1, out DateTime dateGetRange2)
        {
            dateGetRange1 = dateRange1;
            dateGetRange2 = dateRange2;
        }
        #endregion


        /// <CalculateValues>
        /// The below is the method that calculates the values to be place while painting
        /// </CalculateValues>
        /// 
        #region This is a Private method that calculates the values to be placed while painting
        private void CalculateValues()
        {
            try
            {
                // Creating the Graphics object
                System.Drawing.Graphics myGraphics = this.CreateGraphics();

                // Split the Labels to be displayed below the Bar
                //strSplitLabels = strRange.Split(strDelimiter.ToCharArray(), 1024);
                //  strSplitLabels = new String[] { Range1.ToString("yyyy-MM-dd \n HH:mm:ss"), Range2.ToString("yyyy-MM-dd \n HH:mm:ss") };
                

                // If there's an image load the Image from the file
                if (null != strLeftImagePath)
                {
                    imImageLeft = System.Drawing.Image.FromFile(strLeftImagePath);
                }
                if (null != strRightImagePath)
                {
                    imImageRight = System.Drawing.Image.FromFile(strRightImagePath);
                }

                // Calculate the Left, Right values based on the Clip region bounds
                RectangleF recRegion = myGraphics.VisibleClipBounds;
                fLeftCol = unGapFromLeftMargin;
                fLeftRow = recRegion.Height / 2.0f;  // To display the Bar in the middle
                fRightCol = recRegion.Width - unGapFromRightMargin;
                fRightRow = fLeftRow;
                fThumb1Point = fLeftCol;
                fThumb2Point = fRightCol;
                fTotalWidth = recRegion.Width - (unGapFromRightMargin + unGapFromLeftMargin);

                //fDividedWidth = fTotalWidth / (float)(nNumberOfLabels - 1);


                fDividedWidth = 80;
                if(Range1.Year > 100)
                {
                    int a = 0;
                }
                nTotalLabel = Convert.ToInt32(Math.Floor(fTotalWidth/fDividedWidth) + 1);
                strSplitLabels = new String[nTotalLabel];
                nSecondGap = Convert.ToInt32((Range2 - Range1).TotalSeconds/(nTotalLabel - 1));
                strSplitLabels[0] = Range1.ToString("yyyy-MM-dd \n HH:mm:ss");
                for (int i = 1; i < nTotalLabel; i++ )
                {
                    strSplitLabels[i] = Range1.AddSeconds(i * nSecondGap).ToString("yyyy-MM-dd \n HH:mm:ss");
                }
                strSplitLabels[nTotalLabel - 1] = Range2.ToString("yyyy-MM-dd \n HH:mm:ss");
                nNumberOfLabels = strSplitLabels.Length;
                fDividedWidth = fTotalWidth / (float)(nNumberOfLabels - 1);
                fTimeUnit = (float)((Range2 - Range1).TotalSeconds / fTotalWidth);


                int nRangeIndex1Selected = 0;
                int nRangeIndex2Selected = nNumberOfLabels - 1;

                // This is used to calculate the Thumb Point from the  Range1, Range2 Value
                //for (int nIndexer = 0; nIndexer < nNumberOfLabels; nIndexer++)
                //{
                //    if (strRange1.Equals(strSplitLabels[nIndexer]))
                //    {
                //        fThumb1Point = fLeftCol + fDividedWidth * nIndexer;
                //        nRangeIndex1Selected = nIndexer;
                //    }
                //    if (strRange2.Equals(strSplitLabels[nIndexer]))
                //    {
                //        fThumb2Point = fLeftCol + fDividedWidth * nIndexer;
                //        nRangeIndex2Selected = nIndexer;
                //    }
                //}

                if (dateRange1 == dateRange2)
                {
                    if (nRangeIndex1Selected != 0)
                    {
                        fThumb1Point -= fDividedWidth / 2.0f;
                    }
                    if (nRangeIndex2Selected != nNumberOfLabels - 1)
                    {
                        fThumb2Point += fDividedWidth / 2.0f;
                    }
                }

                // This is for Calculating the final Thumb points
                ptThumbPoints1[0].X = fThumb1Point;
                ptThumbPoints1[0].Y = fLeftRow - 3.0f;
                ptThumbPoints1[1].X = fThumb1Point;
                ptThumbPoints1[1].Y = fLeftRow - 3.0f - fHeightOfThumb;
                ptThumbPoints1[2].X = (fThumb1Point + fWidthOfThumb);
                ptThumbPoints1[2].Y = fLeftRow - 3.0f - fHeightOfThumb / 2.0f;

                ptThumbPoints2[0].X = fThumb2Point;
                ptThumbPoints2[0].Y = fRightRow - 3.0f;
                ptThumbPoints2[1].X = fThumb2Point;
                ptThumbPoints2[1].Y = fRightRow - 3.0f - fHeightOfThumb;
                ptThumbPoints2[2].X = fThumb2Point - fWidthOfThumb;
                ptThumbPoints2[2].Y = fRightRow - 3.0f - fHeightOfThumb / 2.0f;
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message + err.Source + err.StackTrace + err.TargetSite);
                //throw;
                //System.Windows.Forms.MessageBox.Show("An unexpected Error occured.  Please contact the vendor of this control", "Error");
            }
        }

        private void CalculateDateValues()
        {
            float moveSize = (fWidthOfThumb / 2.0f);

            float left = fThumb1Point - fLeftCol + moveSize;
            dateRange1 = dateStart.AddSeconds(left * fTimeUnit);
            if (dateRange1 < dateStart) { dateRange1 = dateStart; }

            float right = fThumb2Point - fRightCol - moveSize;
            dateRange2 = dateStop.AddSeconds(right * fTimeUnit);
            if (dateRange2 > dateStop) { dateRange2 = dateStop; }
        }

        /// <CalculateValues>
        /// The below is the method that calculates the values to be place while painting
        /// </CalculateValues>
        /// 
        #endregion

        private void OnPaintDrawRangeLabel(System.Drawing.Graphics myGraphics, PaintEventArgs e)
        {
            string startInfo = dateRange1.ToString("yyyy-MM-dd \n HH:mm:ss");
            string stopInfo = dateRange2.ToString("yyyy-MM-dd \n HH:mm:ss");


            float leftPos = fThumbPoint1Prev - 20;
            float rightPos = fThumbPoint2Prev - 30;
            if(bAnimateTheSlider)
            {
                leftPos = (ptThumbPoints1[0].X - 20);
                rightPos = (ptThumbPoints2[2].X - 30);
            }

            if(fThumbPoint1Prev <= 0)
            {
                leftPos = -1000000;
            }

            if (fThumbPoint2Prev <= 0)
            {
                rightPos = -1000000;
            }

            System.Drawing.SolidBrush brSolidBrush;
            brSolidBrush = new System.Drawing.SolidBrush(clrThumbColor);
            Font currentFont = new Font(fntLabelFontFamily, 7.0f, fntLabelFontStyle);
            //  draw start Label
            myGraphics.DrawString(startInfo, currentFont, brSolidBrush, leftPos, (ptThumbPoints1[2].Y - 26.0f));

            //  draw stop Label
            myGraphics.DrawString(stopInfo, currentFont, brSolidBrush, rightPos, (ptThumbPoints2[2].Y - 26.0f));

            CalculateDateValues();
        }

        private void OnPaintDrawSliderAndBar(System.Drawing.Graphics myGraphics, PaintEventArgs e)
        {
            System.Drawing.Brush brSolidBrush;
            System.Drawing.Pen myPen;

            // If Interesting mouse event happened on the Thumb1 Draw Thumb1
            if (bMouseEventThumb1)
            {
                brSolidBrush = new System.Drawing.SolidBrush(this.BackColor);
                if (null != strLeftImagePath)
                {
                    myGraphics.FillRectangle(brSolidBrush, ptThumbPoints1[0].X, ptThumbPoints1[1].Y, fWidthOfThumb, fHeightOfThumb);
                }
                else
                {
                    PointF[] tempThumb1PT = new PointF[3];
                    float moveSize = (fWidthOfThumb / 2.0f);
                    tempThumb1PT[0] = new PointF((ptThumbPoints1[0].X - moveSize), ptThumbPoints1[0].Y);
                    tempThumb1PT[1] = new PointF((ptThumbPoints1[1].X - moveSize), ptThumbPoints1[1].Y);
                    tempThumb1PT[2] = new PointF((ptThumbPoints1[2].X - moveSize), ptThumbPoints1[2].Y);

                    myGraphics.FillClosedCurve(brSolidBrush, tempThumb1PT, System.Drawing.Drawing2D.FillMode.Winding, 0f);
                }
            }
            //if interesting mouse event happened on Thumb2 draw thumb2
            if (bMouseEventThumb2)
            {
                brSolidBrush = new System.Drawing.SolidBrush(this.BackColor);

                if (null != strRightImagePath)
                {
                    myGraphics.FillRectangle(brSolidBrush, ptThumbPoints2[2].X, ptThumbPoints2[1].Y, fWidthOfThumb, fHeightOfThumb);
                }
                else
                {
                    PointF[] tempThumb2PT = new PointF[3];
                    float moveSize = (fWidthOfThumb / 2.0f);
                    tempThumb2PT[0] = new PointF((ptThumbPoints2[0].X + moveSize), ptThumbPoints2[0].Y);
                    tempThumb2PT[1] = new PointF((ptThumbPoints2[1].X + moveSize), ptThumbPoints2[1].Y);
                    tempThumb2PT[2] = new PointF((ptThumbPoints2[2].X + moveSize), ptThumbPoints2[2].Y);
                    myGraphics.FillClosedCurve(brSolidBrush, ptThumbPoints2, System.Drawing.Drawing2D.FillMode.Winding, 0f);
                }
            }

            // The Below lines are to draw the Thumb and the Lines 
            // The Infocus and the Disabled colors are drawn properly based
            // onthe  calculated values
            brSolidBrush = new System.Drawing.SolidBrush(clrInFocusRangeLabelColor);
            myPen = new System.Drawing.Pen(clrInFocusRangeLabelColor, unSizeOfMiddleBar);

            ptThumbPoints1[0].X = fThumb1Point;
            ptThumbPoints1[1].X = fThumb1Point;
            ptThumbPoints1[2].X = fThumb1Point + fWidthOfThumb;

            ptThumbPoints2[0].X = fThumb2Point;
            ptThumbPoints2[1].X = fThumb2Point;
            ptThumbPoints2[2].X = fThumb2Point - fWidthOfThumb;

            myPen = new System.Drawing.Pen(clrDisabledBarColor, unSizeOfMiddleBar);
            myGraphics.DrawLine(myPen, fLeftCol, ptThumbPoints1[2].Y, fThumb1Point, ptThumbPoints1[2].Y);

            //  两端
            //myGraphics.DrawLine(myPen, fLeftCol, ptThumbPoints1[2].Y, fLeftCol, ptThumbPoints1[2].Y + fntLabelFont.SizeInPoints);
            //myGraphics.DrawLine(myPen, fRightCol, ptThumbPoints1[2].Y, fRightCol, ptThumbPoints1[2].Y + fntLabelFont.SizeInPoints);

            //brSolidBrush = new System.Drawing.SolidBrush(clrStringOutputFontColor);
            //myGraphics.DrawString(strRangeString, fntRangeOutputStringFont, brSolidBrush, fLeftCol, fLeftRow * 2 - fntRangeOutputStringFont.Size - 3);

            myPen = new System.Drawing.Pen(clrInFocusBarColor, unSizeOfMiddleBar);
            myGraphics.DrawLine(myPen, ptThumbPoints1[2].X, ptThumbPoints1[2].Y, fThumb2Point,/* - fWidthOfThumb*/ ptThumbPoints1[2].Y);

            myPen = new System.Drawing.Pen(clrDisabledBarColor, unSizeOfMiddleBar);
            myGraphics.DrawLine(myPen, fThumb2Point, ptThumbPoints2[2].Y, fRightCol, ptThumbPoints2[2].Y);

            // If the Thumb is an Image it draws the Image or else it draws the Thumb
            if (null != strLeftImagePath)
            {
                myGraphics.DrawImage(imImageLeft, ptThumbPoints1[0].X, ptThumbPoints1[1].Y, fWidthOfThumb, fHeightOfThumb);
            }
            else
            {
                brSolidBrush = new System.Drawing.SolidBrush(clrThumbColor);
                //  myGraphics.FillClosedCurve(brSolidBrush, ptThumbPoints1, System.Drawing.Drawing2D.FillMode.Winding, 0f);
                myGraphics.FillEllipse(brSolidBrush, (ptThumbPoints1[0].X), (ptThumbPoints1[2].Y - fWidthOfThumb / 2), 10, 10);
            }

            // If the Thumb is an Image it draws the Image or else it draws the Thumb
            if (null != strRightImagePath)
            {
                myGraphics.DrawImage(imImageRight, ptThumbPoints2[2].X, ptThumbPoints2[1].Y, fWidthOfThumb, fHeightOfThumb);
            }
            else
            {
                brSolidBrush = new System.Drawing.SolidBrush(clrThumbColor);
                myGraphics.FillEllipse(brSolidBrush, (ptThumbPoints2[2].X), (ptThumbPoints2[2].Y - fWidthOfThumb / 2), 10, 10);
            }

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                // Declaration of the local variables that are used.
                System.Drawing.Brush brSolidBrush;
                float fDividerCounter;
                float fIsThumb1Crossed, fIsThumb2Crossed;
                string strRangeOutput;
                DateTime dateNewRange1, dateNewRange2;

                // Initialization of the local variables.
                System.Drawing.Graphics myGraphics = this.CreateGraphics();
                ePaintArgs = e;
                fDividerCounter = 0;
                brSolidBrush = new System.Drawing.SolidBrush(clrDisabledRangeLabelColor);
                dateNewRange1 = new DateTime();
                dateNewRange2 = new DateTime();

                // This loop is to draw the Labels on the screen.
                for (int nIndexer = 0; nIndexer < nNumberOfLabels; nIndexer++)
                {
                    fDividerCounter = fLeftCol + fDividedWidth * nIndexer - 20;
                    fIsThumb1Crossed = fDividerCounter + strSplitLabels[nIndexer].Length * fntLabelFont.SizeInPoints / 2;
                    fIsThumb2Crossed = fDividerCounter - (strSplitLabels[nIndexer].Length - 1) * fntLabelFont.SizeInPoints / 2;


                    brSolidBrush = new System.Drawing.SolidBrush(clrInFocusRangeLabelColor);
                    //if (fIsThumb1Crossed >= fThumb1Point && dateNewRange1.Year <= 10)
                    //{
                    //    // If Thumb1 Crossed this Label Make it in Focus color
                    //    brSolidBrush = new System.Drawing.SolidBrush(clrInFocusRangeLabelColor);
                    //}
                    //if (fIsThumb2Crossed > fThumb2Point)
                    //{
                    //    // If Thumb2 crossed this draw the labes following this in disabled color
                    //    brSolidBrush = new System.Drawing.SolidBrush(clrDisabledRangeLabelColor);
                    //    //strNewRange2	= strSplitLabels[nIndexer];
                    //}

                    //myGraphics.DrawString(strSplitLabels[nIndexer], fntLabelFont, brSolidBrush, fDividerCounter - ((fntLabelFont.SizeInPoints) * strSplitLabels[nIndexer].Length) / 2, fLeftRow);
                    myGraphics.DrawString(strSplitLabels[nIndexer], fntLabelFont, brSolidBrush, fDividerCounter - ((fntLabelFont.SizeInPoints) * strSplitLabels[nIndexer].Length) / 10, fLeftRow);
                }

                //  This loop is to draw label split line on the screen
                for (int nIndexer = 1; nIndexer < (nNumberOfLabels - 1); nIndexer++)
                {
                    fDividerCounter = fLeftCol + fDividedWidth * (nIndexer);
                    brSolidBrush = new System.Drawing.SolidBrush(clrDisabledRangeLabelColor);
                    Pen pen = new Pen(brSolidBrush, 2.0f);
                    PointF pfStart = new PointF(fDividerCounter, (fLeftRow - 18.0f ));
                    PointF pfStop = new PointF(fDividerCounter, (fLeftRow - 14.0f));
                    myGraphics.DrawLine(pen, pfStart, pfStop);
                }
                
                if (bAnimateTheSlider)
                {
                    float fTempThumb1Point = fThumb1Point;
                    float fTempThumb2Point = fThumb2Point;
                    int nToMakeItTimely = System.Environment.TickCount;

                    for (fThumb1Point = fThumbPoint1Prev, fThumb2Point = fThumbPoint2Prev;
                        fThumb1Point <= fTempThumb1Point || fThumb2Point >= fTempThumb2Point;
                        fThumb1Point += 3.0f, fThumb2Point -= 3.0f)
                    {
                        bMouseEventThumb1 = true;
                        bMouseEventThumb2 = true;

                        if (fThumb1Point > fTempThumb1Point)
                        {
                            fThumb1Point = fTempThumb1Point;
                        }

                        if (fThumb2Point < fTempThumb2Point)
                        {
                            fThumb2Point = fTempThumb2Point;
                        }

                        OnPaintDrawSliderAndBar(myGraphics, e);
                        if (System.Environment.TickCount - nToMakeItTimely >= 1000)
                        {
                            // Hey its not worth having animation for more than 1 sec.  
                            break;
                        }
                        System.Threading.Thread.Sleep(1);
                    }

                    fThumb1Point = fTempThumb1Point;
                    fThumb2Point = fTempThumb2Point;
                    bMouseEventThumb1 = true;
                    bMouseEventThumb2 = true;
                    OnPaintDrawSliderAndBar(myGraphics, e);

                    bAnimateTheSlider = false;
                    bMouseEventThumb1 = false;
                    bMouseEventThumb2 = false;
                    OnPaintDrawSliderAndBar(myGraphics, e);
                }
                else
                {
                    OnPaintDrawSliderAndBar(myGraphics, e);
                }

                OnPaintDrawRangeLabel(myGraphics, e);
                // calling the base class.
                base.OnPaint(e);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message + err.Source + err.StackTrace + err.TargetSite);
                //System.Windows.Forms.MessageBox.Show("An Unexpected Error occured. Please contact the tool vendor", "Error!");
                //throw;
            }
        }

        //  Control Events
        #region Methods used for handling Mouse Events
        public delegate void RangeChangeDelegate(object sender, EventArgs e);

        public event RangeChangeDelegate RangeChange;

        #endregion

        //  System Event

        private void RangeDatetimeSlider_Load(object sender, EventArgs e)
        {

        }

        private void RangeDatetimeSlider_Resize(object sender, EventArgs e)
        {
            CalculateValues();
            this.Refresh();
            OnPaint(ePaintArgs);
        }

        //  Mouse Event
        private void RangeDatetimeSlider_MouseDown(object sender, MouseEventArgs e)
        {
            // If the Mouse is Down and also on the Thumb1
            if (e.X >= ptThumbPoints1[0].X && e.X <= ptThumbPoints1[2].X &&
                e.Y >= ptThumbPoints1[1].Y && e.Y <= ptThumbPoints1[0].Y)
            {
                bMouseEventThumb1 = true;
            }
            // Else If the Mouse is Down and also on the Thumb2
            else if (e.X >= ptThumbPoints2[2].X && e.X <= ptThumbPoints2[0].X &&
                e.Y >= ptThumbPoints2[1].Y && e.Y <= ptThumbPoints2[0].Y)
            {
                bMouseEventThumb2 = true;
            }
            bAnimateTheSlider = false;
        }

        private void RangeDatetimeSlider_MouseUp(object sender, MouseEventArgs e)
        {
            // If the Mouse is Up then set the Event to false
            bMouseEventThumb1 = false;
            bMouseEventThumb2 = false;

            // Storing these values for animating the slider
            fThumbPoint1Prev = fThumb1Point;
            fThumbPoint2Prev = fThumb2Point;

            //  CalculateValues();
            bAnimateTheSlider = true;
            this.Refresh();

            try
            {
                RangeChange(this, EventArgs.Empty);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void RangeDatetimeSlider_MouseMove(object sender, MouseEventArgs e)
        {
            float moveSize = (fWidthOfThumb / 2.0f);

            // If the Mouse is moved pressing the left button on Thumb1
            if (bMouseEventThumb1 && e.Button == System.Windows.Forms.MouseButtons.Left && e.X >= (fLeftCol - moveSize))
            {
                // The below code is for handlling the Thumb1 Point
                if (dateRange1.Equals(dateRange2))
                {
                    if (e.X < fThumb1Point)
                    {
                        fThumb1Point = e.X;
                        OnPaint(ePaintArgs);
                    }
                }
                else if (fThumb2Point - fWidthOfThumb - moveSize > e.X)
                {
                    fThumb1Point = e.X;
                    OnPaint(ePaintArgs);
                }
                else
                {
                    bMouseEventThumb1 = false;
                }
            }
            //Else If the Mouse is moved pressing the left button on Thumb2
            else if (bMouseEventThumb2 && e.Button == System.Windows.Forms.MouseButtons.Left && e.X <= (fRightCol + moveSize))
            {
                // The below code is for handlling the Thumb1 Point
                if (dateRange1.Equals(dateRange2))
                {
                    if (e.X > fThumb2Point)
                    {
                        fThumb2Point = e.X;
                        OnPaint(ePaintArgs);
                    }
                }
                else if (fThumb1Point + fWidthOfThumb + moveSize < e.X)
                {
                    fThumb2Point = e.X;
                    OnPaint(ePaintArgs);
                }
                else
                {
                    bMouseEventThumb2 = false;
                }
            }

            // If there is an Object Notification
            if (null != objNotifyClient)
            {
                objNotifyClient.Range1 = dateRange1;
                objNotifyClient.Range2 = dateRange2;
            }
        }


        /// <RangeSelectorControl_Resize>
        /// The below is the small Notification class that can be used by the client
        /// </RangeSelectorControl_Resize>
        /// 
        #region Notification class for client to register with the control for changes

        public class NotifyDatetimeClient
        {
            private DateTime strRange1, strRange2;

            public DateTime Range1
            {
                set
                {
                    strRange1 = value;

                }

                get
                {
                    return strRange1;
                }
            }

            public DateTime Range2
            {
                set
                {
                    strRange2 = value;
                }

                get
                {
                    return strRange2;
                }
            }
        }

        /// <RangeSelectorControl_Resize>
        /// The Above is the small Notification class that can be used by the client
        /// </RangeSelectorControl_Resize>
        /// 

        #endregion
    }
}
