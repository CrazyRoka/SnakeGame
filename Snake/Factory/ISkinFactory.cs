using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Skin;

namespace TochIndustries.SnakeGame.Model.Factory
{
    public interface ISkinFactory
    {
        IHeadSkin CreateHeadSkin();
        IBodySkin CreateBodySkin();
        IFoodSkin CreateFoodSkin();
        IMapCellSkin CreateCellSkin();
    }
}
