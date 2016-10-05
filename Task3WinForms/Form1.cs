using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;                      
            textBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double x, a, b, y;
            x = Convert.ToDouble(textBox1.Text);
            a = Convert.ToDouble(textBox2.Text);
            b = Convert.ToDouble(textBox3.Text);
            y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Sin(a - b) * Math.Sin(a - b) + 1.0 / 100 * (x - b); ;
            textBox4.Text = Convert.ToString(y);
            label4.Visible = true;
            textBox4.Visible = true;
        }
    }
}
