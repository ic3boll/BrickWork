using Brickwork.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brickwork
{
    public class LayerConfig : ILayerConfig
    {

        public int N { get; }

        public int M { get; }

        public LayerConfig(int N, int M)
        {
            if (N % 2 != 0 || M % 2 != 0)
            {
                throw new ArgumentException("N or M can be only even numbers");
            }
            else if(N>98 && M>100)
            {
                throw new ArgumentException("N or M can be only under 100");
            }
            else if(N >= M && N == M)
            {
                throw new ArgumentException("Shape must be rectangular");
            }
         
            this.N = N;
            this.M = M;
        }

    }
}
