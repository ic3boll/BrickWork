using Brickwork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brickwork
{
    public class LayerBuilder : ILayerBuilder
    {
        public int[][] firstLayer { get; set; }

        public LayerBuilder(ILayerConfig config)
        {
            firstLayer = new int[config.N][];
            for (int i = 0; i < config.N; i++)
            {
                firstLayer[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            }
        }
    }
}
