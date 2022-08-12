using Guna.UI2.WinForms;
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


        private int GetCountCrystals()
        {
            int count = 0;
            foreach (var item in this.Controls)
            {
                if (item is Guna2PictureBox gb)
                {
                    if (gb.Image.Width == 800)
                    {
                        count++;
                    }
                }
            }
            return count;
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

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

            if (Global.kristalsayi >= 1)
            {

                Global.kristalsayi -= 1;
                guna2PictureBox2.Image = Properties.Resources.kristal_goy;
            }

        }
        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

            if (Global.kristalsayi >= 2)
            {
                Global.kristalsayi -= 2;
                guna2PictureBox2.Image = Properties.Resources.kristal_goy;
                guna2PictureBox3.Image = Properties.Resources.kristal_goy;
            }

        }
        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

            if (Global.kristalsayi >= 3)
            {

                Global.kristalsayi -= 3;
                guna2PictureBox2.Image = Properties.Resources.kristal_goy;
                guna2PictureBox3.Image = Properties.Resources.kristal_goy;
                guna2PictureBox4.Image = Properties.Resources.kristal_goy;
            }

        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            int count = GetCountCrystals();
            guna2PictureBox2.Image = Properties.Resources.kristal_bos;
            guna2PictureBox3.Image = Properties.Resources.kristal_bos;
            guna2PictureBox4.Image = Properties.Resources.kristal_bos;
            Global.kristalsayi += count;
        }
    }
}
