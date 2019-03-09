using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Factory;

namespace TochIndustries.SnakeGame.Model.Snake.Builder
{
    interface ISkinBuilder
    {
        void ChangeSkin(ISkinFactory skinFactory);
        ISnake Build();
    }
}
