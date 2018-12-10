using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//miniAssignment-NickBrazda - Programming Fundamentals.
namespace miniAssignment_NickBrazda
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        //Create Variable
        int class1, class2, class3, class4, class5, class6, tot, avg;
        //  button calculate grade 
        private void button1_Click(object sender, EventArgs e)
        {
            class1 = int.Parse(textBox1.Text);
            class2 = int.Parse(textBox2.Text);
            class3 = int.Parse(textBox3.Text);
            class4 = int.Parse(textBox4.Text);
            class5 = int.Parse(textBox5.Text);
            class6 = int.Parse(textBox6.Text);

            tot = class1 + class2 + class3 + class4 + class5 + class6;

            textBox8.Text = tot.ToString();

            avg = tot / 6;

            textBox9.Text = avg.ToString();

            if (avg > 79)
            {
                textBox7.Text = "A";
            }
            else if (avg > 69)
            {
                textBox7.Text = "B";
            }
            else if (avg > 59)
            {
                textBox7.Text = "C";
            }
            else if (avg > 49)
            {
                textBox7.Text = "D";
            }
            else
            {
                textBox7.Text = "F";
            }
            }
        }
    }


