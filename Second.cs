using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication10
{
    public partial class Second : Form
    {
        public Second()
        {
            InitializeComponent();


            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.None;



            label1.BackColor = System.Drawing.Color.Transparent;
            label1.ForeColor = Color.White;


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

        private void label1_Click(object sender, EventArgs e){}
        private void button5_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();

            f1.Show();
           // this.Visible = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Frame f3 = new Frame();
            //   Main f1 = new Main(); 
            f3.label1.Text = label2.Text;
            f3.label1.BackColor = label2.BackColor;
            //f3.label4.BackColor = System.Drawing.Color.Transparent;
            f3.Show();
            this.Visible = false;
        }
        private void label2_Click(object sender, EventArgs e){}
        private void label2_Click_1(object sender, EventArgs e){}
        private void button1_Click(object sender, EventArgs e)
        {
            Cart f4 = new Cart();
            //   Main f1 = new Main(); 
            f4.label1.Text = label2.Text;
            f4.label1.BackColor = label2.BackColor;

            f4.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void Second_Load(object sender, EventArgs e){}
    }
}
