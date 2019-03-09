using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Cell;
using TochIndustries.SnakeGame.Model.Map;

namespace TochIndustries.SnakeGame.Model.Skin
{
    public interface ISkin
    {
        void Draw(ICell cell, IMap map);
    }
}
