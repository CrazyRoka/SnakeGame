using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Position;
using TochIndustries.SnakeGame.Model.Skin;

namespace TochIndustries.SnakeGame.Model.Cell.MapCell
{
    abstract class AbstractMapCell : AbstractCell
    {
        public AbstractMapCell(ISkin skin, IPosition position) : base(skin, position) { }
        public override bool IsEmpty() => true;
    }
}
