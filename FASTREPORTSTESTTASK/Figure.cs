using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASTREPORTSTESTTASK
{
    internal class Figure
    {
        string FigureColor;
        string ShapeColor;
        private int height;
        private int width;
        public int dub;

        public int Height
        { 
            get 

            {return height;} 
            set 

            { height = value;} 
        }
        public int Width
        {
            get
            { return width; }

            set
            { width = value; } 

        }

        

        public void DrawFigure()
        {
            //Pen pen = new Pen(Color.Black, 3f);
           // Graphics graphic = new Graphics();
        }
        public bool IsInShape()
        {
            return true;
        }
    }

    internal class Rectangle : Figure
    {
        public void CreateRectangle(int iwidth, int iheight)
        {
           /* Rectangle rect = new Rectangle();
            rect.Width = iwidth;
            rect.Height = iheight;
            Point[] points = new Point[4];
            points[0] = new Point(iwidth);
            points[1] = new Point(0);
            points[2] = new Point(0);
            points[3] = new Point(iheight); */
            
        }
    }
}
