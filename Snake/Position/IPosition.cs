using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Snake;

namespace TochIndustries.SnakeGame.Model.Position
{
    public interface IPosition
    {
        void Move(Direction direction);
    }
}
