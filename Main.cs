using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication10
{
    public partial class Main : Form
    {
        

        public Main()
        {
            InitializeComponent();


            label1.BackColor = System.Drawing.Color.Transparent;
            label1.ForeColor = Color.White;

            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.None;



            ///////////////////////////style////////////////
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            this.Paint += new PaintEventHandler(set_background);
            Brush brush = new LinearGradientBrush(gradient_rectangle, Color.Red, Color.Black, 20f);
            //   graphics.FillRectangle(brush, gradient_rectangle);  //graphics comes from a PaintEventArgs argument(event)
            //////////////////////////////////////////////////

        }
        /////////////////////////////////////////////////////////////
        public void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(57, 147, 227), 100f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }
        ///////////////////////////////////////////////////////////


        public void NonCopperbutton_Click(object sender, EventArgs e)
        {
      //Main f1 = new Main();
            Second f2 = new Second();
            f2.label2.BackColor = Color.ForestGreen;
            f2.label2.Text = "NonCopper";
            f2.Show();
            this.Visible = false;
        }
    

        private void Copperbutton_Click(object sender, EventArgs e)
        {
      // Main f1 = new Main();
            Second f2 = new Second();
            f2.label2.BackColor = Color.DarkOrange;
            f2.label2.Text = "Copper";
            f2.Show();
            this.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e) {}
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
          //  Close();
        }
    }
}
