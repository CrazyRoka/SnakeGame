using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Cell.SnakeSegment;

namespace TochIndustries.SnakeGame.Model.Snake
{
    public enum Direction
    {
        top,
        right,
        bottom,
        left
    }

    interface ISnake
    {
        void Move(Direction direction);

        IEnumerable<AbstractSnakeSegment> Segments { get; }
    }
}
