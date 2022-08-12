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
                    userControl.Date = DateTime.Now.ToString();
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
    }
}
