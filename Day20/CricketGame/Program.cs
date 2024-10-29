using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public bool IsOut { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
            IsOut = false;
        }

        public void Play()
        {
            Random random = new Random();
            int computer = random.Next(1, 7);

            Console.WriteLine("Enter a number (1 to 6): ");
            int playerChoice = int.Parse(Console.ReadLine());

            if (playerChoice == computer)
            {
                IsOut = true;
                Console.WriteLine($" You are out.");
            }
            else
            {
                Score += playerChoice;
                Console.WriteLine($"You scored {playerChoice} runs. Total score: {Score}");
            }
        }
    }

    public class Game
    {
        public Player Player { get; set; }

        public Game(string playerName)
        {
            Player = new Player(playerName);
        }

        public void Start()
        {
            while (!Player.IsOut)
            {
                Player.Play();
            }

            Console.WriteLine($"Game Over! Your total score is: {Player.Score}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string playerName = Console.ReadLine();

            Game game = new Game(playerName);
            game.Start();
        }
    }
}
