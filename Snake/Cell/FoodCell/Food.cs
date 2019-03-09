using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Position;
using TochIndustries.SnakeGame.Model.Skin;

namespace TochIndustries.SnakeGame.Model.Cell.FoodCell
{
    class Food : AbstractFood
    {
        private int power;

        public Food(ISkin skin, IPosition position, int power = 1) : base(skin, position)
        {
            this.power = power;
        }

        public override int Power => power;
    }
}
