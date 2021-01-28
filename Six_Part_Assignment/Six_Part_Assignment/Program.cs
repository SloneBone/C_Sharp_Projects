using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Part_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Ford", "Mazda", "Tesla", "Chevy", "Subaru" };
            Console.WriteLine("Input some text: ");
            string carInput = Console.ReadLine();

            ////Creating a loop that iterates through each string in the array and 
            ////adds the user's text input to the end of each string. This step will not output
            ////anything to the console but will update each array element by appending the user's text.
            for (int i = 0; i < cars.Length; i++)
            {
                string appendElement = cars[i] + carInput;
                //Console.WriteLine(appendElement);

            }
            Console.WriteLine("Input Saved");
            Console.ReadLine();

            //Creating a for loop that prints off each string in the array on a seperate line
            Console.WriteLine("Press Enter to see each appended element.");
            Console.ReadLine();
            for (int i = 0; i < cars.Length; i++)
            {

                Console.WriteLine(cars[i] + carInput);
                Console.ReadLine();
            }

            ////Creating an infinite loop and then fixing the loop to execute properly
            Console.WriteLine("Let's try and infite loop!");
            Console.ReadLine();
            int[] guesses_MarblesInJar = { 177, 299, 300, 457, 199, 931, 7, 438 };
            //Commenting the infinit loop out
            //for (int i = 0; i < guesses_MarblesInJar.Length; i--)
            //replacing it with corrected syntax
            Console.WriteLine("Ooops looks like we had to fix that infinite loop. Carry On!");
            Console.WriteLine("Press Enter.");
            Console.ReadLine();
            for (int i = 0; i < guesses_MarblesInJar.Length; i++)
            {
                //This displayed value is equal to the number of iterations [i] in guesses_MarblesInJar
                Console.WriteLine("Index: {0}", i);
                //Display each guess in the array
                Console.WriteLine("Guess of how many Marbles are in the Jar: " + guesses_MarblesInJar[i]);
                Console.ReadLine();
            }
            Console.ReadLine();

            Console.WriteLine("Let's check out some movies!!");
            List<int> rottenTomotoes_Rating = new List<int>() { 96, 98, 94, 97, 100, 96, 98, 95, 93, 70, 80, 50, 12, 66 };


            ////Creating a loop where the comparison that is used to determine whether to continue iterating the loop is a '<' operator
            foreach (int Rating in rottenTomotoes_Rating)
            {
                if (Rating < 99 && Rating > 85)
                {
                    Console.WriteLine("The Rating of this movie is: " + Rating);
                    Console.WriteLine("This movie is highly rated. Enjoy!");
                    Console.ReadLine();
                }
            }

            //Creating a loop where the comparison that is used to determine whether to continue iterating the loop is a '<=' operator.
            foreach (int Rating in rottenTomotoes_Rating)
            {
                if (Rating <= 85)
                {
                    Console.WriteLine("The rating of this movie is: " + Rating);
                    Console.WriteLine("This movie is not highly rated...");
                    Console.ReadLine();
                }
            }
            //Creating a loop that takes user input to see if the list contains a matching item and to display its index
            List<string> Fruits = new List<string>() { "apple", "orange", "pear", "strawberry", "pineapple", "mango" };
            Console.WriteLine("Input a fruit: ");
            string fruit_Input = Console.ReadLine().ToLower();
            
            foreach (string fruit in Fruits)
            {
                if (fruit_Input == fruit)
                {
                    Console.WriteLine(fruit_Input + " Exists at index: " + Fruits.IndexOf(fruit_Input));
                    
                    break;
                }
                else if (fruit_Input != fruit)
                {
                    continue;
                }
               
            }


            
        
            Console.WriteLine("Let's loop through some lists!");
            Console.ReadLine();

            //Add the following to your console app and perform these actions:
            //1. A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            //2. Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.
            //3. Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
            //4. Save and execute your code.

            List<string> Names = new List<string>() { "James", "Drew", "Annie", "Jacob", "Annie", "James", "Bob" };
            Console.WriteLine("To check for possible duplicates, please select from these options:\n \"Bob\", \"Drew\", \"Annie\", \"Jacob\", and \"James\"");

            List<int> name_Index = new List<int>() { };
            bool isValid = false;
            while (isValid == false)
            {
                string name_Input = Console.ReadLine();

                for (int name = 0; name < Names.Count(); name++)
                {
                    if (Names[name] == name_Input)
                    {
                        name_Index.Add(name);
                        isValid = true;
                    }
                }
                if (isValid == true && name_Index.Count() > 1)
                {
                    Console.WriteLine("Your duplicate search entry of \"" + name_Input + "\" has duplicate entries at " + name_Index.Count() + " indices.");
                    foreach (int i in name_Index)
                    {
                        if (i < name_Index.Last())
                        {
                            Console.WriteLine("Index: " + i);
                        }
                        else
                        {
                            Console.WriteLine("Index: " + i);
                        }
                    }
                }
                else if (isValid == true)
                {
                    Console.WriteLine("Your entry, \"" + name_Input + "\" was found at index location: " + name_Index[0]);
                }
                else
                {
                    Console.WriteLine("Your input of \"" + name_Input + "\" does not exist. Please Try Again. \n Select from these available options: \"Bob\", \"Drew\", \"Annie\", \"Jacob\", and \"James\"");
                }

            }
            Console.ReadLine();

            //Add the following to your console app and perform these actions:
            //1.Create a list of strings that has at least two identical strings in the list.
            //2.Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            //3.Save and execute your code.
            Console.WriteLine("Let's keep on looping! We're almost done!");
            Console.WriteLine("Press enter to run the loop!");
            Console.ReadLine();
            List<string> matrixChars = new List<string>() { "Neo", "Trinity", "Neo", "Morpheus", "Cypher", "Morpheus", "Apoc", "Trinity" };
            var duplicates = matrixChars.GroupBy(s => s.ToUpper())
                                    .Where(g => g.Count() > 1)
                                    .Select(g => g.Key);
            List<string> storage = new List<string>();

            foreach (var dupe in duplicates)
            {
                Console.WriteLine(dupe + " Has duplicate values");
            }
            foreach( string Character in matrixChars)
            {
                if (storage.Contains(Character))
                {
                    Console.WriteLine("This item already appears in the list: " + Character);
                }
                else
                {
                    storage.Add(Character);
                }
            }
            Console.ReadLine();
                    //foreach (string Character in matrixChars)
                    //{
                    //    Console.WriteLine(matrixChars.Distinct().Count());
                    //    Console.ReadLine();
                    //    Console.WriteLine(matrixChars.Count());
                    //}















            }
        }
    }


