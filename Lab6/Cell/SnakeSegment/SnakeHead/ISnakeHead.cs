using Lab6.Enums;

namespace Lab6.Cell.SnakeSegment.SnakeHead
{
    public interface ISnakeHead : ISnakeSegment
    {
        Direction Direction { get; set; }

        void OpenMouth();
        void CloseMouth();
    }
}
