using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {

            if (this.PanelDesktop.Controls.Count > 0)
                this.PanelDesktop.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PanelDesktop.Controls.Add(f);
            this.PanelDesktop.Tag = f;
            f.Show();
        }
            
        

    
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Capictor";
            loadform(new Forms.Experiment_2());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Forms.Magnetic_Field());
            label1.Text = "Magnetic Field";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Venturi Tube";
            loadform(new Forms.Venturi_tube());
        }

      

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "Electrical Equivalent of Heat";
            loadform(new Forms.Expirement_5());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Transformer";
            loadform(new Forms.expirement_1());
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "Measurments";
            loadform(new Forms.Expirement_4());
        }

        private void PanelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
            label1.Text = "HOME";
        }
        }
    }

