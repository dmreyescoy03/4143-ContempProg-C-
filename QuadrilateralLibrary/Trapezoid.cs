using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    //Inherits from Abstract Quadrilateral
    public class Trapezoid : Quadrilateral
    {
        //creating instance of Point
        Point point1;
        Point point2;
        Point point3;
        Point point4;
        //private data 
        //declaring doubles 
        private double sideOne;
        private double sideTwo;
        private double trapBase;
        private double trapRoof;
        private double Height;
        //constructor
        public Trapezoid(int xValue, int yValue, int x2Value, int y2Value, 
            int x3Value, int y3Value, int x4Value, int y4Value,
            int bValue, int b2Value, int hei, int sOne, int sTwo)
        {
            //creating new points
            point1 = new Point(xValue, yValue);
            point2 = new Point(x2Value, y2Value);
            point3 = new Point(x3Value, y3Value);
            point4 = new Point(x4Value, y4Value);

            BaseOne = bValue;
            BaseTwo = b2Value;
            sideA = sOne;
            sideB = sTwo;
            tHeight = hei;

        }
        //method to get Base A
        public double BaseOne
        {
            //getting and setting Base A value
            get { return trapBase; }
            set { if (value >= 0)
                    trapBase = value;
            }
        }
        //method to get Base B
        public double BaseTwo
        {
            //getting and setting Base B value
            get { return trapRoof; }
            set { if(trapRoof >= 0)
                    trapRoof = value;
            }
        }
        //method to get Height
        public double tHeight
        {
            //getting and setting Height value
            get { return Height; }
            set { if(value >= 0)
                    Height = value;
            }
        }
        //method to get Side A length
        public double sideA
        {
            //getting and setting Side A length
            get { return sideOne; }
            set { if (value >= 0)
                    sideOne = value;
            }
        }
        //method to get Side B lenght
        public double sideB
        {
            //getting and setting Side B lenght
            get { return sideTwo; }
            set { if(value >= 0)
                    sideTwo = value;
            }
        }
        //overrided method for Quadrilateral
        public override double Area()
        {
            //calculates and returns Area
            return (((BaseOne + BaseTwo) / .5) * Height);
        }
        //overrided method from Quadrilateral
        public override double Perimeter()
        {
            //calculate and returns Perimeter
            return BaseOne + BaseTwo + sideA + sideB;
        }
        //overrided method from Quadrilateral
        public override string Name
        {
            //gets and returns Name of shape
            get
            {
                return "Trapezoid";
            }
        }

    }
}
