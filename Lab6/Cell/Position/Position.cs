using System;

namespace Lab6.Cell.Position
{
    public struct Position : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public object Clone()
        {
            return new Position
            {
                X = X,
                Y = Y
            };
        }
    }
}
