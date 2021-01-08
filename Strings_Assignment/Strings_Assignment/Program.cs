using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Assignment
{
    class Program
    {
        static void Main()
        {
            //ASSIGNMENT
            //Create a console app that does / includes the following:

            //1 Concatenates three strings.

            //2 Converts a string to uppercase.

            //3 Creates a Stringbuilder and builds a paragraph of text, one sentence at a time.

            StringBuilder sb = new StringBuilder("Excerpt from JFK Inauguration Address 1961: ", 20);
            sb.Append("\nIn the long history of the world, only a few generations have been granted the role of defending freedom in its hour of maximum danger. ");
            sb.Append("I do not shrink from this responsibility -- I welcome it. ");
            sb.Append("I do not believe that any of us would exchange places with any other people or any other generation. ");
            sb.Append("The energy, the faith, the devotion which we bring to this endeavor will light our country and all who serve it ");
            sb.AppendLine("-- and the glow from that fire can truly light the world.");
            sb.AppendLine("And so, my fellow Americans: ask not what your country can do for you -- ask what you can do for your country.");
            sb.Append("My fellow citizens of the world: ask not what America will do for you, but what together we can do for the freedom of man.");


            Console.WriteLine(sb);
            Console.ReadLine();

            string name = "Drew";
            string startDay = "Monday Jan. 11, 2021";
            string project = "Python Live Project";
            string reminder = "Hello " + name + ",\nThis is a reminder about your " + project + " starting on " + startDay + ". Be there or be square!";
            Console.WriteLine(reminder);
            Console.ReadLine();

            string dinner = "spicy miso ramen with chasu pork ";
            dinner = dinner.ToUpper();
            Console.WriteLine("Tonight's Dinner is: " + dinner);
            Console.Read();


            
        }
    }
}
