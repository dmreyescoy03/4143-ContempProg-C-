using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    //Inherits from Abstract Quadrilaterl
    public class Rectangle : Quadrilateral
    {
        //creating instance of Point
        Point point1;
        Point point3;
        //private data Lenght,Width
        private double Length;
        private double Width;

        //constructor
        public Rectangle(int xValue, int yValue, int x3Value, int y3Value, int wid, int len)
        {
            //declaring two new points 
            point1 = new Point(xValue, yValue);
            point3 = new Point(x3Value, y3Value);
            
            rWidth = wid;
            rLength = len;

        }
        //getting length of rectangle
        public double rLength
        {
            //getting and setting lenght
            get { return Length; }
            set { if (value >= 0) Length = value; }
        }
        //getting width of rectangle
        public double rWidth
        {
            //getting and setting width
            get { return Width; }
            set { if(value >= 0) Width = value; }
        }
        //overrided method from Quadrilateral class
        public override double Area()
        {
            return Length * Width;
        }
        //overrided method from Quadrilateral class
        public override double Perimeter()
        {
            return (2 * (Length + Width));
        }
        //overrided method from Quadrilateral class
        public override string Name
        {
            //getting name of the shape
            get
            {
                return "Rectangle";
            }  
        }
    }
}
