using Lab8.Cell.Positions;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Lab8
{
    [Serializable]
    [XmlRoot(ElementName = "GameMemento")]
    public class GameMemento
    {
        [XmlElement("FoodPosition")]
        public Position FoodPosition { get; set; }

        [XmlArrayItem("ListOfSnakeSegments")]
        public List<Position> SnakeSegments { get; set; }
    }
}
