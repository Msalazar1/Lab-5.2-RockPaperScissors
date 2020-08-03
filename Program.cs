using System;

namespace Lab5._2RockPaperScissors
{

    enum Throw
    {
        Rock,
        Paper,
        Scissors
    }

    abstract class Player
    {

        public Throw theThrow { get; set; }
        public string playerName { get; set; }

        public abstract Throw GenerateRoshambo();

        public override string ToString()
        {
            int ordinal = (int)theThrow;
            return $"{theThrow}";
        }
    }
    
    class Horde : Player
    {
        private static Random rand = new Random();
        public override Throw GenerateRoshambo()
        {
            int rps = rand.Next(0, 3);
            Throw randomRPS = (Throw)rps;
            return randomRPS;
        }
        
    }
    class Alliance : Player
    {
        public override Throw GenerateRoshambo()
        {
            return Throw.Rock; 
        }
    }
    class UserPlayer : Player
    {
        public override Throw GenerateRoshambo()
        {
            int UserInput = 0;
            Console.WriteLine("Choose your weapon: Rock, Paper, or Scissors:");
            Console.WriteLine();
            string UserChoice = Console.ReadLine().ToLower();
            
            

                switch (UserChoice )
                {
                    

                    case "rock":
                        UserInput = 0;
                        break;

                    case "paper":
                        UserInput = 1;
                        break;

                    case "scissors":
                        UserInput = 2;
                        break;

                    default:
                        Console.WriteLine("Unable to translate your your uncommon language. Here's a rock.");
                        break;



                }
            
            var UserThrow = (Throw)UserInput;

            return UserThrow;
        }
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            Horde hordePlayer = new Horde();
            Alliance alliancePlayer = new Alliance();
            UserPlayer player1 = new UserPlayer();

            Console.WriteLine("Welcome to the World of Warcraft Roshambo Battleground Event!");
            Console.WriteLine();
            Console.WriteLine("What is your name, brave contestant?");
            Console.WriteLine();
            player1.playerName = Console.ReadLine();
            Console.WriteLine("Will you be playing against the Horde or the Alliance?");
            Console.WriteLine();

            string HoA = Console.ReadLine().ToLower();
            
            bool keepgoing = true;
            while (keepgoing == true)
            {
                
                if (HoA == "horde")
                {
                    Player player2 = new Horde
                    {
                        playerName = "The Horde"
                    };
                    do
                    {
                        player1.theThrow = player1.GenerateRoshambo();
                        
                        player2.theThrow = player2.GenerateRoshambo();
                        

                        Console.WriteLine($"{player1.playerName} throws {player1.theThrow}.");
                        Console.WriteLine();
                        Console.WriteLine($"{player2.playerName} throws {player2.theThrow}.");
                        Console.WriteLine();

                        if (player1.theThrow == player2.theThrow )
                        {
                            Console.WriteLine("Great fight but the match was a draw.");
                            Console.WriteLine();
                        }
                        else if ((int)player1.theThrow == 0 && (int)player2.theThrow == 2 || (int)player1.theThrow == 1 && (int)player2.theThrow == 0 
                            || (int)player1.theThrow == 2 && (int)player2.theThrow == 1)
                        {
                            Console.WriteLine("You have vanquished your foe!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("You have been defeated!");
                            Console.WriteLine();

                        }
                        Console.WriteLine("Do you want to go again? y/n");
                        string giveUp = Console.ReadLine().ToLower();
                        if (giveUp != "y")
                        {
                            keepgoing = false;
                        }
                        else
                        {
                            keepgoing = true;
                        }


                    } while (keepgoing);
                } 
                else if (HoA == "alliance")
                {
                    Player player2 = new Alliance
                    {
                        playerName = "The Alliance"
                    };
                    do
                    {
                        player1.theThrow = player1.GenerateRoshambo();

                        player2.theThrow = player2.GenerateRoshambo();


                        Console.WriteLine($"{player1.playerName} throws {player1.theThrow}.");
                        Console.WriteLine();
                        Console.WriteLine($"{player2.playerName} throws {player2.theThrow}.");
                        Console.WriteLine();

                        if (player1.theThrow == player2.theThrow)
                        {
                            Console.WriteLine("Great fight but the match was a draw.");
                            Console.WriteLine();
                        }
                        else if ((int)player1.theThrow == 0 && (int)player2.theThrow == 2 || (int)player1.theThrow == 1 && (int)player2.theThrow == 0
                            || (int)player1.theThrow == 2 && (int)player2.theThrow == 1)
                        {
                            Console.WriteLine("You have vanquished your foe!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("You have been defeated!");
                            Console.WriteLine();
                        }
                        Console.WriteLine("Do you want to go again? y/n");
                        string giveUp = Console.ReadLine().ToLower();
                        if (giveUp != "y")
                        {
                            keepgoing = false;
                        }
                        else
                        {
                            keepgoing = true;
                        }

                    } while (keepgoing);
                }


            }
        }
    }
}
