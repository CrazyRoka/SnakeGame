using Lab6.Enums;

namespace Lab6.Cell.SnakeSegment.SnakeHead
{
    public class RedSnakeHead : ISnakeHead
    {
        private const string RED_SNAKE_HEAD = "snake_red_head.png";
        private const string RED_SNAKE_OPEN_HEAD = "snake_red_open_head.png";

        private ICellImage _image;

        public RedSnakeHead()
        {
            _image = new CellImage(RED_SNAKE_HEAD);
            Direction = Direction.Up;
        }

        public Direction Direction { get; set; }
        public ICellImage Image => _image; // { _image.Rotate(Direction); return _image; }

        public void CloseMouth()
        {
            _image = new CellImage(RED_SNAKE_HEAD);
        }

        public void OpenMouth()
        {
            _image = new CellImage(RED_SNAKE_OPEN_HEAD);
        }
    }
}
