using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Map;
using TochIndustries.SnakeGame.Model.Skin;

namespace TochIndustries.SnakeGame.Model.Cell
{
    public interface ICell
    {
        bool IsEmpty();
        void Draw(IMap map);
        void ChangeSkin(ISkin skin);
    }
}
