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
    public partial class Expirement_4 : Form
    {
        public Expirement_4()
        {
            InitializeComponent();
        }
        double x1, x2, x3, b1, b2, b3, m1, m2, m3, sum1, sum2, sum3, sum4, sum5, sum6, avg1, avg2,
             avg3, avg4, avg5, avg6, avg12, avg34, avg56, xd1, xd2, xd3, bd1, bd2, bd3, md1, md2, md3, p, p1;
        private void button1_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox1.Text);
            x2 = Convert.ToDouble(textBox2.Text);
            x3 = Convert.ToDouble(textBox3.Text);
            sum1 = x1 + x2 + x3;
            avg1 = sum1 / 3;
            label1.Text = avg1.ToString();
            xd1 = x1 - avg1; xd2 = x2 - avg1;
            xd3 = x3 - avg1; if (xd1 < 0) { xd1 = xd1 * -1; }
            if (xd2 < 0) { xd2 = xd2 * -1; } if (xd3 < 0) { xd3 = xd3 * -1; }
            label2.Text = xd1.ToString(); label3.Text = xd2.ToString();
            label4.Text = xd3.ToString(); sum2 = xd1 + xd2 + xd3; avg2 = sum2 / 3;
            label5.Text = avg2.ToString();
            b1 = Convert.ToDouble(textBox4.Text);
            b2 = Convert.ToDouble(textBox5.Text);
            b3 = Convert.ToDouble(textBox6.Text);
            sum3 = b1 + b2 + b3; avg3 = sum3 / 3;
            label6.Text = avg3.ToString();
            bd1 = b1 - avg3; bd2 = b2 - avg3; bd3 = b3 - avg3;
            if (bd1 < 0) { bd1 = bd1 * -1; }
            if (bd2 < 0) { bd2 = bd2 * -1; }
            if (bd3 < 0) { bd3 = bd3 * -1; }
            label7.Text = bd1.ToString();
            label8.Text = bd2.ToString();

            label9.Text = bd3.ToString();

            sum4 = bd1 + bd2 + bd3; avg4 = sum4 / 3;
            label10.Text = avg4.ToString();
            m1 = Convert.ToDouble(textBox7.Text);
            m2 = Convert.ToDouble(textBox8.Text);
            m3 = Convert.ToDouble(textBox9.Text);
            sum5 = m1 + m2 + m3; avg5 = sum5 / 3;
            label11.Text = avg5.ToString();
            md1 = m1 - avg5; md2 = m2 - avg5; md3 = m3 - avg5;
            if (md1 < 0) { md1 = md1 * -1; }
            if (md2 < 0) { md2 = md2 * -1; }
            if (md3 < 0) { md3 = md3 * -1; }
            label12.Text = md1.ToString();
            label13.Text = md2.ToString();
            label14.Text = md3.ToString();
            sum6 = md1 + md2 + md3; avg6 = sum6 / 3;
            label15.Text = avg6.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            avg12 = avg1 - avg2;
            label16.Text = avg12.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            avg34 = avg3 - avg4;
            label17.Text = avg34.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            avg56 = avg5 - avg6;
            label18.Text = avg56.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p = ((avg56 * 4) / (3.14 * avg12 * avg12 * avg34));
            label19.Text = p.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p1 = p * (2 * (avg2 / avg12) + (avg4 / avg34) + (avg6 / avg56)); label20.Text = p1.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
           
            label1.Text = "Δd";
            label2.Text = "00.00";
            label3.Text = "00.00";
            label4.Text = "00.00";
            label5.Text = "Δd'";
            label6.Text = "Δl";
            label7.Text = "00.00";
            label8.Text = "00.00";
            label9.Text = "00.00";
            label10.Text = "Δl'";
            label11.Text = "Δm";
            label12.Text = "00.00";
            label13.Text = "00.00";
            label14.Text = "00.00";
            label15.Text = "Δm'";
            label16.Text = "00.00";
            label17.Text = "00.00";
            label18.Text = "00.00";
            label19.Text = "00.00";
            label20.Text = "00.00";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Messageboxforms.m m = new Messageboxforms.m();
            m.Show();
        }
    }
}
