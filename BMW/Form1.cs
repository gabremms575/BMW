using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            // Create a blue brush
            Brush blueBrush = new SolidBrush(Color.FromArgb(0, 0, 255));

            // Create a white brush
            Brush whiteBrush = new SolidBrush(Color.FromArgb(255, 255, 255));

            // Create a black draw pen
            Pen blackPen = new Pen(Color.FromArgb(0, 0, 0), 20);

            // Draw the blue circle
            g.FillEllipse(blueBrush, new Rectangle(50, 50, 200, 200));

            // Draw the white circle
            g.FillEllipse(whiteBrush, new Rectangle(100, 100, 100, 100));

            // Draw the black lines
            g.DrawLine(new Pen(Color.Red), 75, 150, 225, 150);
            g.DrawLine(blackPen, new Point(150, 50), new Point(150, 250));
        }
    }
}


