using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Cell.FoodCell;
using TochIndustries.SnakeGame.Model.Position;

namespace TochIndustries.SnakeGame.Model.Factory
{
    class FoodFactory : IFoodFactory
    {
        private ISkinFactory skinFactory;

        public FoodFactory(ISkinFactory skinFactory)
        {
            this.skinFactory = skinFactory;
        }

        public AbstractFood CreateFood(IPosition position, int power = 1)
        {
            return new Food(skinFactory.CreateFoodSkin(), position, power);
        }
    }
}
