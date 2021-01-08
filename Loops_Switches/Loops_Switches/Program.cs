using System;


namespace Loops_Switches
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Welcome to Slone's MiniGame Party Extravanganza!");
            Console.WriteLine("Good Luck!?");
            Console.ReadLine();
            Console.WriteLine("MiniGame #1: Guess my favorite color?");
            string myColor = Convert.ToString(Console.ReadLine());
            bool color_Guessed = myColor == "Blue";

            while (!color_Guessed)
            {
                switch (myColor)
                {
                    default:
                        Console.WriteLine("You guessed the wrong color.");
                        Console.WriteLine("Guess a color?");
                        myColor = Console.ReadLine();
                        break;
                    case "White":
                        Console.WriteLine("Did you know that White contains all wavelengths of visible light...And also is not my favorite color. Sorry! Try again.");
                        Console.WriteLine("Guess a color?");
                        myColor = Console.ReadLine();
                        break;
                    case "Blue":
                        Console.WriteLine("That is correct. That is my favorite color!! You know me so well!");
                        myColor = Console.ReadLine();
                        color_Guessed = true;
                        break;
                    case "Black":
                        Console.WriteLine("Hmm the absence of all visible light. Try Again.");
                        Console.WriteLine("Guess a color?");
                        myColor = Convert.ToString(Console.ReadLine());
                        break;

                }
            }

            Console.WriteLine("MiniGame #2: Solve the riddle..." );
            Console.ReadLine();
            Console.WriteLine("Find the next number in the sequence 1, 4, 9, 16, 25, ?");
            Console.WriteLine("Enter your answer: ");
            
            
            int nextNumber = Convert.ToInt32(Console.ReadLine());
            bool num_Guessed = nextNumber == 36;

            do
            {
                switch (nextNumber)
                {
                    default:
                        Console.WriteLine("That is not correct! Try again.");
                        Console.WriteLine("The next number in the sequence is...");
                        nextNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 36:
                        Console.WriteLine("You are correct. WOW! Way to go!!");
                        Console.ReadLine();
                        Console.WriteLine("Closing Program");
                        num_Guessed = true;
                        break;
                }
            }
            while (!num_Guessed);


            Console.Read();

        //    Console.WriteLine("Guess a number?");
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    bool isGuessed = number == 12;

        //    do
        //    {
        //        switch (number)
        //        {
        //            case 62:
        //                Console.WriteLine("You guessed 62. Try again.");
        //                Console.WriteLine("Guess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 29:
        //                Console.WriteLine("You guessed 29. Try again.");
        //                Console.WriteLine("Guess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 55:
        //                Console.WriteLine("You guessed 55. Try again.");
        //                Console.WriteLine("Guess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 12:
        //                Console.WriteLine("You guessed the number 12. THat is CORRECT!");
        //                isGuessed = true;
        //                break;
        //            default:
        //                Console.WriteLine("You are wrong...");
        //                Console.WriteLine("Guess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;

        //        }
        //    }
        //    while (!isGuessed);
            
            
        //    Console.Read();
        }
    }
}
