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

            //Graphics g = this.CreateGraphics(); //for part 4 this gets moved to the custom methods.
            //Pen blackPen = new Pen(Color.Black);

            Graphics g = this.CreateGraphics(); //for part 4 this gets moved to the custom methods.
            Pen blackPen = new Pen(Color.Black);


            Point point1 = new Point(50, 0);
            Point point2 = new Point(61, 38);
            Point point3 = new Point(99, 39);
            Point point4 = new Point(69, 60);
            Point point5 = new Point(80, 99);
            Point point6 = new Point(50, 77);
            Point point7 = new Point(19, 99);
            Point point8 = new Point(30, 60);
            Point point9 = new Point(0, 39);
            Point point10 = new Point(38, 38);
            Point[] points = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };


            g.DrawPolygon(blackPen,points); ;
            
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics(); //for part 4 this gets moved to the custom methods.

            Point point1 = new Point(50, 0);
            Point point2 = new Point(61, 38);
            Point point3 = new Point(99, 39);
            Point point4 = new Point(69, 60);
            Point point5 = new Point(80, 99);
            Point point6 = new Point(50, 77);
            Point point7 = new Point(19, 99);
            Point point8 = new Point(30, 60);
            Point point9 = new Point(0, 39);
            Point point10 = new Point(38, 38);
            Point[] points = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };

            Brush fillBrush = new SolidBrush(Color.Black);
            //g.fillPolygon(fillBrush, points);
            
        }

        public void DrawStar(Pen starPen, float x, float y, float pixels)
        {


        }

    }
}
