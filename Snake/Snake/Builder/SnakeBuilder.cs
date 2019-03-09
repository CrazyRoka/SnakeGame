using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Cell.SnakeSegment;
using TochIndustries.SnakeGame.Model.Factory;
using TochIndustries.SnakeGame.Model.Position;

namespace TochIndustries.SnakeGame.Model.Snake.Builder
{
    class SnakeBuilder : ISkinBuilder
    {
        private readonly List<AbstractSnakeSegment> segments;
        private ISkinFactory skinFactory;

        public SnakeBuilder(ISkinFactory skinFactory, IPosition position)
        {
            this.skinFactory = skinFactory;
            this.segments = new List<AbstractSnakeSegment> { new HeadSegment(skinFactory.CreateHeadSkin(), position) } ;
        }

        public SnakeBuilder(ISkinFactory skinFactory, ISnake snake)
        {
            this.skinFactory = skinFactory;
            this.segments = snake.Segments as List<AbstractSnakeSegment>;
        }

        public void ChangeSkin(ISkinFactory skinFactory)
        {
            this.skinFactory = skinFactory;
        }

        public ISnake Build()
        {
            foreach(var segment in segments)
            {
                segment.ChangeSkin(skinFactory.CreateBodySkin());
            }

            segments[0].ChangeSkin(skinFactory.CreateHeadSkin());

            return new Snake(segments);
        }
    }
}
