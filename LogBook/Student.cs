using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook
{
    public class Student
    {
        public int Id { get; set; }
        public static int Static_Id { get; set; } = 0;
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime Date { get; set; }
        public Student()
        {
            Id = ++Static_Id;
        }
    }
}
