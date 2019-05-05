using Lab6.Cell.SnakeSegment.SnakeBody;
using Lab6.Cell.SnakeSegment.SnakeHead;

namespace Lab6.Factories
{
    public interface ISnakeFactory
    {
        ISnakeHead GetSnakeHead();
        ISnakeBody GetSnakeBody();
    }
}
