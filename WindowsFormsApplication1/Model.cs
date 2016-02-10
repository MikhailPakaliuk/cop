using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Model
    {
        double North;
        double South;//юг
        double East; 
        double West;//запад 
        double NorthEast;
        double NorthWest;
        double SouthEast;
        double SouthWest;

       public Model()
        {
            North = Math.Sqrt(Math.Pow(Form1.OffsetWidth,2) + Math.Pow(Form1.Height,2));
            South = Math.Sqrt(Math.Pow(Form1.WidthBottomBase-(Form1.OffsetWidth+Form1.WidthUpperBase), 2) + Math.Pow(Form1.Height, 2));
            East = Math.Sqrt(Math.Pow(Form1.LongBottomBase - (Form1.OffsetLong + Form1.LongUpperBase), 2) + Math.Pow(Form1.Height, 2));
            West = Math.Sqrt(Math.Pow(Form1.OffsetLong, 2) + Math.Pow(Form1.Height, 2));
            NorthEast = Math.Sqrt(East * East + Math.Pow(Form1.OffsetWidth, 2));
            NorthWest = Math.Sqrt(North * North + Math.Pow(Form1.OffsetLong, 2));
            SouthEast = Math.Sqrt(East * East + Math.Pow(Form1.WidthBottomBase - (Form1.WidthUpperBase + Form1.OffsetWidth), 2));
            SouthWest = Math.Sqrt(South * South + Math.Pow(Form1.OffsetLong, 2));
        }
    }
}
