using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor1
{
    class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public string Choice()
        {
            string[] choices = { "stone", "paper", "scissor" };
            Random random = new Random();
            return choices[random.Next(3)];
        }
    }

    class Game
    {
        public void Play()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Computer");

            while (player1.Score < 10 && player2.Score < 10)
            {
                Console.Write($"{player1.Name}, enter your choice (stone, paper, scissor): ");
                string player1Choice = Console.ReadLine().ToLower();
                string player2Choice = player2.Choice();
                Console.WriteLine($"{player2.Name} chose: {player2Choice}");

                string result = Winner(player1Choice, player2Choice);

                if (result == "Player 1")
                {
                    player1.Score++;
                    Console.WriteLine($"{player1.Name} wins this round!");
                }
                else if (result == "Player 2")
                {
                    player2.Score++;
                    Console.WriteLine($"{player2.Name} wins this round!");
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }

                Console.WriteLine($"Score: {player1.Name}: {player1.Score} - {player2.Name}: {player2.Score}");
            }

            if (player1.Score == 10)
            {
                Console.WriteLine($"{player1.Name} wins the game!");
            }
            else
            {
                Console.WriteLine($"{player2.Name} wins the game!");
            }
        }

        private string Winner(string choice1, string choice2)
        {
            if (choice1 == choice2)
                return "Tie";

            if ((choice1 == "stone" && choice2 == "scissor") ||
                (choice1 == "scissor" && choice2 == "paper") ||
                (choice1 == "paper" && choice2 == "stone"))
            {
                return "Player 1";
            }
            else
            {
                return "Player 2";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Play();
        }
    }
}
