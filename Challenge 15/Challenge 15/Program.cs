using System;
using System.Collections.Generic;

namespace Challenge_15
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GRIDSIZE = 20;
            long[,] grid = new long[GRIDSIZE + 1, GRIDSIZE + 1];

            for (int y = GRIDSIZE; y >= 0; y--)
            {
                for (int x = GRIDSIZE; x >= 0; x--)
                {
                    if (x + 1 <= GRIDSIZE)
                    {
                        if (grid[x + 1, y] == 0)
                        {
                            grid[x, y]++;
                        }
                        else
                        {
                            grid[x, y] += grid[x + 1, y];
                        }
                    }
                    if (y + 1 <= GRIDSIZE)
                    {
                        if (grid[x, y + 1] == 0)
                        {
                            grid[x, y]++;
                        }
                        else
                        {
                            grid[x, y] += grid[x, y + 1];
                        }
                    }
                }
            }

            Console.WriteLine(grid[0, 0]);
            Console.ReadLine();
        }
    }
}
