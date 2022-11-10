/* Name: David Reyes-coy
 * Date: 11/4/2022
 * Assignment: Program 6
 * Class: 4143 Cont. Prog. Lang: C#
 * 
 * Description:
 * - Windows Forms App containing a Panel, Radio Buttons, Menu Item Tool
 * Strip. Recreating a simple painter program. Allowing the user to select
 * different pen colors, pen sizes, eraser/eraser size. The drawing is done on
 * a panel that is ontop of a form. Included custom cursors.
 * 
 * Implements: using one event handler for multiple buttons by checking
 * if sender is equal to the button name. Does the same for Tool Strip Menu Item.
 */

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Program6
{
    public partial class Painter : Form
    {
        //Declaring x,y. Used for line that is drawed
        private int x = 0;
        private int y = 0;
        //Declaring a bool for pen
        private bool penDraw = false;

        //Declaring Graphics object
        private Graphics g;
        //Declaring Pen object
        private Pen pen;
        //Declaring ColorDialog object
        private ColorDialog colorDialog;

        /*Default Constructor.
         * Creates instance of a pen, calls graphics for panel, and
         * sets pen.StartCap/pen.EndCap to round for smoother lines.
         */
        public Painter()
        {
            InitializeComponent();
            //Invoking CreateGraphics
            g = panelPaint.CreateGraphics();
            //Declaring pen to a new Pen set color to black
            //Defalut size is 2
            pen = new Pen(Color.Black, 2);
            //Setting linecap value to round. Pen will draw smoother.
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        /*eraseButton Event Handler Allows user to erase things on
         * the panel without starting completely over. Can set eraser
         * size using the pen sizes. 
         */
        private void eraseButton_Click(object sender, EventArgs e)
        {
            //setting custom cursor for eraser
            panelPaint.Cursor = new Cursor("eraser.cur");
            pen.Color = panelPaint.BackColor;
        }
        /*panelPaint_MouseUp event handler detects if the mouse click
         * has been released. Setting penDraw to false, and stopping
         * lines from being drawn on the panel.
         */
        private void panelPaint_MouseUp(object sender, MouseEventArgs e)
        {
            //setting penDraw to false. Pen wont draw anymore.
            penDraw = false;
        }
        /*panelPaint_MouseMove Even handler detects if the mouse is being
         * moved around the panel, if movement is detected set penDraw to true
         * create a new point for the line, and follow the cursor on the screen.
         */
        private void panelPaint_MouseMove(object sender, MouseEventArgs e)
        {
            //penDraw = true
            if (penDraw)
            {
                //create a new point for the line to start at
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }  
        }
        /*MouseDown Event Handler takes care of drawing on the panel with the pen
         * using x,y cordoordinates allowing user to release mouse click
         * and continue drawing somewhere else.
         * Uses Custom cursor to draw on panel.
         */
        private void panelPaint_MouseDown(object sender, MouseEventArgs e)
        {
            //Setting penDraw to true, Allowing for drawing
            penDraw = true;
            //Save cursor x,y
            //keeps lines from connecting automatically
            x = e.X;
            y = e.Y;
            //setting custom cursor. Included in bin/Debug Folder
            //created using a bitmap
            panelPaint.Cursor = new Cursor("pen.cur");
        }
        /*buttonType Event handler controls group of radio buttons.
         * Sets size of the brush, small, medium, and large.
         * Uses sender to check if it equals the radio button
         * name. If so then set pen.Width.
         */
        private void buttonType_CheckedChanged(object sender, EventArgs e)
        {

            if (sender == radioSmall)
            {
                //Unchecks Menu Size when small is selected
                //Allowing size to go back to small
                sizeOneMenu.Checked = false;
                sizeTwoMenu.Checked = false;
                sizeThreeMenu.Checked = false;
                //setting pen width to 3
                pen.Width = 3;
            }
            else if (sender == radioMed)
            {
                //Unchecks Menu Size When medium is selected
                //Allowing size to go back to Medium
                sizeOneMenu.Checked = false;
                sizeTwoMenu.Checked = false;
                sizeThreeMenu.Checked = false;
                //setting pen width to 5
                pen.Width = 5;
            }
            else
            {
                //Unchecks Menu Size when Large is selected
                // Allowing size to go back to Large
                sizeOneMenu.Checked = false;
                sizeTwoMenu.Checked = false;
                sizeThreeMenu.Checked = false;
                //setting pen width to 10
                pen.Width = 10;
            }
        }
        /*groupColor_CheckedChanged Event Handler handles the group of
         * Radio buttons for default colors. if sender is equal to any
         * colorButton then change the pen color to the set color of the button.
         */
        private void groupColor_CheckedChanged(object sender, EventArgs e)
        {
            //colorOneButton for Red
            if (sender == colorOneButton)
            {
                //if sender equals first button name
                //change pen color to red
                pen.Color = Color.Red;

            }
            //colorTwoButton for Green
            else if (sender == colorTwoButton)
            {
                //if sender equals second button name
                //change pen color to green
                pen.Color = Color.Green;
            }
            else if(sender == colorThreeButton)
            {
                //else if sender equals third button name
                //change pen color to blue
                pen.Color = Color.Blue;
            }
            else if(sender == colorFourButton)
            {
                //else if sender equals fourth button
                //name, change pen color to black
                pen.Color = Color.Black;
            }
        }
        /*colorToolStripMenuItem Event handler handles the custom color option.
         *Under Menu->Customize->Color. Displays the colorDialog, allowing
         *for custom colors to be used.
         */
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //showing the Dialog for custom colors
            colorDialog.ShowDialog();
            //setting pen color to the custom color
            pen.Color = colorDialog.Color;
        }
        /*fileMenuTool Event Handler handles all of the Menu Tool options.
         * Uses sender to check if which option has been selected.
         * Menu->File->New/About/Exit.
         */
        private void fileMenuTool_Click(object sender, EventArgs e)
        {
            if(sender == newMenuTool)
            {
                //Clears the Panel Completely
                //When New is selected.
                //Implements the idea of a new project being started.
                panelPaint.Invalidate();
            }
            else if(sender == aboutMenuTool)
            {
                //Displaying in a message box information
                //About the program
                MessageBox.Show("Painter Program 1.0.0\n" +
                    "Visual Studio 2022 \nCreated with C#\n\n" +
                    "© Reyes-coy. All rights reserved.",
                "Program Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //If exit is selected, quit the application.
                Application.Exit();
            }
        }
        /*sizeMenuItem Event Handler used to handle all of the custom sizes
         * available in the Menu->Customize->Size. Unchecks the Radio
         * buttons allowing for the pen size to be changed, and not 
         * confused with the Default Size in radio buttons.
         */
        private void sizeMenuItem_CheckChanged(object sender, EventArgs e)
        {
            if (sender == sizeOneMenu && sizeOneMenu.Checked == true)
            {
                //Unchecks all radio Buttons, and sets
                //pen size to custom size 8px
                radioSmall.Checked = false;
                radioMed.Checked = false;
                radioLar.Checked = false;
                sizeTwoMenu.Checked = false;
                sizeThreeMenu.Checked = false;

                pen.Width = 8;
            }
            else if (sender == sizeTwoMenu && sizeTwoMenu.Checked == true)
            {
                //Unchecks all radio Buttons, and sets
                //pen size to custom size 16px
                radioSmall.Checked = false;
                radioMed.Checked = false;
                radioLar.Checked = false;
                sizeOneMenu.Checked = false;
                sizeThreeMenu.Checked = false;
               
                pen.Width = 16;
            }
            else if (sender == sizeThreeMenu && sizeThreeMenu.Checked == true)
            {
                //Unchecks all radio Buttons, and sets
                //pen size to custom size 30px
                radioSmall.Checked = false;
                radioMed.Checked = false;
                radioLar.Checked = false;
                sizeOneMenu.Checked = false;
                sizeTwoMenu.Checked = false;

                pen.Width = 30;
            }
        }
    }
}