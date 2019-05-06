using System;

namespace Lab6.Cell.Food
{
    public class Food : IFood
    {
        private static Lazy<Food> _instance = new Lazy<Food>();

        private uint _power;
        private Food()
        {
            // Read power from config file
            _power = 1;
        }

        public uint Power => _power;

        public static Food Instance => _instance.Value;
    }
}
