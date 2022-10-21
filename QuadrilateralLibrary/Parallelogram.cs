using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    //Inherits from Abstract Quadrilateral
    public class Parallelogram : Quadrilateral
    {
        //creating new points
        Point point1;
        Point point2;
        Point point3;
        //private data
        //declaring doubles, Height, SideOne, BaseOne
        private double Height;
        private double sideOne;
        private double BaseOne;
        //default contructor
        public Parallelogram(int xValue, int yValue, int x2Value, int y2Value, int x3Value,
            int y3Value, int height, int sValue, int bValue)
        {
            point1 = new Point(xValue, yValue);
            point2 = new Point(x2Value, y2Value);
            point3 = new Point(x3Value, y3Value);

            BaseTwo = bValue;
            SideTwo = sValue;
            pHeight = height;
        }
        //method to get Base of Parallelogram
        public double BaseTwo
        {
            //getting and setting Base
            get { return BaseOne; }
            set { if(value >= 0) BaseOne = value; }
        }
        //method to get Height of Parallelogram
        public double pHeight
        {
            //getting and setting Height
            get { return Height; }
            set { if(value >= 0) Height = value; }
        }
        //method to get side Lenght of Parallelogram
        public double SideTwo
        {
            //getting and setting Side length
            get { return sideOne; }
            set { if (value >= 0) sideOne = value; }
        }
        //overrided method from Quadrilateral
        public override double Area()
        {
            //calculating and returning Area
            return BaseTwo * pHeight;
        }
        //overrided method from Quadrilateral
        public override double Perimeter()
        {
            //calculating and returning Perimeter
            return (2*(BaseTwo + SideTwo));
        }
        //overrided method from Quadrilateral
        public override string Name
        {
            //getting name of shape.
            get { return "Parallelogram"; }
        }
    }
}