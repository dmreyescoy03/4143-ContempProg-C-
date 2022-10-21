using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    public class Point: Quadrilateral
    {
        int pointx , pointy;
        public Point(int xValue, int yValue)
        {
            X = xValue;
            Y = yValue;
        }
        public int X
        {
            get { return pointx; }
            set { pointx = value; }
        }
        public int Y
        {
            get { return pointy; }
            set { pointy = value; }
        }
        public override string Name
        {
            get
            {
                return "Point";
            }
        }
    }
}