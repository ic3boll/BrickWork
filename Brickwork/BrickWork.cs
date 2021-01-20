using Brickwork.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brickwork
{
    public class BrickWork : IBrickWork
    {
        private readonly ILayerConfig config;
        public BrickWork(ILayerConfig config)
        {
            this.config = config;
        }

        public void Print(int[][] firstLayer)
        {
            int blockCounter = 1;
            int[][] secondLayer = new int[config.N][];

            for (int row = 0; row < config.N; row++)
            {
                secondLayer[row] = new int[config.M];
            }


            for (int row = 0; row < config.N; row++)
            {
                for (int col = 0; col < config.M; col++)
                {
                    if (secondLayer[row][col] > 0)
                    {
                        continue;
                    }
                    if (col == config.M - 1 && row < config.N - 1)
                    {
                        secondLayer[row][col] = blockCounter;
                        secondLayer[row + 1][col] = blockCounter;
                        blockCounter++;
                    }
                    else if (firstLayer[row][col] != firstLayer[row][col + 1]) //Check collumns
                    {
                        if (row >= 4 && row == config.N - 2)
                        {
                            if (firstLayer[row][col] == firstLayer[row + 2][col])
                            {
                                throw new ArgumentException("The brick must be exacly 2 rows! ");

                            }
                        }
                        secondLayer[row][col] = blockCounter;
                        secondLayer[row][col + 1] = blockCounter;
                        blockCounter++;
                        col++;
                    }
                    else //Check rows
                    {
                       if(col+3 > config.M )
                       {
                            if (firstLayer[row][col - 1] == firstLayer[row][col + 1])
                            {

                                throw new ArgumentException("The brick must be exacly 2 colls! ");
                            }
                       }
                       else
                        {
                            if (firstLayer[row][col] == firstLayer[row][col + 2])
                            {
                                throw new ArgumentException("The brick must be exacly 2 colls! ");
                            }
                        }

                        secondLayer[row][col] = blockCounter;
                        secondLayer[row + 1][col] = blockCounter;
                        blockCounter++;
                    }
                }
            }

            for (int i = 0; i < config.N; i++)
            {
                Console.WriteLine(string.Join(" ", secondLayer[i]));
            }
        }
    }
}
