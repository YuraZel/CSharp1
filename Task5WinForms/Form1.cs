using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5WinForms
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

            double x,z,y,t;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            t = 2 * Math.Cos(x - Math.PI / 6) / (0.5 + Math.Pow(Math.Sin(y), 2)) * (1 + Math.Pow(z, 2) / (3 - z * z / 5));
            textBox4.Text = Convert.ToString(t);
            label4.Visible = true;
            textBox4.Visible = true;
        }
    }
}
