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
using XL = Microsoft.Office.Interop.Excel;
using System.Drawing.Drawing2D;


namespace WindowsFormsApplication10
{
    

    public partial class Frame : Form
    {
        
        public Frame()
        {

            InitializeComponent();

            label2.BackColor = System.Drawing.Color.Transparent;
            label2.ForeColor = Color.White;

            label3.BackColor = System.Drawing.Color.Transparent;
            label3.ForeColor = Color.White;

            label26.BackColor = System.Drawing.Color.Transparent;
            label26.ForeColor = Color.White;

            label4.BackColor = System.Drawing.Color.Transparent;
            label4.ForeColor = Color.White;
            
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.ForeColor = Color.White;

            label6.BackColor = System.Drawing.Color.Transparent;
            label6.ForeColor = Color.White;

            label7.BackColor = System.Drawing.Color.Transparent;
            label7.ForeColor = Color.White;

            label8.BackColor = System.Drawing.Color.Transparent;
            label8.ForeColor = Color.White;

            label9.BackColor = System.Drawing.Color.Transparent;
            label9.ForeColor = Color.White;

            label10.BackColor = System.Drawing.Color.Transparent;
            label10.ForeColor = Color.White;

            label16.BackColor = System.Drawing.Color.Transparent;
            label16.ForeColor = Color.White;

            label15.BackColor = System.Drawing.Color.Transparent;
            label15.ForeColor = Color.White;

            label17.BackColor = System.Drawing.Color.Transparent;
            label17.ForeColor = Color.White;

            panel5.BackColor = System.Drawing.Color.Transparent;
            radioButton19.ForeColor = Color.White;
            radioButton20.ForeColor = Color.White;

            panel4.BackColor = System.Drawing.Color.Transparent;
            radioButton17.ForeColor = Color.White;
            radioButton18.ForeColor = Color.White;

            panel3.BackColor = System.Drawing.Color.Transparent;
            radioButton15.ForeColor = Color.White;
            radioButton16.ForeColor = Color.White;

            panel2.BackColor = System.Drawing.Color.Transparent;
            radioButton1.ForeColor = Color.White;
            radioButton2.ForeColor = Color.White;

            panel1.BackColor = System.Drawing.Color.Transparent;
            radioButton6.ForeColor = Color.White;
            radioButton5.ForeColor = Color.White;

            panel6.BackColor = System.Drawing.Color.Transparent;
            radioButton21.ForeColor = Color.White;
            radioButton22.ForeColor = Color.White;

            panel8.BackColor = System.Drawing.Color.Transparent;
            radioButton3.ForeColor = Color.White;
            radioButton4.ForeColor = Color.White;

            panel10.BackColor = System.Drawing.Color.Transparent;
            radioButton7.ForeColor = Color.White;
            radioButton8.ForeColor = Color.White;

            panel11.BackColor = System.Drawing.Color.Transparent;
            radioButton9.ForeColor = Color.White;
            radioButton10.ForeColor = Color.White;

            panel12.BackColor = System.Drawing.Color.Transparent;
            radioButton11.ForeColor = Color.White;
            radioButton12.ForeColor = Color.White;
            label17.ForeColor = Color.White;

            panel7.BackColor = System.Drawing.Color.Transparent;
            label14.ForeColor = Color.White;
            label13.ForeColor = Color.White;
            label12.ForeColor = Color.White;
            label11.ForeColor = Color.White;
            label18.ForeColor = Color.White;

            panel9.BackColor = System.Drawing.Color.Transparent;
            label20.ForeColor = Color.White;
            label21.ForeColor = Color.White;
            label22.ForeColor = Color.White;
            label23.ForeColor = Color.White;
            label19.ForeColor = Color.White;

            label24.BackColor = System.Drawing.Color.Transparent;
            label24.ForeColor = Color.White;

            label25.BackColor = System.Drawing.Color.Transparent;
            label25.ForeColor = Color.White;


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

        public void button1_Click(object sender, EventArgs e)
        {
           Main f1 = new Main();
           f1.Show();
           this.Close();
        }

        private void Form2_Load(object sender, EventArgs e){}
        private void label8_Click(object sender, EventArgs e){}
        private void radioButton14_CheckedChanged(object sender, EventArgs e){}
        private void radioButton13_CheckedChanged(object sender, EventArgs e){}
        private void radioButton7_CheckedChanged(object sender, EventArgs e){}
        private void radioButton8_CheckedChanged(object sender, EventArgs e){}
        private void label10_Click(object sender, EventArgs e){}
        private void radioButton1_CheckedChanged(object sender, EventArgs e){}
        private void radioButton2_CheckedChanged(object sender, EventArgs e){}
        private void radioButton4_CheckedChanged(object sender, EventArgs e){}
        private void radioButton3_CheckedChanged(object sender, EventArgs e){}
        private void checkBox2_CheckedChanged(object sender, EventArgs e){}
        private void panel5_Paint(object sender, PaintEventArgs e){}
        private void panel8_Paint(object sender, PaintEventArgs e){}
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){}
        public void label1_Click(object sender, EventArgs e){}
        private void radioButton19_CheckedChanged(object sender, EventArgs e){}

