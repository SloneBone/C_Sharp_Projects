using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Let's have some fun with lists and arrays!");
        Console.WriteLine("Press Enter to Start.");
        Console.ReadLine();

        //This an array of the players in the starting Line-Up for the Portland Trailblazers! Go Blazers!
        string[] strArray = { "CJ McCollum", "Damian Lillard", "Jones Jr.", "Robert Covington", "Jusuf Nurkic" };
        Console.WriteLine("Please select an index from 0 - 4: ");
        int strArray_Index = Convert.ToInt32(Console.ReadLine());
        if (strArray_Index > 4)
        {
            Console.WriteLine("This is not a valid index");
            Console.WriteLine("Closing Program.");
            Console.ReadLine();
            System.Environment.Exit(0);
        }

        Console.WriteLine("You have chosen index number: " + strArray_Index);
        Console.WriteLine("The content at your chosen index number is: " + strArray[strArray_Index]);

        //This is an array of the corresponding players number for each of the starting 5. Go Blazers!
        int[] numArray = { 3, 0, 55, 23, 27 };
        Console.WriteLine("Please select an index from 0 - 4:");
        int numArray_Index = Convert.ToInt32(Console.ReadLine());
        if (numArray_Index > 4)
        {
            Console.WriteLine("This is not a valid index.");
            Console.WriteLine("Closing Program.");
            Console.ReadLine();
            System.Environment.Exit(0);
        }


        
            

        Console.WriteLine("You have chosen index number: " + numArray_Index);
        Console.WriteLine("The content at your chosen index number is: " + numArray[numArray_Index]);

        


        //List of  some major assassinations in the US. Never Forget!
        List<string> Assassinations = new List<string>();
        Assassinations.Add("Malcom X");
        Assassinations.Add("John Lennon");
        Assassinations.Add("Martin Luther King");
        Assassinations.Add("John F Kennedy");
        Assassinations.Add("Abraham Lincoln");

        Console.WriteLine("Select an index from 0 - 4: ");
        int strLstIndex = Convert.ToInt32(Console.ReadLine());
        if (strLstIndex > 4)
        {
            Console.WriteLine("This is not a valid index.");
            Console.WriteLine("Closing Program.");
            Console.ReadLine();
            System.Environment.Exit(0);
        }

        Console.WriteLine("You have chosen index number: " + strLstIndex);
        Console.WriteLine("The content of your chosen index number is: " + Assassinations[strLstIndex]);
        Console.ReadLine();
        Console.WriteLine("Thank you for playing. Have a nice day!");
        Console.WriteLine("Press Enter to End");
        Console.ReadLine();
        

        

        


    }
}

