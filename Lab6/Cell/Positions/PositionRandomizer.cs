using System;

namespace Lab7.Cell.Positions
{
    public class PositionRandomizer
    {
        private static PositionRandomizer _instance;

        private Random _random;
        private PositionRandomizer() => _random = new Random();

        public static PositionRandomizer Instance => _instance = _instance ?? new PositionRandomizer();

        public Position GeneratePosition(int width, int height)
        {
            return new Position
            {
                X = _random.Next(width),
                Y = _random.Next(height)
            };
        }
    }
}
