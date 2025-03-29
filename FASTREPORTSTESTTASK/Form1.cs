using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASTREPORTSTESTTASK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MakeRectangleButton_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            Rectangle rect = new Rectangle();
            
            Point[] points = new Point[4];
            points[0] = new Point(0,0);
            points[1] = new Point(Width/10,0);
            points[2] = new Point(Width / 10,Height/10);
            points[3] = new Point(0,Width/10);
            // Rectangle rect = new Rectangle();
            rect.CreateRectangle(int.Parse(RectangleHeightTxtBx.Text),int.Parse(RectWidthTxtBx.Text));
            Pen pen = new Pen(Color.Black, 3f);
            Graphics graphic = panel1.CreateGraphics();
            graphic.DrawLines(pen, points);
        }
    }
}
