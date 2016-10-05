using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
            label5.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
          double a, b, p, s;
          p =(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text))*2;
          s = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);               ;
            textBox3.Text = Convert.ToString(p);
            textBox4.Text = Convert.ToString(s);
            label4.Visible = true;
            label5.Visible =true;
            textBox3.Visible = true;
            textBox4.Visible = true;

        }
    }
}
