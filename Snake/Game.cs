using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Cell;
using TochIndustries.SnakeGame.Model.Cell.FoodCell;
using TochIndustries.SnakeGame.Model.Factory;
using TochIndustries.SnakeGame.Model.Map;
using TochIndustries.SnakeGame.Model.Position;
using TochIndustries.SnakeGame.Model.Position.Randomizer;
using TochIndustries.SnakeGame.Model.Snake;
using TochIndustries.SnakeGame.Model.Snake.Builder;

namespace TochIndustries.SnakeGame.Model
{
    public class Game
    {
        private IMap map;
        private ISnake snake;
        private uint minFoodCount = 1;
        private IFoodFactory foodFactory;
        private List<AbstractFood> foods = new List<AbstractFood>();

        public void CreateNewGame(ISkinFactory skinFactory)
        {
            IPosition startPosition = positionRandomizer.RandomizePosition();
            SnakeBuilder builder = new SnakeBuilder(skinFactory, startPosition);

            this.map = map;
            this.snake = builder.Build();
            this.foods = new List<AbstractFood>();
            this.foodFactory = new FoodFactory(skinFactory);

        }

        public void SetMinFoodCount(uint minFoodCount) => this.minFoodCount = minFoodCount;

        public void SetSkinFactory(ISkinFactory skinFactory)
        {
            throw new NotSupportedException();
        }

        public void StartNewGame()
        {
            GenerateFood();
        }

        public void GenerateFood()
        {
            List<ICell> forbiddenCells = snake.Segments as List<ICell>;
            forbiddenCells.AddRange(foods);
            while(foods.Count < minFoodCount)
            {
                IPosition position = PositionRandomizer.GetInstance.CreateRandomPosition(forbiddenCells);
                var food = foodFactory.CreateFood(position);
                foods.Add(food);
                forbiddenCells.Add(food);
            }
        }
    }
}
