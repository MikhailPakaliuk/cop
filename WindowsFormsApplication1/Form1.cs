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

        public double LongBottomBase;
        public double WidthBottomBase;
        public double LongUpperBase;
        public double WidthUpperBase;
        public double OffsetLong;
        public double OffsetWidth;
        public double HeightPiramide;

        private void ReadTextBox()//считываем с формы и Convert.ToDouble
        {
            LongBottomBase = Convert.ToDouble(textBoxLongBottomBase.Text);
            WidthBottomBase = Convert.ToDouble(textBoxWidthBottomBase.Text);
            LongUpperBase = Convert.ToDouble(textBoxLongUpperBase.Text);
            WidthUpperBase = Convert.ToDouble(textBoxWidthUpperBase.Text);
            OffsetLong = Convert.ToDouble(textBoxOffsetLong.Text);
            OffsetWidth = Convert.ToDouble(textBoxOffsetWidth.Text);
            HeightPiramide = Convert.ToDouble(textBoxHeight.Text);
        }

        private void MakeTextBox(Model obj)// Convert.ToString выводим на фарму 
        {
            textBoxAB.Text = Convert.ToString(LongBottomBase);//блок вывода нижнего основания 
            textBoxBC.Text = Convert.ToString(WidthBottomBase);
            textBoxCD.Text = Convert.ToString(LongBottomBase);
            textBoxDA.Text = Convert.ToString(WidthBottomBase);

            textBoxA1A.Text = Convert.ToString(Math.Round(obj.SouthWest,4));//блок вывода левого! ребра
            textBoxB1B.Text = Convert.ToString(Math.Round(obj.SouthEast,4));
            textBoxC1C.Text = Convert.ToString(Math.Round(obj.NorthEast,4));
            textBoxD1D.Text = Convert.ToString(Math.Round(obj.NorthWest,4));

            textBoxA1B1.Text = Convert.ToString(LongUpperBase);// блок  вывода верхнего основания
            textBoxB1C1.Text = Convert.ToString(WidthUpperBase);
            textBoxC1D1.Text = Convert.ToString(LongUpperBase);
            textBoxD1A1.Text = Convert.ToString(WidthUpperBase);

            textBoxK1K.Text = Convert.ToString(Math.Round(obj.South,4));//блок вывода высоты трапеции
            textBoxL1L.Text = Convert.ToString(Math.Round(obj.East,4));
            textBoxM1M.Text = Convert.ToString(Math.Round(obj.North,4));
            textBoxN1N.Text = Convert.ToString(Math.Round(obj.West,4));

        }

        private Model GetValues()//получаем с модели вычисленные параметры
        {
            Model obj = new Model(LongBottomBase, WidthBottomBase, LongUpperBase, WidthUpperBase, OffsetLong, OffsetWidth, HeightPiramide);
            return obj;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ReadTextBox();
            MakeTextBox(GetValues());
            pictureBoxPiramide.Visible = false;
            DrawRectangle();

        }

        private void DrawRectangle()//рисуем на форме пирамиду, вид сверху
        {
            int halfPoint11 = 12;
            int halfPoint12 = 12;
            int halfPoint21 = 390;
            int halfPoint22 = Convert.ToInt16(Math.Truncate(halfPoint21 * WidthBottomBase / LongBottomBase));
            //посволяет рисовать пропорционально входным данным
            int halfPoint31 = Convert.ToInt16(Math.Truncate(halfPoint21 * OffsetLong / LongBottomBase));
            int halfPoint32 = Convert.ToInt16(Math.Truncate(halfPoint22 * OffsetWidth / WidthBottomBase));
            int halfPoint41 = Convert.ToInt16(Math.Truncate(halfPoint21 * LongUpperBase / LongBottomBase));
            int halfPoint42 = Convert.ToInt16(Math.Truncate(halfPoint22 * WidthUpperBase / WidthBottomBase));

            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            formGraphics.DrawRectangle(myPen, new Rectangle(halfPoint11, halfPoint12, halfPoint21, halfPoint22));//прямоугольник
            formGraphics.DrawRectangle(myPen, new Rectangle(halfPoint31, halfPoint32, halfPoint41, halfPoint42));

            formGraphics.DrawLine(myPen, halfPoint11, halfPoint12, halfPoint31, halfPoint32); //линия nw
            formGraphics.DrawLine(myPen, halfPoint21 + halfPoint11, halfPoint12, halfPoint31 + halfPoint41, halfPoint32);//ne
            formGraphics.DrawLine(myPen, halfPoint31, halfPoint32 + halfPoint42, halfPoint11, halfPoint22 + halfPoint12);//sw
            formGraphics.DrawLine(myPen, halfPoint31 + halfPoint41, halfPoint32 + halfPoint42, halfPoint21 + halfPoint11, halfPoint22 + halfPoint12);//se
            myPen.Dispose();
            formGraphics.Dispose();
            //Point[] myPointArray = { new Point(0, 0), new Point(50, 30), new Point(30, 60) };//треугольник
            //formGraphics.DrawPolygon(myPen, myPointArray);
        }
    }
}
