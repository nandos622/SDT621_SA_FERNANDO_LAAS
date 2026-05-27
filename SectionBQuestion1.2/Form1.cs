using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SectionBQuestion1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length >0)
            {
                MessageBox.Show("Hello " + txtName.Text + "!");
            } else
            {
                MessageBox.Show("Please enter your name!");
            }
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
