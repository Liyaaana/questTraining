using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissor.Entities;

namespace RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors!");
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Player user = new Player(userName);
            Player computer = new Player("Computer");

            int winningPoints = 5; 

            while (user.Points < winningPoints && computer.Points < winningPoints)
            {
                Console.WriteLine($"{user.Name}, choose:");
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Console.Write("Enter your move (1/2/3): ");

                int userMove = 0;
                bool validInput = false;

                while (!validInput)
                {
                    if (int.TryParse(Console.ReadLine(), out userMove))
                    {
                        if (userMove >= 1 && userMove <= 3)
                            validInput = true;
                        else
                            Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                    }
                }

                user.Move = userMove;

                Random random = new Random();
                computer.Move = random.Next(1, 4);

                string result = Winner(user.Move, computer.Move);
                Console.WriteLine($"Computer chose {computer.Move}");
                Console.WriteLine($"Result: {result}");

                if (result.Contains(user.Name))
                    user.Points++;
                else if (result.Contains(computer.Name))
                    computer.Points++;

                Console.WriteLine($"{user.Name} Points: {user.Points} | Computer Points: {computer.Points}\n");
            }

            if (user.Points >= winningPoints)
                Console.WriteLine($"{user.Name} wins! Congratulations!");
            else
                Console.WriteLine("Computer wins! Better luck next time!");
        }

        static string Winner(int move1, int move2)
        {
            if (move1 == move2)
                return "It's a tie!";
            else if ((move1 == 1 && move2 == 3) ||
                     (move1 == 2 && move2 == 1) ||
                     (move1 == 3 && move2 == 2))
                return $"{move1} beats {move2}. {move1} wins!";
            else
                return $"{move2} beats {move1}. {move2} wins!";
        }
    }
}
          
