using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Logs
{
    class Program
    {
        static void Main(string[] args)
        {

            //Perform these actions and create a console app that includes the following:
            //1.Asks the user for a number.
            Console.WriteLine("Hello!  Please enter a number: ");
            string writeNum = Console.ReadLine();

            //2.Logs that number to a text file.
            File.WriteAllText(@"C:\Users\dslon\Logs\log.txt", writeNum);

            //3.Prints the text file back to the user.
            string readNum = File.ReadAllText(@"C:\Users\dslon\Logs\log.txt");
            Console.WriteLine(readNum);
            Console.ReadLine();



            //using (StreamWriter file = new StreamWriter(@"C:\Users\dslon\Logs\log.txt", true))
            //{
            //    file.WriteLine(writeNum);
            //}

            
            
        }
    }
}
