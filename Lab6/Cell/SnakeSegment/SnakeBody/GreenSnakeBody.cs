using System;

namespace Lab6.Cell.SnakeSegment.SnakeBody
{
    public class GreenSnakeBody : ISnakeBody
    {
        private const string GREEN_SNAKE_BODY = "snake_green_body.png";

        private ICellImage _image;

        public GreenSnakeBody()
        {
            _image = new CellImage(GREEN_SNAKE_BODY);
        }

        public ICellImage Image => _image;
    }
}
