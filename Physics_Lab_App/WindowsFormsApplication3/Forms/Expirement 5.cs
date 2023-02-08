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
    public partial class Expirement_5 : Form
    {
        public Expirement_5()
        {
            InitializeComponent();
        }
        double mw, ml, Q, W, I, V, cw, cl, J, t, T1, T2, T, Pw;
        private void button1_Click(object sender, EventArgs e)
        {
            mw = Convert.ToDouble(textBox1.Text);
            ml = Convert.ToDouble(textBox2.Text);
            cw = Convert.ToDouble(textBox3.Text);
            cl = Convert.ToDouble(textBox4.Text);
            I = Convert.ToDouble(textBox5.Text);
            V = Convert.ToDouble(textBox6.Text);
            T1 = Convert.ToDouble(textBox7.Text);
            T2 = Convert.ToDouble(textBox8.Text);
            t = Convert.ToDouble(textBox9.Text);
            T = T2 - T1;
            Math.Abs(T);
            t = t * 60;
            Q = ((ml * cl) + (mw * cw)) * T;
            Pw = V * I;
            W = Pw * t;
            J = W / Q;
            label1.Text = T.ToString();
            label2.Text = t.ToString();
            label3.Text = Pw.ToString();
            label4.Text = Q.ToString();
            label5.Text = W.ToString();
            label6.Text = J.ToString();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "00.00";
            label3.Text = "00.00";
            label4.Text = "00.00"; 
            label6.Text = "00.00";
            label1.Text = "00.00";
            label5.Text = "00.00";
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
         

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Messageboxforms.heat_msg m = new Messageboxforms.heat_msg();
            m.Show();
        }
    }
}
