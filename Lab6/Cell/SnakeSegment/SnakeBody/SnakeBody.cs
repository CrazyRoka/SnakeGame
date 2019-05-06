namespace Lab7.Cell.SnakeSegment.SnakeBody
{
    public class SnakeBody : ISnakeBody
    {
        private ICellImage _image;

        public SnakeBody(string imagePath)
        {
            _image = new CellImage(imagePath);
        }

        public ICellImage Image => _image;
    }
}
