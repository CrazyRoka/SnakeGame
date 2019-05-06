using System;

namespace Lab7.Cell.Positions
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

        public static bool operator ==(Position first, Position second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Position first, Position second)
        {
            return first.Equals(second) == false;
        }

        public override bool Equals(object obj)
        {
            if(obj is Position position)
            {
                return X == position.X && Y == position.Y;
            }
            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }
    }
}
