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
        public string name;
        string FigureColor; 
        string ShapeColor;
        public int dub;


        public virtual Point[] GetCoord()   //функция посредник
        {
            return null;
        }

        public virtual RectangleF GetRectangleF() //я в замешательстве
        {
            throw null; 
        }

        public void DrawFigure(Graphics graphic,string name)   //метод отрисовки фигуры
        {
            switch (name)
            {
                case "Rectangle":
                    Pen pen = new Pen(Color.Black, 3f);
                    graphic.DrawPolygon(pen, GetCoord());
                    SolidBrush fill = new SolidBrush(Color.DarkRed);//хардкод, прикрутить цвет от каждой фигуры
                    graphic.FillPolygon(fill, GetCoord());
                    break;
                case "Circle":
                    Pen pen2 = new Pen(Color.Black, 3f);
                    graphic.DrawEllipse(pen2, GetRectangleF());
                    break;
                case "Triangle":
                    break;
            }
            
        }
        public bool IsInShape()
        {
            return true;
        }
    }

    internal class Rectangle : Figure      //класс прямоугольника
    {

        int height;
        int width;


        public int Height
        {
            get

            { return height; }
            set

            { height = value; }
        }
        public int Width
        {
            get
            { return width; }

            set
            { width = value; }

        }

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
    }

    internal class Circle : Figure       //класс круга WIP почти получилось
    {
        private int Radius;


        public Circle(int radius)
        {
            this.Radius = radius;
        }
        public override RectangleF GetRectangleF()
        {
            RectangleF circle = new RectangleF();
            Point[] CirclePoints = new Point[4];
            CirclePoints[0] = new Point(0, 0);
            CirclePoints[1] = new Point(55, 0);
            CirclePoints[2] = new Point(55,   55);
            CirclePoints[3] = new Point(0,55);
            return circle;
        }
       
    }
}
