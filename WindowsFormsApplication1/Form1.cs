using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        Graphics formGraphics;

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

        private void MakeTextBox(Model obj)// Convert.ToString выводим на форму 
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

            textBoxB1Ba.Text = textBoxB1B.Text;//блок вывода правого! ребра
            textBoxC1Cb.Text = textBoxC1C.Text;
            textBoxD1Dc.Text = textBoxD1D.Text;
            textBoxA1Ad.Text = textBoxA1A.Text;

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
            labelTitle.Visible = true;
            tabControl1.SelectTab(tabPage2);
            DrawRectangle();
            //DrawVerticalString();

        }

        private void DrawRectangle()//рисуем на форме пирамиду, вид сверху
        {
            int halfPoint11 = 12;
            int halfPoint12 = 25;
            int halfPoint21 = 390;          //5 строк ниже позволяют рисовать пропорционально входным данным
            int halfPoint22 = Convert.ToInt16(Math.Truncate(halfPoint21 * WidthBottomBase / LongBottomBase));
            int halfPoint31 = Convert.ToInt16(Math.Truncate(halfPoint21 * OffsetLong / LongBottomBase)) + halfPoint11;
            int halfPoint32 = Convert.ToInt16(Math.Truncate(halfPoint22 * OffsetWidth / WidthBottomBase)) + halfPoint12;
            int halfPoint41 = Convert.ToInt16(Math.Truncate(halfPoint21 * LongUpperBase / LongBottomBase));
            int halfPoint42 = Convert.ToInt16(Math.Truncate(halfPoint22 * WidthUpperBase / WidthBottomBase));

            Pen myPen = new Pen(Color.Black);
            formGraphics = CreateGraphics();
            //рисуем два прямоугольника прямоугольник
            formGraphics.DrawRectangle(myPen, new Rectangle(halfPoint11, halfPoint12, halfPoint21, halfPoint22));
            formGraphics.DrawRectangle(myPen, new Rectangle(halfPoint31, halfPoint32, halfPoint41, halfPoint42));
            //рисуем боковые рёбра пирамиды
            formGraphics.DrawLine(myPen, halfPoint11, halfPoint12, halfPoint31, halfPoint32); //nw
            formGraphics.DrawLine(myPen, halfPoint21 + halfPoint11, halfPoint12, halfPoint31 + halfPoint41, halfPoint32);//ne
            formGraphics.DrawLine(myPen, halfPoint31, halfPoint32 + halfPoint42, halfPoint11, halfPoint22 + halfPoint12);//sw
            formGraphics.DrawLine(myPen, halfPoint31 + halfPoint41, halfPoint32 + halfPoint42, halfPoint21 + halfPoint11, halfPoint22 + halfPoint12);//se
            //рисуем высоты боковых граней пирамиды 
            formGraphics.DrawLine(myPen, halfPoint31 + halfPoint41 / 2, halfPoint32, halfPoint31 + halfPoint41 / 2, halfPoint12);//n
            formGraphics.DrawLine(myPen, halfPoint31 + halfPoint41 / 2, halfPoint32 + halfPoint42, halfPoint31 + halfPoint41 / 2, halfPoint12 + halfPoint22);//s
            formGraphics.DrawLine(myPen, halfPoint31, halfPoint32 + halfPoint42 / 2, halfPoint11, halfPoint32 + halfPoint42 / 2);//w
            formGraphics.DrawLine(myPen, halfPoint31 + halfPoint41, halfPoint32 + halfPoint42 / 2, halfPoint11 + halfPoint21, halfPoint32 + halfPoint42 / 2);//e
           
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            //рисуем название точек пересечения рёбер пирамиды 
            formGraphics.DrawString("A", drawFont, drawBrush, new Point(halfPoint11, halfPoint12));
            formGraphics.DrawString("B", drawFont, drawBrush, new Point(halfPoint21-halfPoint11, halfPoint12));
            formGraphics.DrawString("C", drawFont, drawBrush, new Point(halfPoint21 - halfPoint11, halfPoint22));
            formGraphics.DrawString("D", drawFont, drawBrush, new Point(halfPoint11, halfPoint22));

            formGraphics.DrawString("A1", drawFont, drawBrush, new Point(halfPoint31, halfPoint32));
            formGraphics.DrawString("B1", drawFont, drawBrush, new Point(halfPoint31 + halfPoint41, halfPoint32));
            formGraphics.DrawString("C1", drawFont, drawBrush, new Point(halfPoint31 + halfPoint41, halfPoint32+ halfPoint42));
            formGraphics.DrawString("D1", drawFont, drawBrush, new Point(halfPoint31, halfPoint32 + halfPoint42));

            formGraphics.DrawString("K", drawFont, drawBrush, new Point(halfPoint31 + halfPoint41 / 2, halfPoint12));
            formGraphics.DrawString("L", drawFont, drawBrush, new Point(halfPoint31 + halfPoint41, halfPoint32 + halfPoint42/2));
            formGraphics.DrawString("M", drawFont, drawBrush, new Point(halfPoint31 + halfPoint41 / 2,halfPoint22));
            formGraphics.DrawString("N", drawFont, drawBrush, new Point(halfPoint11, halfPoint32 + halfPoint42 / 2));

            formGraphics.DrawString("K1", drawFont, drawBrush, new Point(halfPoint31 + halfPoint41 / 2, halfPoint32));
            formGraphics.DrawString("L1", drawFont, drawBrush, new Point(halfPoint21 - halfPoint11, halfPoint32 + halfPoint42 / 2));
            formGraphics.DrawString("M1", drawFont, drawBrush, new Point(halfPoint31 + halfPoint41 / 2, halfPoint32 + halfPoint42));
            formGraphics.DrawString("N1", drawFont, drawBrush, new Point(halfPoint31, halfPoint32 + halfPoint42 / 2));
            //formGraphics.Clear(Color.White);
            //myPen.Dispose();
            //formGraphics.Dispose();

            //Point[] myPointArray = { new Point(0, 0), new Point(50, 30), new Point(30, 60) };//треугольник
            //formGraphics.DrawPolygon(myPen, myPointArray);
        }

        public void DrawVerticalString()
        {
            Graphics fGraphics = CreateGraphics();
            string drawString = "Sample Text";
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 150.0F;
            float y = 50.0F;
            StringFormat drawFormat = new StringFormat();
            //drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            fGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            fGraphics.Dispose();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
            labelTitle.Visible = false;
            pictureBoxPiramide.Visible = true;
            formGraphics.Clear(Color.White);
            formGraphics.Dispose();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs ev)
        {
            //Bitmap df = new Bitmap(900,600,formGraphics);
            //Pen myPen = new Pen(Color.Black);
            //ev.Graphics.DrawRectangle(myPen, new Rectangle(10,20,30,50));

            int halfPoint11 = 12;
            int halfPoint12 = 25;
            int halfPoint21 = 800;          //5 строк ниже позволяют рисовать пропорционально входным данным
            int halfPoint22 = Convert.ToInt16(Math.Truncate(halfPoint21 * WidthBottomBase / LongBottomBase));
            int halfPoint31 = Convert.ToInt16(Math.Truncate(halfPoint21 * OffsetLong / LongBottomBase)) + halfPoint11;
            int halfPoint32 = Convert.ToInt16(Math.Truncate(halfPoint22 * OffsetWidth / WidthBottomBase)) + halfPoint12;
            int halfPoint41 = Convert.ToInt16(Math.Truncate(halfPoint21 * LongUpperBase / LongBottomBase));
            int halfPoint42 = Convert.ToInt16(Math.Truncate(halfPoint22 * WidthUpperBase / WidthBottomBase));

            Pen myPen = new Pen(Color.Black);
           // formGraphics = CreateGraphics();
            //рисуем два прямоугольника прямоугольник
            ev.Graphics.DrawRectangle(myPen, new Rectangle(halfPoint11, halfPoint12, halfPoint21, halfPoint22));
            ev.Graphics.DrawRectangle(myPen, new Rectangle(halfPoint31, halfPoint32, halfPoint41, halfPoint42));
            //рисуем боковые рёбра пирамиды
            ev.Graphics.DrawLine(myPen, halfPoint11, halfPoint12, halfPoint31, halfPoint32); //nw
            ev.Graphics.DrawLine(myPen, halfPoint21 + halfPoint11, halfPoint12, halfPoint31 + halfPoint41, halfPoint32);//ne
            ev.Graphics.DrawLine(myPen, halfPoint31, halfPoint32 + halfPoint42, halfPoint11, halfPoint22 + halfPoint12);//sw
            ev.Graphics.DrawLine(myPen, halfPoint31 + halfPoint41, halfPoint32 + halfPoint42, halfPoint21 + halfPoint11, halfPoint22 + halfPoint12);//se
            //рисуем высоты боковых граней пирамиды 
            ev.Graphics.DrawLine(myPen, halfPoint31 + halfPoint41 / 2, halfPoint32, halfPoint31 + halfPoint41 / 2, halfPoint12);//n
            ev.Graphics.DrawLine(myPen, halfPoint31 + halfPoint41 / 2, halfPoint32 + halfPoint42, halfPoint31 + halfPoint41 / 2, halfPoint12 + halfPoint22);//s
            ev.Graphics.DrawLine(myPen, halfPoint31, halfPoint32 + halfPoint42 / 2, halfPoint11, halfPoint32 + halfPoint42 / 2);//w
            ev.Graphics.DrawLine(myPen, halfPoint31 + halfPoint41, halfPoint32 + halfPoint42 / 2, halfPoint11 + halfPoint21, halfPoint32 + halfPoint42 / 2);//e

            Font drawFont = new Font("Arial", 20);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            ev.Graphics.DrawString("A", drawFont, drawBrush, new Point(halfPoint11, halfPoint12));
            ev.Graphics.DrawString("B", drawFont, drawBrush, new Point(halfPoint21 - halfPoint11, halfPoint12));
            ev.Graphics.DrawString("C", drawFont, drawBrush, new Point(halfPoint21 - halfPoint11, halfPoint22));
            ev.Graphics.DrawString("D", drawFont, drawBrush, new Point(halfPoint11, halfPoint22));

            ev.Graphics.DrawString("A1", drawFont, drawBrush, new Point(halfPoint31, halfPoint32));
            ev.Graphics.DrawString("B1", drawFont, drawBrush, new Point(halfPoint31 + halfPoint41, halfPoint32));
            ev.Graphics.DrawString("C1", drawFont, drawBrush, new Point(halfPoint31 + halfPoint41, halfPoint32 + halfPoint42));
            ev.Graphics.DrawString("D1", drawFont, drawBrush, new Point(halfPoint31, halfPoint32 + halfPoint42));

            ev.Graphics.DrawString("K", drawFont, drawBrush, new Point(halfPoint31 + halfPoint41 / 2, halfPoint12));
            ev.Graphics.DrawString("L", drawFont, drawBrush, new Point(halfPoint31 + halfPoint41, halfPoint32 + halfPoint42 / 2));
            ev.Graphics.DrawString("M", drawFont, drawBrush, new Point(halfPoint31 + halfPoint41 / 2, halfPoint22));
            ev.Graphics.DrawString("N", drawFont, drawBrush, new Point(halfPoint11, halfPoint32 + halfPoint42 / 2));

            ev.Graphics.DrawString("K1", drawFont, drawBrush, new Point(halfPoint31 + halfPoint41 / 2, halfPoint32));
            ev.Graphics.DrawString("L1", drawFont, drawBrush, new Point(halfPoint21 - halfPoint11, halfPoint32 + halfPoint42 / 2));
            ev.Graphics.DrawString("M1", drawFont, drawBrush, new Point(halfPoint31 + halfPoint41 / 2, halfPoint32 + halfPoint42));
            ev.Graphics.DrawString("N1", drawFont, drawBrush, new Point(halfPoint31, halfPoint32 + halfPoint42 / 2));
            //formGraphics.Clear(Color.White); 
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage+=new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

    }
}
