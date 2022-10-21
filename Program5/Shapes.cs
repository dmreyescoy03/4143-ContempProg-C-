/*Name: David Reyes-coy
 * Date: 10/21/2022
 * Class: 4143 Contemporary Program Lang. C#
 * Assignment: Program 5
 * 
 * Description:
 * - To create a portable dll file, also known as a class library.
 * Demonstrate and practice pollymorphism to it's fullest.
 * Creates Abstract base class, from which 5 classes inherit, and
 * override the methods of the base class. We call the library by:
 * using QuadrilaterlLibrary.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuadrilateralLibrary;

namespace ShapesP5
{
    public partial class Shapes : Form
    {
        //creating an array list to hold references to
        //quadrilaterals
        private ArrayList shapeList = new ArrayList();

        //declaring ints for shapes
        //used to increment num of shapes
        int squareCount = 0;
        int rectangleCount = 0;
        int parallelogramCount = 0;
        int trapezoidCount = 0;
        public Shapes()
        {
            InitializeComponent();
            //disabling everything until user 
            //interacts with combobox
            createShapes.Enabled = false;
            x1.Enabled = false;
            y1.Enabled = false;
            x2.Enabled = false;
            y2.Enabled = false;
            x3.Enabled = false;
            y3.Enabled = false;
            x4.Enabled = false;
            y4.Enabled = false;
            createShapes.Enabled = false;
            numSquare.Enabled = false;
            numRect.Enabled = false;
            numTrap.Enabled = false;
            numPara.Enabled = false;
            shapeBox.Hide();
            shapeBox2.Hide();
            shapeBox3.Hide();
            shapeBox4.Hide();
            
        }
        //method created for combo box aka event handler
        private void comboShapes_SelectedIndexChanged(object sender, 
            EventArgs e)
        {
            if (comboShapes.SelectedIndex == 0)
            {
                //index for square
                //enabling 2 textboxes to true
                createShapes.Enabled = true;
                x1.Enabled = true;
                y1.Enabled = true;
                x3.Enabled = true;
                y3.Enabled = true;
                
                x2.Enabled = false;
                y2.Enabled = false;
                x4.Enabled = false;
                y4.Enabled = false;

            }
            else if (comboShapes.SelectedIndex == 1)
            {
                //index for rectanlge
                //enabling 2 textboxes to true
                createShapes.Enabled = true;
                x1.Enabled = true;
                y1.Enabled = true;
                x3.Enabled = true;
                y3.Enabled = true;

                x2.Enabled = false;
                y2.Enabled = false;
                x4.Enabled = false;
                y4.Enabled = false;
            }
            else if (comboShapes.SelectedIndex == 2)
            {
                //index for parallelogram
                //enabling 3 textboxes to true
                x1.Enabled = true;
                y1.Enabled = true;
                x2.Enabled = true;
                y2.Enabled = true;
                x3.Enabled = true;
                y3.Enabled = true;
                x4.Enabled = false;
                y4.Enabled = false;
                createShapes.Enabled = true;
            }
            else if (comboShapes.SelectedIndex == 3)
            {
                //index for trapezoid
                //enabling all text box to true
                x1.Enabled = true;
                y1.Enabled = true;
                x2.Enabled = true;
                y2.Enabled = true;
                x3.Enabled = true;
                y3.Enabled = true;
                x4.Enabled = true;
                y4.Enabled = true;
                createShapes.Enabled = true;
            }
        }
        //method created for button aka eventhandler
        private void createShapes_Click(object sender, EventArgs e)
        {
            //using choice to hold index value
            int choice = comboShapes.SelectedIndex;

            //numeric switch
            switch (choice)
            {
                case 0:
                    //case 0 is for square
                    try
                    {
                        //parsing input to ints
                        int sqx = int.Parse(x1.Text);
                        int sqy = int.Parse(y1.Text);
                        int sqx3= int.Parse(x3.Text);
                        int sqy3 = int.Parse(y3.Text);
                        //if statement checks for negatives
                        if(sqx < 0 || sqy < 0 || sqx3 < 0 || sqy3 < 0)
                        {
                            MessageBox.Show("Positive integers only.",
                                "Invalid Number",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
                        else
                        {
                            //creating new points
                            Point sq1 = new Point(sqx, sqy);
                            Point sq2 = new Point(sqx, sqy3);
                            Point sq3 = new Point(sqx3, sqy3);
                            Point sq4 = new Point(sqx3, sqy);

                            //setting labels around picture
                            P1.Text = sq1.ToString();
                            P2.Text = sq2.ToString();
                            P3.Text = sq3.ToString();
                            P4.Text = sq4.ToString();

                            //calculations for a side
                            int bottom = sqy3 - sqx;

                            //calling square constructor
                            Square square = new Square(sqx, sqy, sqx3,
                                sqy3, bottom);

                            //using overrided methods
                            shapeName.Text = "You Chose " + square.Name;
                            areaLable.Text = square.Area().ToString();
                            perLable.Text = square.Perimeter().ToString();
                           
                            shapeBox.Show();
                            shapeBox2.Hide();
                            shapeBox3.Hide();
                            shapeBox4.Hide();
                            //adding to array list
                            shapeList.Add(square);
                            //incrementing number of squares
                            squareCount++;
                            numSquare.Text = squareCount.ToString();
                        }
                    }
                    //catch for error message
                    catch (Exception ex)
                    {
                        //displayes message box to user
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 1:
                    //case 1 is rectangles
                    try
                    {
                        int recx = int.Parse(x1.Text);
                        int recy = int.Parse(y1.Text);
                        int recx3 = int.Parse(x3.Text);
                        int recy3 = int.Parse(y3.Text);
                       
                        //if statement checking for negatives
                        if(recx < 0 || recy < 0 || recx3 < 0 || recy3 < 0)
                        {
                            //error message for user
                            MessageBox.Show("Positive integers only.", 
                                "Invalid Number",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //creating new points
                            Point rec1 = new Point(recx, recy);
                            Point rec2 = new Point(recx, recy3);
                            Point rec3 = new Point(recx3, recy3);
                            Point rec4 = new Point(recx3, recy);

                            //setting labes around picture
                            P1.Text = rec1.ToString();
                            P2.Text = rec2.ToString();
                            P3.Text = rec3.ToString();
                            P4.Text = rec4.ToString();

                            //calculations for lenght/width
                            int Length = recx3 - recx;
                            int Width = recy3 - recy;
                            
                            //calling recatangles constructor
                            Rectangle rectangle = new Rectangle(recx, recy,
                                 recx3, recy3, Length, Width);
                            //using overrided methods
                            shapeName.Text = "You chose " + rectangle.Name;
                            areaLable.Text = rectangle.Area().ToString();
                            perLable.Text = rectangle.Perimeter().ToString();
                            shapeBox2.Show();
                            shapeBox.Hide();
                            shapeBox3.Hide();
                            shapeBox4.Hide();
                            //adding to array list
                            shapeList.Add(rectangle);
                            //incrementing number of rectangles
                            rectangleCount++;
                            numRect.Text = rectangleCount.ToString();
                        }
                    }
                    //catch for error message
                    catch (Exception ex)
                    {
                        //displays error message in message box
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        int parx = int.Parse(x1.Text);
                        int pary = int.Parse(y1.Text);
                        int parx2 = int.Parse(x2.Text);
                        int pary2 = int.Parse(y2.Text);
                        int parx3 = int.Parse(x3.Text);
                        int pary3 = int.Parse(y3.Text);
                        //if statement checking for negative numbers
                        if(parx < 0 || pary < 0 || parx2 < 0 ||
                            pary2 < 0 || parx3 < 0 || pary3 < 0)
                        {
                            //message box to user invalid integer
                            MessageBox.Show("Positive integers only.",
                                "Invalid Number",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //creating new points
                            Point pr1 = new Point(parx, pary);
                            Point pr2 = new Point(parx2, pary2);
                            Point pr3 = new Point(parx3, pary3);
                            Point pr4 = new Point(parx2, pary);

                            //setting labes around picture
                            P1.Text = pr1.ToString();
                            P2.Text = pr2.ToString();
                            P3.Text = pr3.ToString();
                            P4.Text = pr4.ToString();
                            //calculations for base,side,height
                            int parBase = parx + pary2;
                            int parSide = pary3 + parx2;
                            int parHeight = pary + pary2;

                            //calling parallelograms constructor
                            Parallelogram parallelogram = 
                                new Parallelogram(parx, pary, parx2, pary2,
                                parx3, pary3, parSide, parHeight, parBase);

                            //using overrided methods 
                            shapeName.Text = "You chose " + parallelogram.Name;
                            areaLable.Text = parallelogram.Area().ToString();
                            perLable.Text = parallelogram.Perimeter().ToString();
                            shapeBox3.Show();
                            shapeBox.Hide();
                            shapeBox2.Hide();
                            shapeBox4.Hide();
                            //adding to array list
                            shapeList.Add(parallelogram);
                            //incrementing number of parallelograms
                            parallelogramCount++;
                            numPara.Text = parallelogramCount.ToString();
                        }
                    }
                    //catch for error message
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 3:
                    //case 3 gets all 4 points from user
                    //creates instances of Points. calling new
                    try
                    {
                        //parsing the text boxes to ints
                        int trax = int.Parse(x1.Text);
                        int tray = int.Parse(y1.Text);
                        int trax2 = int.Parse(x2.Text);
                        int tray2 = int.Parse(y2.Text);
                        int trax3 = int.Parse(x3.Text);
                        int tray3 = int.Parse(y3.Text);
                        int trax4 = int.Parse(x4.Text);
                        int tray4 = int.Parse(y4.Text);
                        //if statement to error check for negatives
                        if(trax < 0 || tray < 0 || trax2 < 0 || tray2 < 0
                           || trax3 < 0 || tray3 < 0 || trax4 < 0 || tray4 < 0)
                        {
                           MessageBox.Show("Positive integers only.",
                               "Invalid Number",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                      //if no negative was entered proceed with the calculations
                        else
                        {
                            Point tr1 = new Point(trax, tray);
                            Point tr2 = new Point(trax2, tray2);
                            Point tr3 = new Point(trax3, tray3);
                            Point tr4 = new Point(trax4, tray4);

                            //setting the labels around picture
                            P1.Text = tr1.ToString();
                            P2.Text = tr2.ToString();
                            P3.Text = tr3.ToString();
                            P4.Text = tr4.ToString();

                            //calculations for 2 bases, sides, height
                            int trapBase = trax + trax4;
                            int trapBase2 = trax2 + trax3;
                            int trapSide = tray + tray2;
                            int trapSide2 = tray4 + tray3;
                            int trapHeight = tray + tray2;

                            //calling trapezoid constructor
                            Trapezoid trapezoid =
                                new Trapezoid(trax, tray, trax2, tray2, trax3, tray3
                                , trax4, tray4, trapBase, trapBase2,
                                trapHeight, trapSide, trapSide2);

                            //using overrided methods Area/Perimeter
                            shapeName.Text = "You chose " + trapezoid.Name;
                            areaLable.Text = trapezoid.Area().ToString();
                            perLable.Text = trapezoid.Perimeter().ToString();
                            shapeBox4.Show();
                            shapeBox3.Hide();
                            shapeBox2.Hide();
                            shapeBox.Hide();
                            //adding shapes to the array list
                            shapeList.Add(trapezoid);
                            //incrementing number of trapezoids
                            trapezoidCount++;
                            numTrap.Text = trapezoidCount.ToString();    
                        }
                    }
                    //catch for error message
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                default:
                    break;

            }
        }
    }
}