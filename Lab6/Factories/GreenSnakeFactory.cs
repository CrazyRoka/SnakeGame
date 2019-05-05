using Lab6.Cell.SnakeSegment.SnakeBody;
using Lab6.Cell.SnakeSegment.SnakeHead;

namespace Lab6.Factories
{
    public class GreenSnakeFactory : ISnakeFactory
    {
        public ISnakeBody GetSnakeBody() => new GreenSnakeBody();

        public ISnakeHead GetSnakeHead() => new GreenSnakeHead();
    }
}
