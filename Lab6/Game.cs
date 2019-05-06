using Lab7.Cell;
using Lab7.Cell.Positions;
using Lab7.Cell.SnakeSegment;
using System.Collections.Generic;

namespace Lab7
{
    public class Game
    {
        private const int Width = 10;
        private const int Height = 10;

        private ICell[,] _map;
        private Position _foodPosition;
        private List<Position> _snakeSegments;
        public Game()
        {
            CreateMap();
            Draw();
        }

        private void CreateMap()
        {
            _map = new ICell[Height, Width];
            _foodPosition = PositionRandomizer.Instance.GeneratePosition(Width, Height);
            _snakeSegments.Add(PositionRandomizer.Instance.GeneratePosition(Width, Height));
        }

        private void Draw()
        {
            // Draw game board
        }

        public void MoveForward()
        {
            // Movement logic
            Draw();
        }

        public void TurnRight()
        {
            // Turn right
            Draw();
        }

        public void TurnLeft()
        {
            // Turn left
            Draw();
        }
    }
}
