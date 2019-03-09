using TochIndustries.SnakeGame.Model.Position;
using TochIndustries.SnakeGame.Model.Skin;
using TochIndustries.SnakeGame.Model.Snake;

namespace TochIndustries.SnakeGame.Model.Cell.SnakeSegment
{
    abstract class AbstractSnakeSegment : AbstractCell
    {
        public AbstractSnakeSegment(ISkin skin, IPosition position) : base(skin, position) { }

        public Direction Direction { get; }

        public override bool IsEmpty() => false;
    }
}
