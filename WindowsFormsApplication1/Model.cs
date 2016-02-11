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
