using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Position;
using TochIndustries.SnakeGame.Model.Skin;

namespace TochIndustries.SnakeGame.Model.Cell.FoodCell
{
    abstract class AbstractFood : AbstractCell
    {
        public AbstractFood(ISkin skin, IPosition position) : base(skin, position) { }

        public abstract int Power { get; }

        public override bool IsEmpty() => false;
    }
}
