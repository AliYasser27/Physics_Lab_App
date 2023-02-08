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
    public partial class expirement_1 : Form
    {
        public expirement_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double v1, v2, v3, v4, r1, r2, r3, r4;

            v1= Convert.ToDouble(textBox1.Text);
            v2= Convert.ToDouble(textBox2.Text);
            v3= Convert.ToDouble(textBox3.Text);
            v4= Convert.ToDouble(textBox4.Text);

            r1 = v1 / 6;
            r2 = v2 / 6;
            r3= v3 / 6;
            r4= v4 / 6;

            label12.Text = r1.ToString();
            label13.Text = r2.ToString();
            label14.Text = r3.ToString();
            label15.Text = r4.ToString();



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void expirement_1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(0);
            textBox2.Text = Convert.ToString(0);
            textBox3.Text = Convert.ToString(0);
            textBox4.Text = Convert.ToString(0);
            textBox5.Text = Convert.ToString(0);
            textBox6.Text = Convert.ToString(0);
            textBox7.Text = Convert.ToString(0);
            textBox8.Text = Convert.ToString(0);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2, r;
            n1 = Convert.ToDouble(textBox5.Text);
            n2= Convert.ToDouble(textBox6.Text);

            r = n2 / n1;

            label22.Text = r.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double v1, v2, r;
            v1= Convert.ToDouble(textBox7.Text);
            v2= Convert.ToDouble(textBox8.Text);

            r = v2 / v1;

            label23.Text = r.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Messageboxforms.k m = new Messageboxforms.k();
            m.Show();
        }
    }
}
