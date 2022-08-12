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
    public partial class Form1 : Form
    {
        public int kristalsayi = 5;
        public Form1()
        {
            InitializeComponent();
            List<Student> students = new List<Student>
          {
              new Student
              {
                  Name ="Cosqun",
                  SurName ="Gulmemmedli",
                  Date=DateTime.Now,
              },
                new Student
              {
                  Name ="Eli ",
                  SurName ="Huseyinov",
                  Date=DateTime.Now,
              },
                  new Student
              {
                  Name ="Murad",
                  SurName ="Gulmemmedli",
                  Date=DateTime.Now,
              },

          };
            int x = 0;
            int y = 200;
           
                foreach (var item in students)
                {
                    UserControl1 userControl = new UserControl1();
                    userControl.Name = item.Name;
                    userControl.Date = DateTime.Now.ToShortDateString();
                    userControl.Number=item.Id.ToString();
                    userControl.Location = new Point(x, y);
                    y += 100;
                    this.Controls.Add(userControl);
                }
        }

       
        
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if(item is UserControl1 uc)
                {
                    foreach (var item1 in uc.Controls)
                    {
                        if(item1 is Guna2RadioButton rb)
                        {
                            if (rb.BackColor == Color.Transparent) { rb.Checked = true;}
                            
                        }
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
