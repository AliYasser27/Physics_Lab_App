using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3.Messageboxforms
{
    public partial class MF : Form
    {
        public MF()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        

            MessageBox.Show("Create by Eng:Ali Maher");
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
              
            MessageBox.Show("Create by Eng:Ali Maher");
        
        }
    }
}
