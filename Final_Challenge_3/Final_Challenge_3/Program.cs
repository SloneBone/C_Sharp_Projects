using System;

namespace Final_Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill"  };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            Console.WriteLine("Lets Check the dB!");
            Console.WriteLine("Success!");

        }
    }
}
