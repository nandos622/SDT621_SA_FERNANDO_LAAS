using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SectionC
{
    public partial class Form1 : Form
    {
        List<string[]> mobilePhones = new List<string[]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] mobilePhone = mobilePhones.Find((string[] mpb) => mpb[0] == txtCode.Text);
            if (mobilePhone != null)
            {
                lblOutput.Text = "Record deleted!";
                mobilePhones.Remove(mobilePhone);
            } else
            {
                lblOutput.Text = "Record not found!";
                MessageBox.Show("No matching record found");
            }
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string[] mobilePhone = mobilePhones.Find((string[] mbp) => mbp[0] == txtCode.Text);
            if (mobilePhone != null)
            {
                lblOutput.Text = "Record found!";
            }
            else
            {
                lblOutput.Text = "Record NOT found!";
                MessageBox.Show("No matching record found");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mobileCode = txtCode.Text;
            string make = txtMake.Text;
            int quantity;
            try
            {
                quantity = int.Parse(txtQuantity.Text);
                if (quantity < 0)
                {
                    throw new Exception();
                }
                if (mobilePhones.Find((string[] mbp) => mbp[0] == txtCode.Text) != null)
                {
                    MessageBox.Show("This mobile code is already in use");
                }
            }
            catch
            {
                MessageBox.Show("Enter a valid quantity");
                return;
            }

            string[] mobilePhone = new string[] {
                mobileCode, 
                make, 
                quantity.ToString()
            };

            mobilePhones.Add(mobilePhone);
            lblOutput.Text = "Record added";
        }

        private void tblMobilePhones_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
