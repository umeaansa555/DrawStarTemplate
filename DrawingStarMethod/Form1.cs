using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingStarMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            ///The following line of code demonstrates how to get input
            ///and convert it to a float value. Use this to help you in 
            ///Parts 2 - 4 where you need to get inputs from the 
            ///user and store them in float variables. This code is 
            ///not needed for Part 1.

            ///float size = Convert.ToSingle(sizeInput.Text); 
            
            Graphics g = this.CreateGraphics(); //for part 4 this gets moved to the custom methods.
            Pen blackPen = new Pen(Color.Black);
            
        }

        private void fillButton_Click(object sender, EventArgs e)
        {

        }

        public void DrawStar(Pen starPen, float x, float y, float pixels)
        {


        }

    }
}
