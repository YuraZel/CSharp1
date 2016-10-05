using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m, n, z1, z2;
            m = Convert.ToDouble(textBox1.Text);
            n = Convert.ToDouble(textBox2.Text);
            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + Math.Pow(m, 2) - m);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            textBox3.Text = Convert.ToString(z1);
            textBox4.Text = Convert.ToString(z2);
            label3.Visible = true;
            label4.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;



        }
    }
}
