using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    //Inherits from Abstract Quadrilateral
    public class Square : Quadrilateral
    {
        //creating new points
        Point point1;
        Point point2;
        //private data 
        //declaring double, Width
        private double Width;
        //constructor
        public Square(int xValue, int yValue, int x3Value, int y3Value,
            int wid)
        {
            //assigning values 
            point1 = new Point(xValue, yValue);
            point2 = new Point(x3Value, y3Value);
            Width = wid;
        }
        //overrided method from Quadrilateral
        public override double Area()
        {
            //calculate and return Area
            return Width * Width;
        }
        //overrided method from Quadrilateral
        public override double Perimeter()
        {
            //calculate and return Perimeter
            return (4 * Width);
        }
        //overrided method from Quadrilateral
        public override string Name
        {
            //getting name of shape
            get { return "Square"; }
        }
    }
}