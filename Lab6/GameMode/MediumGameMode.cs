using Lab8.Cell.Food;
using System;

namespace Lab8.GameMode
{
    public class MediumGameMode : IGameMode
    {
        public IFood GenerateFood()
        {
            var rand = new Random();
            IFood food = new Apple();

            if (rand.NextDouble() >= 0.5) food = new Sous(food);
            if (rand.NextDouble() >= 0.3) food = new Ketchup(food);

            return food;
        }
    }
}
