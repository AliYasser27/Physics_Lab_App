using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3.Forms
{
    public partial class Experiment_2 : Form
    {
        public Experiment_2()
        {
            InitializeComponent();
        }

        private void Experiment_2_Load(object sender, EventArgs e)
        {

        }

        double c1, c2, c3, c4, c5, c6, slope, fsp, c11, c12, c13, c01, c02, c03, e1, e2, e3, sumxy, sumx;

        private void button1_Click(object sender, EventArgs e)
        {
            c1 = Convert.ToDouble(textBox1.Text);
            c2 = Convert.ToDouble(textBox2.Text);
            c3 = Convert.ToDouble(textBox3.Text);
            c4 = Convert.ToDouble(textBox4.Text);
            c5 = Convert.ToDouble(textBox5.Text);
            c6 = Convert.ToDouble(textBox6.Text);
            sumxy = (c1 * 4.00 + c2 * 2.00 + c3 * 1.3333 + c4 * 1.00 + c5 * 0.80 + c6 * 0.66) * Math.Pow(10, -10);
            sumx = Math.Pow(400, 2) + Math.Pow(200, 2) + Math.Pow(133.3, 2) + Math.Pow(100, 2) + Math.Pow(80, 2) + Math.Pow(66.67, 2);
            slope = sumxy / sumx;
            label13.Text = slope.ToString();
            fsp = slope / 0.2544;
            label14.Text = fsp.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c11 = Convert.ToDouble(textBox7.Text);
            c12 = Convert.ToDouble(textBox9.Text);
            c13 = Convert.ToDouble(textBox11.Text);
            c01 = Convert.ToDouble(textBox8.Text);
            c02 = Convert.ToDouble(textBox10.Text);
            c03 = Convert.ToDouble(textBox12.Text);
            e1 = c11 / c01;
            e2 = c12 / c02;
            e3 = c13 / c03;
            label17.Text = e1.ToString();
            label18.Text = e2.ToString();
            label19.Text = e3.ToString();
        }
    }
}
