using System;
using System.Collections.Generic;
using System.Text;

namespace TochIndustries.SnakeGame.Model.Map
{
    class Dimension
    {
        public Dimension(int width, int heigh)
        {
            Width = width;
            Heigh = heigh;
        }

        int Width { get; }
        int Heigh { get; }
    }
}
