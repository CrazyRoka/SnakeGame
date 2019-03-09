using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Cell;
using TochIndustries.SnakeGame.Model.Map;

namespace TochIndustries.SnakeGame.Model.Position.Randomizer
{
    class PositionRandomizer
    {
        private static Lazy<PositionRandomizer> instance = new Lazy<PositionRandomizer>();
        public static PositionRandomizer GetInstance => instance.Value;

        public IPosition CreateRandomPosition(Dimension dimension) => CreateRandomPosition(dimension, new ICell[]{});
        public IPosition CreateRandomPosition(Dimension dimension, IEnumerable<ICell> forbiddenCells)
        {

        }
    }
}
