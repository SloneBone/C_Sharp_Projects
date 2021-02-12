using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace Classes_Objects_21_CardGame
{
    class Program
    {
        static void Main(string[] args)
        {

            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine($"Welcome to the {casinoName}. Let's start by telling mee your name.");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();


                }
                Console.Read();
                return;
            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\dslon\Logs\logs.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;

                player.isActivelyPlaying = true; 
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact your admin.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            Console.Read();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();

            }
            return Exceptions;

        }




        //DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);
        //DateTime yearofBirth = new DateTime(1986, 30, 23, 8, 45, 20); 
        //DateTime yearofGraduation = new DateTime(2013, 6, 1, 16, 32, 22);
        //TimeSpan ageAtGraduation = yearofGraduation - yearofBirth;
        //ageAtGraduation.
        //string text = "Here is some text";
        //File.WriteAllText(@"C:\Users\dslon\Logs\log.txt", text);
        //string text = File.ReadAllText(@"C:\Users\dslon\Logs\log.txt");
        //var player = new Player("Drew");
        //Player newPlayer = new Player("Drew");
        //Guid identifier = new Guid();--THis will be all zeros


        //List<Game> games = new List<Game>();
        //TwentyOneGame game = new TwentyOneGame();
        //games.Add(game);
        //TwentyOneGame game = new TwentyOneGame();
        //game.Players = new List<string>() { "Drew", "Bill", "Joe" };
        //game.ListPlayers();
        //Console.ReadLine();

        //TwentyOneGame game = new TwentyOneGame();
        //Game game = new Game();
        //game.Players = new List<string>() { "Drew", "Bill", "Joe" };
        //game.ListPlayers();
        //game.Play();
        //Console.ReadLine();
        //Game game = new TwentyOneGame();
        //game.Players = new List<Player>();
        //Player player = new Player();
        //player.Name = "Drew";
        //game = game + player; Note: Shorthand 
        //game += player;
        //game = game - player;
        //game -= player;
        //Player<Card> player = new Player<Card>();

        //DaysOfTheWeek day = DaysOfTheWeek.Tuesday;
        //ConsoleColor color = ConsoleColor.DarkRed;

        //Card card = new Card();
        //card.Suit = Suit.Clubs;
        //int underlyingValue = Convert.ToInt32(Suit.Diamonds);
        //Console.WriteLine(underlyingValue);


        //Deck deck = new Deck();
        //deck.Shuffle(times: 3);
        //foreach (Card card in deck.Cards)
        //{
        //    Console.WriteLine(card.Face + " of " + card.Suit);
        //}
        //Console.WriteLine(deck.Cards.Count());
        //Console.WriteLine();
        //Console.ReadLine();

        //int count = deck.Cards.Count(x => x.Face == Face.Ace);
        //Console.WriteLine(count);

        //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
        //foreach (Card card in newList)
        //{
        //    Console.WriteLine(card.Face);
        //}

        //List<int> numberList = new List<int>() { 4, 6, 7, 2, 33, 342, 445 };
        //int sum = numberList.Sum(x => x + 5);
        //int sum = numberList.Max();
        //int sum = numberList.Min();
        //int sum = numberList.Where(x => x > 20).Sum();
        //Console.WriteLine(sum);



        //int counter = 0;
        //foreach(Card card in deck.Cards)
        //{
        //    if (card.Face == Face.Ace)
        //    {
        //        counter++;
        //    }
        //}
        //Console.WriteLine(counter);
        //Console.ReadLine();








        //public enum DaysOfTheWeek
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday, 
        //    Saturday,
        //    Sunday
        //}


        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
