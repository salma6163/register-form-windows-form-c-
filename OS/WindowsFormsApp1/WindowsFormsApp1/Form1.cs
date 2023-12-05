using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 300;
            this.Height = 300;
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen mypen = new Pen(Color.Red);
            Brush mybruch= new SolidBrush(Color.Yellow);
           // g.DrawLine(mypen, 2, 2,200,200);
          //g.DrawRectangle(mypen, 100, 100, 120, 100);
            g.FillRectangle(mybruch, 100, 100, 120, 150);
        }
    }
}
