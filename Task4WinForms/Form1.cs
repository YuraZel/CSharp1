using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4WinForms
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
            double x, f, z, y;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            f = Math.Pow(y + Math.Pow(x - 1, 1.0 / 3), 1.0 / 4) / Math.Abs(x - y) / (Math.Pow(Math.Sin(z), 2) + Math.Tan(z));
            textBox4.Text = Convert.ToString(f);
            label4.Visible = true;
            textBox4.Visible = true;
        }
    }
}
