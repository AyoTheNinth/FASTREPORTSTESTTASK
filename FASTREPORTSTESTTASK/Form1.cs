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

            var points = new Rectangle(int.Parse(RectangleHeightTxtBx.Text),int.Parse(RectWidthTxtBx.Text));
            if (points != null)
            {
                Graphics graphic = panel1.CreateGraphics();
                points.DrawFigure(graphic);
            }
            else
            {
                MessageBox.Show("Поля не должны быть пусты!");
            }
        }
    }
}
