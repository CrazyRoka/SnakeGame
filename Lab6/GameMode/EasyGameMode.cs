using Lab8.Cell.Food;
using System;

namespace Lab8.GameMode
{
    public class EasyGameMode : IGameMode
    {
        public IFood GenerateFood()
        {
            var food = new Apple();
            var foodWithSous = new Sous(food);
            var foodWithSousAndKetchup = new Ketchup(foodWithSous);

            return foodWithSousAndKetchup;
        }
    }
}
