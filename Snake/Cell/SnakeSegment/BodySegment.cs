﻿using System;
using System.Collections.Generic;
using System.Text;
using TochIndustries.SnakeGame.Model.Position;
using TochIndustries.SnakeGame.Model.Skin;

namespace TochIndustries.SnakeGame.Model.Cell.SnakeSegment
{
    class BodySegment : AbstractSnakeSegment
    {
        public BodySegment(ISkin skin, IPosition position) : base(skin, position) { }
    }
}
