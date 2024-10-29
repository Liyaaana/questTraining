using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperGame1
{
    class Minesweeper
    {
        static char[,] grid;
        static bool[,] mines;
        static int size = 5;
        static int minesCount = 5;

        public static void Main()
        {
            InitializeGame();
            PlayGame();
        }

        static void InitializeGame()
        {
            grid = new char[size, size];
            mines = new bool[size, size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    grid[i, j] = '*';
                    mines[i, j] = false;
                }
            }

            int placedMines = 0;
            while (placedMines < minesCount)
            {
                int row = random.Next(size);
                int col = random.Next(size);

                if (!mines[row, col])
                {
                    mines[row, col] = true;
                    placedMines++;
                }
            }
        }
        static void PlayGame()
        {
            while (true)
            {
                PrintGrid();
                Console.Write("Enter row index (0-4): ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Enter column index (0-4): ");
                int col = int.Parse(Console.ReadLine());

                if (mines[row, col])
                {
                    Console.WriteLine("Boom! You hit a mine. Game Over.");
                    break;
                }
                else
                {
                    grid[row, col] = ' ';
                    Console.WriteLine("Safe! Keep going.");
                }
            }
        }
        static void PrintGrid()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
