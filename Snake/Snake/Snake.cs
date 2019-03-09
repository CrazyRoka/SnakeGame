using System;
using System.Collections.Generic;
using TochIndustries.SnakeGame.Model.Cell.SnakeSegment;

namespace TochIndustries.SnakeGame.Model.Snake
{
    class Snake : ISnake
    {
        private readonly List<AbstractSnakeSegment> segments;

        public Snake(List<AbstractSnakeSegment> segments)
        {
            this.segments = segments;
        }

        public IEnumerable<AbstractSnakeSegment> Segments => segments;

        public void Move(Direction direction)
        {
            throw new NotImplementedException();
        }
    }
}
