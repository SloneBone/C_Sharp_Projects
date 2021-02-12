using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Challenge_3
{
     public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
