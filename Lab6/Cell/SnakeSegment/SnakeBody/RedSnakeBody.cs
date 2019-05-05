namespace Lab6.Cell.SnakeSegment.SnakeBody
{
    public class RedSnakeBody : ISnakeBody
    {
        private const string RED_SNAKE_BODY = "snake_red_body.png";

        private ICellImage _image;

        public RedSnakeBody()
        {
            _image = new CellImage(RED_SNAKE_BODY);
        }

        public ICellImage Image => _image;
    }
}
