using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// logic by mishel 
namespace MinesweeperGame
{
    internal class Minesweeper
    {
        // declare a private two-dimensional array (grid) of type CellState. It has dimensions 5x5.
        private CellState[,] grid = new CellState[5, 5];

        public Minesweeper()
        {
            InitGrid(); // initializes the grid with random CellState values.
            RenderGrid(); // displays the grid.
        }
        private void InitGrid()
        {
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // Generates a random integer (0, 1, or 2) and converts it to a CellState enum value like Point1, Point2 or Mine.
                    var state = (CellState)random.Next(0, 3);
                    grid[i, j] = state;
                }
            }
        }

        private void RenderGrid()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($" ({grid[i, j]}) ");
                }
                Console.WriteLine(); // it simply prints an empty line (i.e., a newline) to the console.
            }
        }
    }
}
