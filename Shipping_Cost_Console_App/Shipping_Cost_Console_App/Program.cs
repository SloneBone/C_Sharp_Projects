using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Cost_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int ship_Weight = Convert.ToInt32(Console.ReadLine());

            if (ship_Weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
                Console.WriteLine("Closing Program");
                Console.ReadLine();
                System.Environment.Exit(0);
                
            }
           

            Console.WriteLine("Please enter the package width:");
            int ship_Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int ship_Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int ship_Length = Convert.ToInt32(Console.ReadLine());
            int ship_dimensions = (ship_Width + ship_Length + ship_Height);

            if (ship_dimensions > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");
                Console.WriteLine("Closing Program.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }



            //implement volume for W*L*H to make cleaner 
            int ship_Volume = (ship_Height * ship_Width * ship_Length);
            decimal ship_Cost = Convert.ToDecimal(ship_Volume * ship_Weight) / 100;
            Console.WriteLine("Your estimated shipping cost for this package: {0:C2}", ship_Cost);
            Console.WriteLine("Thank You");
            
            Console.ReadLine();



        }
    }
}
