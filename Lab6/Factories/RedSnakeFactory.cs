using Lab6.Cell.SnakeSegment.SnakeBody;
using Lab6.Cell.SnakeSegment.SnakeHead;

namespace Lab6.Factories
{
    public class RedSnakeFactory : ISnakeFactory
    {
        public ISnakeBody GetSnakeBody() => new RedSnakeBody();

        public ISnakeHead GetSnakeHead() => new RedSnakeHead();
    }
}
