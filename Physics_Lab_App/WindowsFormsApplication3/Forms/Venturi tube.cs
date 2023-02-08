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
    public partial class Venturi_tube : Form
    {
        public Venturi_tube()
        {
            InitializeComponent();
        }

        double a1, a2,  v2, dl, dm, H,D,r,q;

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox1.Text);
            a2 = Convert.ToDouble(textBox2.Text);
           dl = Convert.ToDouble(textBox3.Text);
            dm = Convert.ToDouble(textBox4.Text);
            H = Convert.ToDouble(textBox5.Text); q = a2 * v2;
            label7.Text = q.ToString();
            D = (2 * dl * 980 * H) / (dm * (Math.Pow(a1, 2) - Math.Pow(a2, 2)));
            r = Math.Pow(D, 0.5);
            v2 = a1 * r;
            label6.Text = v2.ToString();

          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                        Messageboxforms.VT m = new Messageboxforms.VT();
            m.Show();
        }
    }
}
