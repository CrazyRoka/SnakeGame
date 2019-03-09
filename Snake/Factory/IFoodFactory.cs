using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Cell.FoodCell;
using TochIndustries.SnakeGame.Model.Position;

namespace TochIndustries.SnakeGame.Model.Factory
{
    interface IFoodFactory
    {
        AbstractFood CreateFood(IPosition position, int power = 1);
    }
}
