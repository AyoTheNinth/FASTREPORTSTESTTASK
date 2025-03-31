using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASTREPORTSTESTTASK
{
    internal class Figure //суперкласс фигура
    {
        string FigureColor; 
        string ShapeColor;
        int height;
        int width;
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

        public virtual Point[] GetCoord()   //функция посредник
        {
            return null;
        }

        public void DrawFigure(Graphics graphic)   //метод отрисовки фигуры
        {
            Pen pen = new Pen(Color.Black, 3f);
            graphic.DrawPolygon(pen, GetCoord());
        }
        public bool IsInShape()
        {
            return true;
        }
    }

    internal class Rectangle : Figure      //класс прямоугольника
    {

        public Rectangle(int iwidth,int iheight)
        {
            this.Width = iwidth;
            this.Height = iheight;
        }
        public override Point[] GetCoord()
        {
            Point[] points = new Point[4];
            points[0] = new Point(0, 0);
            points[1] = new Point(this.Width, 0);
            points[2] = new Point(this.Width, this.Height);
            points[3] = new Point(0, this.Height);
            return points;
        }
    }

    internal class Triangle : Figure        //класс треугольника WIP
    {
        private int Angle;
        public Triangle(int angle)
        {
            this.Angle = angle;
        }

        /*public override Point[] GetCoord()
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(4, 0);
            points[2] = new Point(1, 8);
            return points; 
        }
        */
    }

    internal class Circle: Figure       //класс круга WIP
    {
        private int Radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }
    }
}
