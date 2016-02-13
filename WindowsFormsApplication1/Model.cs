using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Model
    {
       public double North;
       public double South;//юг
       public double East;
       public double West;//запад 
       public double NorthEast;
       public double NorthWest;
       public double SouthEast;
       public double SouthWest;

        public Model(double LongBottomBase, double WidthBottomBase, double LongUpperBase, double WidthUpperBase, double OffsetLong, double OffsetWidth, double Height)
        {
            North = Math.Sqrt(Math.Pow(OffsetWidth,2) + Math.Pow(Height,2));
            South = Math.Sqrt(Math.Pow(WidthBottomBase-(OffsetWidth+WidthUpperBase), 2) + Math.Pow(Height, 2));
            East = Math.Sqrt(Math.Pow(LongBottomBase - (OffsetLong + LongUpperBase), 2) + Math.Pow(Height, 2));
            West = Math.Sqrt(Math.Pow(OffsetLong, 2) + Math.Pow(Height, 2));
            NorthEast = Math.Sqrt(East * East + Math.Pow(OffsetWidth, 2));
            NorthWest = Math.Sqrt(North * North + Math.Pow(OffsetLong, 2));
            SouthEast = Math.Sqrt(East * East + Math.Pow(WidthBottomBase - (WidthUpperBase + OffsetWidth), 2));
            SouthWest = Math.Sqrt(South * South + Math.Pow(OffsetLong, 2));
        }
    }
}
