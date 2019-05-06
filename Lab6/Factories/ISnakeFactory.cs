using Lab8.Cell.SnakeSegment.SnakeBody;

namespace Lab8.Factories
{
    public interface ISnakeFactory
    {
        ISnakeBody GetSnakeBody(string imagePath);
    }
}
