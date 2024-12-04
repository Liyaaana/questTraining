using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static Dictionary<int, int> snakes = new Dictionary<int, int> {
            { 16, 6 }, { 47, 26 }, { 49, 11 }, { 56, 53 },
            { 62, 19 }, { 64, 60 }, { 87, 24 }, { 93, 73 },
            { 95, 75 }, { 98, 78 }
        };

        static Dictionary<int, int> ladders = new Dictionary<int, int> {
            { 1, 38 }, { 4, 14 }, { 9, 31 }, { 21, 42 },
            { 28, 84 }, { 36, 44 }, { 51, 67 }, { 71, 91 },
            { 80, 100 }
        };

        static void Main()
        {
            int player1Position = 0;
            int player2Position = 0;
            // Initializes a Random object for dice rolls.
            Random random = new Random();

            while (true)
            {
                player1Position = PlayTurn("Player 1", player1Position, random);
                if (player1Position >= 100)
                {
                    Console.WriteLine("Player 1 wins!");
                    break;
                }

                player2Position = PlayTurn("Player 2", player2Position, random);
                if (player2Position >= 100)
                {
                    Console.WriteLine("Player 2 wins!");
                    break;
                }
            }
        }

        static int PlayTurn(string playerName, int playerPosition, Random random)
        {
            Console.WriteLine($"{playerName}, press Enter to roll the die...");
            Console.ReadLine(); // Waits for the player to press Enter
            int diceRoll = random.Next(1, 7);
            Console.WriteLine($"{playerName} rolled a {diceRoll}.");

            playerPosition += diceRoll;
            if (playerPosition > 100)
            {
                playerPosition = 100;
            }

            if (snakes.ContainsKey(playerPosition))
            {
                Console.WriteLine($"{playerName} landed on a snake! Moved down from {playerPosition} to {snakes[playerPosition]}.");
                playerPosition = snakes[playerPosition];
            }
            else if (ladders.ContainsKey(playerPosition))
            {
                Console.WriteLine($"{playerName} landed on a ladder! Moved up from {playerPosition} to {ladders[playerPosition]}.");
                playerPosition = ladders[playerPosition];
            }
            else
            {
                Console.WriteLine($"{playerName} is now on square {playerPosition}.");
            }

            return playerPosition;
        }
    }
}
