using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double LongBottomBase;
        double WidthBottomBase;
        double LongUpperBase;
        double WidthUpperBase;
        double OffsetLong;
        double OffsetWidth;
        double Height;

        private void ReadTextBox()//считываем с формы и Convert.ToDouble
        {
            LongBottomBase = Convert.ToDouble(textBoxLongBottomBase.Text);
            WidthBottomBase = Convert.ToDouble(textBoxWidthBottomBase.Text);
            LongUpperBase = Convert.ToDouble(textBoxLongUpperBase.Text);
            WidthUpperBase = Convert.ToDouble(textBoxWidthUpperBase.Text);
            OffsetLong = Convert.ToDouble(textBoxOffsetLong.Text);
            OffsetWidth = Convert.ToDouble(textBoxOffsetWidth.Text);
            Height = Convert.ToDouble(textBoxHeight.Text);
        }       
    }
}
