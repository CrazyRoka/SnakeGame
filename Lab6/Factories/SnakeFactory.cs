using Lab7.Cell.SnakeSegment.SnakeBody;
using System.Collections.Generic;

namespace Lab7.Factories
{
    public class SnakeFactory : ISnakeFactory
    {
        private Dictionary<string, ISnakeBody> _bodies = new Dictionary<string, ISnakeBody>();

        public ISnakeBody GetSnakeBody(string imagePath)
        {
            if (_bodies.ContainsKey(imagePath))
            {
                return _bodies[imagePath];
            }
            return _bodies[imagePath] = new SnakeBody(imagePath);
        }
    }
}
