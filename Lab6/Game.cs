using Lab8.Cell;
using Lab8.Cell.Food;
using Lab8.Cell.Positions;
using Lab8.GameMode;
using System.Collections.Generic;

namespace Lab8
{
    public class Game
    {
        private const int Width = 10;
        private const int Height = 10;

        private IFood _food;
        private ICell[,] _map;
        private IGameMode _gameMode;
        private Position _foodPosition;
        private List<Position> _snakeSegments;
        public Game(IGameMode gameMode)
        {
            SetUpGameMode(gameMode);
            CreateMap();
            Draw();
        }

        private void SetUpGameMode(IGameMode gameMode)
        {
            _gameMode = gameMode;
            _food = _gameMode.GenerateFood();
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

        public void SetState(GameMemento memento)
        {
            _snakeSegments = new List<Position>(memento.SnakeSegments);
            _foodPosition = memento.FoodPosition;
        }

        public GameMemento SaveState()
        {
            return new GameMemento()
            {
                SnakeSegments = new List<Position>(_snakeSegments),
                FoodPosition = _foodPosition
            };
        }
    }
}
