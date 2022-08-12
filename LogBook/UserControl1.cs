using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook
{
    public partial class UserControl1 : UserControl
    {

        public string Name
        {
            get
            {
                return guna2HtmlLabel3.Text;
            }
            set
            {
                guna2HtmlLabel3.Text = value;
            }
        }

        public string Number { get { return guna2HtmlLabel1.Text; } set { guna2HtmlLabel1.Text = value; } }

        public string Date
        {
            get
            {
                return guna2HtmlLabel2.Text;
            }
            set
            {
                guna2HtmlLabel2.Text = value;
            }
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //hghj
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
