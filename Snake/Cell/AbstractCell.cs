using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Map;
using TochIndustries.SnakeGame.Model.Position;
using TochIndustries.SnakeGame.Model.Skin;

namespace TochIndustries.SnakeGame.Model.Cell
{
    abstract class AbstractCell : ICell
    {
        private ISkin skin;
        private IPosition position;

        public AbstractCell(ISkin skin, IPosition position)
        {
            this.skin = skin;
            this.position = position;
        }

        public IPosition Position => position;

        public abstract bool IsEmpty();

        public void Draw(IMap map)
        {
            skin.Draw(this, map);
        }

        public void ChangeSkin(ISkin skin)
        {
            this.skin = skin;
        }
    }
}
