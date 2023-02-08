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
    public partial class Magnetic_Field : Form
    {
        double MI0, MI1, MI2, MI3, MI4, MI5, MLI0, ML1, ML2, ML3, ML4, ML5, FM0, FM1, FM2, FM3, FM4, FM5, FL1, FL2, FL3, FL4, FL5, SlopeI1, SlopeI2, SlopeI3, SlopeI4, AvgSlopeI, SlopeL1, SlopeL2, SlopeL3, SlopeL4, AvgSlopeL, B1, B2;
        public Magnetic_Field()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MI0 = Convert.ToDouble(textBox1.Text);
            MI1 = Convert.ToDouble(textBox2.Text);
            MI2 = Convert.ToDouble(textBox3.Text);
            MI3 = Convert.ToDouble(textBox4.Text);
            MI4 = Convert.ToDouble(textBox5.Text);
            MI5 = Convert.ToDouble(textBox6.Text);
            MI0 = MI0 / 1000;
            MI1 = MI1 / 1000;
            MI2 = MI2 / 1000;
            MI3 = MI3 / 1000;
            MI4 = MI4 / 1000;
            MI5 = MI5 / 1000;

            FM0 = (MI0 - MI0) * 9.8;
            label11.Text = FM0.ToString();
            FM1 = (MI1 - MI0) * 9.8;
            label12.Text = FM1.ToString();
            FM2 = (MI2 - MI0) * 9.8;
            label13.Text = FM2.ToString();
            FM3 = (MI3 - MI0) * 9.8;
            label14.Text = FM3.ToString();
            FM4 = (MI4 - MI0) * 9.8;
            label15.Text = FM4.ToString();
            FM5 = (MI5 - MI0) * 9.8;
            label16.Text = FM5.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SlopeI1 = (FM2 - FM1) / (2 - 1);
            SlopeI2 = (FM3 - FM2) / (3 - 2);
            SlopeI3 = (FM4 - FM3) / (4 - 3);
            SlopeI4 = (FM5 - FM4) / (5 - 4);
            AvgSlopeI = (SlopeI1 + SlopeI2 + SlopeI3 + SlopeI4) / 4;
            if (AvgSlopeI < 0)
            { AvgSlopeI = AvgSlopeI * -1; }
            B1 = (AvgSlopeI * 1000) / 0.064;
            label38.Text = B1.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            label11.Text = "ـــــــــــــــــــ";
            label12.Text = "ـــــــــــــــــــ";
            label13.Text = "ـــــــــــــــــــ";
            label14.Text = "ـــــــــــــــــــ";
            label15.Text = "ـــــــــــــــــــ";
            label16.Text = "ـــــــــــــــــــ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MLI0 = Convert.ToDouble(textBox11.Text);
            ML1 = Convert.ToDouble(textBox7.Text);
            ML2 = Convert.ToDouble(textBox13.Text);
            ML3 = Convert.ToDouble(textBox8.Text);
            ML4 = Convert.ToDouble(textBox9.Text);
            ML5 = Convert.ToDouble(textBox10.Text);
            MLI0 = MLI0 / 1000;
            ML1 = ML1 / 1000;
            ML2 = ML2 / 1000;
            ML3 = ML3 / 1000;
            ML4 = ML4 / 1000;
            ML5 = ML5 / 1000;
            FL1 = (ML1 - MLI0) * 9.8;
            label30.Text = FL1.ToString();
            FL2 = (ML2 - MLI0) * 9.8;
            label31.Text = FL2.ToString();
            FL3 = (ML3 - MLI0) * 9.8;
            label32.Text = FL3.ToString();
            FL4 = (ML4 - MLI0) * 9.8;
            label33.Text = FL4.ToString();
            FL5 = (ML5 - MLI0) * 9.8;
            label34.Text = FL5.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SlopeL1 = (FL2 - FL1) / (0.022 - 0.012);
            SlopeL2 = (FL3 - FL2) / (0.032 - 0.022);
            SlopeL3 = (FL4 - FL3) / (0.042 - 0.032);
            SlopeL4 = (FL5 - FL4) / (0.064 - 0.010);
            AvgSlopeL = (SlopeL1 + SlopeL2 + SlopeL3 + SlopeL4) / 4;
            B2 = (AvgSlopeL * 1000) / 2;
            label39.Text = B2.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            textBox13.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            label30.Text = "ـــــــــــــــــــ";
            label31.Text = "ـــــــــــــــــــ";
            label32.Text = "ـــــــــــــــــــ";
            label33.Text = "ـــــــــــــــــــ";
            label34.Text = "ـــــــــــــــــــ";
            
        }
    }
}
