using Lab6.Enums;

namespace Lab6.Cell.SnakeSegment.SnakeHead
{
    public class GreenSnakeHead : ISnakeHead
    {
        private const string GREEN_SNAKE_HEAD = "snake_green_head.png";
        private const string GREEN_SNAKE_OPEN_HEAD = "snake_green_open_head.png";

        private ICellImage _image;

        public GreenSnakeHead()
        {
            _image = new CellImage(GREEN_SNAKE_HEAD);
            Direction = Direction.Up;
        }

        public Direction Direction { get; set; }
        public ICellImage Image => _image; // { _image.Rotate(Direction); return _image; }

        public void CloseMouth()
        {
            _image = new CellImage(GREEN_SNAKE_HEAD);
        }

        public void OpenMouth()
        {
            _image = new CellImage(GREEN_SNAKE_OPEN_HEAD);
        }
    }
}