        private void button2_Click(object sender, EventArgs e)
        {
            /////////////////////////validators///////////////////////////
            if (textBox2.Text == "")
                MessageBox.Show("Please enter the bay");
           else  if(textBox1.Text == "")
                MessageBox.Show("Please enter the tool name");
            else if (textBox7.Text == "")
                MessageBox.Show("Please enter your name");

            else if(radioButton19.Checked==false&&radioButton20.Checked==false && radioButton17.Checked == false && radioButton18.Checked == false && radioButton15.Checked == false && radioButton16.Checked == false)
                MessageBox.Show("Please select Yes/No");
            else if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton6.Checked == false && radioButton5.Checked == false && radioButton21.Checked == false && radioButton22.Checked == false)
                MessageBox.Show("Please select Yes/No");
             else if (radioButton3.Checked == false && radioButton4.Checked == false && radioButton7.Checked == false && radioButton8.Checked == false && radioButton9.Checked == false && radioButton10.Checked == false)
                MessageBox.Show("Please select Yes/No");
            else if (radioButton7.Checked == false && radioButton8.Checked == false)
                MessageBox.Show("Please select keyboard");
            else if (radioButton9.Checked == false && radioButton10.Checked == false)
                MessageBox.Show("Please select Yes/No");



            //  else if(textBox3.Text==""  && textBox4.Text=="" &&textBox5.Text=="")
            //  {
            //       MessageBox.Show("Please enter data for WIP 1");
            //   }
            //    else if (textBox10.Text !=""&&textBox11.Text==""&&textBox12.Text=="" )
            //   {
            //      MessageBox.Show("Please enter data for WIP 2");
            //   }
            //    else if (richTextBox1.Text=="")
            //   {
            //       MessageBox.Show("Don't forget the Notes");
            //   }///////////////////////////////////////////////////////////////
            else
            {
                Generate();
            }
        }
        private void Generate()
        {
                //Open the excel application and add a workbook
                XL.Application application;
                XL.Workbook book;
                XL.Worksheet sheet;
                application = new XL.Application();
                application.Visible = true;
                book = application.Workbooks.Add();
                sheet = (XL.Worksheet)book.Worksheets[1];
               int milliseconds = 2000;
               Thread.Sleep(milliseconds);

            //change color and width in cell 1,1 - 1,5
            if (label1.Text == "NonCopper")
                {
                    var Xlabel1 = sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 6]];
                    Xlabel1.Interior.Color = XL.XlRgbColor.rgbLightGreen;
                }
                if (label1.Text == "Copper")
                {
                    var Xlabel1 = sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 6]];
                    Xlabel1.Interior.Color = XL.XlRgbColor.rgbOrange;
                }
            //  var Xlabel1 = sheet.Range[sheet.Cells[1, 1],sheet.Cells[1,6]];
            //  Xlabel1.Interior.Color = XL.XlRgbColor.rgbLightGreen;
            //((XL.Range)sheet.Cells[1, 1]).Cells.Column = Color.Black;
            ((XL.Range)sheet.Cells[1, 1]).Value = label1.Text;
                ((XL.Range)sheet.Cells[1, 1]).ColumnWidth = 30.00;
                ((XL.Range)sheet.Cells[1, 2]).ColumnWidth = 14.30;

                ((XL.Range)sheet.Cells[1, 2]).Value = label2.Text;

                ((XL.Range)sheet.Cells[1, 3]).Value = textBox1.Text;
                ((XL.Range)sheet.Cells[1, 4]).Value = label3.Text;
                ((XL.Range)sheet.Cells[1, 5]).Value = textBox2.Text;

                ((XL.Range)sheet.Cells[3, 1]).Value = label4.Text;
                ((XL.Range)sheet.Cells[4, 1]).Value = label5.Text;
                ((XL.Range)sheet.Cells[5, 1]).Value = label6.Text;
                ((XL.Range)sheet.Cells[6, 1]).Value = label7.Text;
                ((XL.Range)sheet.Cells[7, 1]).Value = label8.Text;
                ((XL.Range)sheet.Cells[8, 1]).Value = label9.Text;
                ((XL.Range)sheet.Cells[9, 1]).Value = label10.Text;
                ((XL.Range)sheet.Cells[10, 1]).Value = label16.Text;
                ((XL.Range)sheet.Cells[11, 1]).Value = label15.Text;
                if (panel12.Visible == true)
                {
                    ((XL.Range)sheet.Cells[12, 1]).Value = label17.Text;
                }

                ((XL.Range)sheet.Cells[3, 4]).Value = label11.Text;
                ((XL.Range)sheet.Cells[3, 5]).NumberFormat = "@";
                ((XL.Range)sheet.Cells[3, 5]).Value = textBox3.Text;
                ((XL.Range)sheet.Cells[3, 7]).Value = comboBox1.SelectedItem;
                ((XL.Range)sheet.Cells[4, 4]).Value = label12.Text;
                ((XL.Range)sheet.Cells[4, 5]).NumberFormat = "@";
                ((XL.Range)sheet.Cells[4, 5]).Value = textBox4.Text;
                ((XL.Range)sheet.Cells[5, 4]).Value = label13.Text;
                ((XL.Range)sheet.Cells[5, 5]).NumberFormat = "@";
                ((XL.Range)sheet.Cells[5, 5]).Value = textBox5.Text;
                ((XL.Range)sheet.Cells[6, 4]).Value = label14.Text;
                ((XL.Range)sheet.Cells[6, 5]).NumberFormat = "@";
                ((XL.Range)sheet.Cells[6, 5]).Value = textBox6.Text;


                ((XL.Range)sheet.Cells[8, 7]).Value = comboBox2.SelectedItem;
                ((XL.Range)sheet.Cells[8, 4]).Value = label20.Text;
                ((XL.Range)sheet.Cells[8, 5]).NumberFormat = "@";
                ((XL.Range)sheet.Cells[8, 5]).Value = textBox10.Text;
                ((XL.Range)sheet.Cells[9, 4]).Value = label21.Text;
                ((XL.Range)sheet.Cells[9, 5]).NumberFormat = "@";
                ((XL.Range)sheet.Cells[9, 5]).Value = textBox11.Text;
                ((XL.Range)sheet.Cells[10, 4]).Value = label22.Text;
                ((XL.Range)sheet.Cells[10, 5]).NumberFormat = "@";
                ((XL.Range)sheet.Cells[10, 5]).Value = textBox12.Text;
                ((XL.Range)sheet.Cells[11, 4]).Value = label23.Text;
                ((XL.Range)sheet.Cells[11, 5]).NumberFormat = "@";
                ((XL.Range)sheet.Cells[11, 5]).Value = textBox13.Text;


               ((XL.Range)sheet.Cells[14, 1]).Value = "Notes :";
               ((XL.Range)sheet.Cells[15, 1]).Value = richTextBox1.Text;


               ((XL.Range)sheet.Cells[14, 2]).Value = "Readiness By" ;
               ((XL.Range)sheet.Cells[14, 3]).Value = textBox7.Text;


            if (radioButton19.Checked == true)
                    ((XL.Range)sheet.Cells[3, 2]).Value = radioButton19.Text;
                else
                {
                    ((XL.Range)sheet.Cells[3, 2]).Value = radioButton20.Text;
                    ((XL.Range)sheet.Cells[3, 2]).Interior.Color = XL.XlRgbColor.rgbYellow;
                }

                if (radioButton17.Checked == true)
                    ((XL.Range)sheet.Cells[4, 2]).Value = radioButton17.Text;
                else
                {
                    ((XL.Range)sheet.Cells[4, 2]).Value = radioButton18.Text;
                    ((XL.Range)sheet.Cells[4, 2]).Interior.Color = XL.XlRgbColor.rgbYellow;
                }

                if (radioButton15.Checked == true)
                    ((XL.Range)sheet.Cells[5, 2]).Value = radioButton15.Text;
                else
                {
                    ((XL.Range)sheet.Cells[5, 2]).Value = radioButton16.Text;
                    ((XL.Range)sheet.Cells[5, 2]).Interior.Color = XL.XlRgbColor.rgbYellow;
                }

                if (radioButton1.Checked == true)
                    ((XL.Range)sheet.Cells[6, 2]).Value = radioButton1.Text;
                else
                {
                    ((XL.Range)sheet.Cells[6, 2]).Value = radioButton2.Text;
                    ((XL.Range)sheet.Cells[6, 2]).Interior.Color = XL.XlRgbColor.rgbYellow;
                }

                if (radioButton6.Checked == true)
                    ((XL.Range)sheet.Cells[7, 2]).Value = radioButton6.Text;
                else
                {
                    ((XL.Range)sheet.Cells[7, 2]).Value = radioButton5.Text;
                    ((XL.Range)sheet.Cells[7, 2]).Interior.Color = XL.XlRgbColor.rgbYellow;
                }

                if (radioButton21.Checked == true)
                    ((XL.Range)sheet.Cells[8, 2]).Value = radioButton21.Text;
                else
                {
                    ((XL.Range)sheet.Cells[8, 2]).Value = radioButton22.Text;
                    ((XL.Range)sheet.Cells[8, 2]).Interior.Color = XL.XlRgbColor.rgbYellow;
                }

                if (radioButton3.Checked == true)
                    ((XL.Range)sheet.Cells[9, 2]).Value = radioButton3.Text;
                else
                {
                    ((XL.Range)sheet.Cells[9, 2]).Value = radioButton4.Text;
                    ((XL.Range)sheet.Cells[9, 2]).Interior.Color = XL.XlRgbColor.rgbYellow;
                }

                if (radioButton7.Checked == true)
                    ((XL.Range)sheet.Cells[10, 2]).Value = radioButton7.Text;
                else
                    ((XL.Range)sheet.Cells[10, 2]).Value = radioButton8.Text;

                if (radioButton9.Checked == true)
                    ((XL.Range)sheet.Cells[11, 2]).Value = radioButton9.Text;
                else
                    ((XL.Range)sheet.Cells[11, 2]).Value = radioButton10.Text;
                if (panel12.Visible == true)
                {
                    if (radioButton11.Checked == true)
                        ((XL.Range)sheet.Cells[12, 2]).Value = radioButton11.Text;
                    else
                        ((XL.Range)sheet.Cells[12, 2]).Value = radioButton12.Text;

                }

                //textBox1 Text in Cell[1,2]
                // ((XL.Range)sheet.Cells[1, 2]).Value = textBox1.Text;

                //label2 Text in Cell[2,1]
                //   ((XL.Range)sheet.Cells[2, 1]).Value = label2.Text;

                //textBox2 Text in Cell[2,2]
                // ((XL.Range)sheet.Cells[2, 2]).Value = textBox2.Text;

                    }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e){}
        private void label23_Click(object sender, EventArgs e){}
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
                panel12.Visible = true;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
                panel12.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e){}
        public void textBox2_TextChanged(object sender, EventArgs e){}
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          //  if (textBox3.Text == null)
          //      MessageBox.Show("123");
        }

        private void textBox4_TextChanged(object sender, EventArgs e){}
        private void label3_Click(object sender, EventArgs e){}
        private void label26_Click(object sender, EventArgs e){}
    }
}
