using Lab7.Cell.SnakeSegment.SnakeBody;

namespace Lab7.Factories
{
    public interface ISnakeFactory
    {
        ISnakeBody GetSnakeBody(string imagePath);
    }
}
