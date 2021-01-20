using System;
using System.Linq;
 
namespace Brickwork
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                var dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

                var n = dimensions[0];
                var m = dimensions[1];

                LayerConfig config = new LayerConfig(n, m);
                LayerBuilder buildLayer = new LayerBuilder(config);
                BrickWork brickWork = new BrickWork(config);
                brickWork.Print(buildLayer.firstLayer);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }



        }
    }
}