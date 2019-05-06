using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Lab8
{
    public class GameHistory
    {
        private string _history;

        public void Save(GameMemento memento)
        {
            var aSerializer = new XmlSerializer(typeof(GameMemento));

            StringBuilder stringbuilder = new StringBuilder();
            StringWriter writer = new StringWriter(stringbuilder);

            aSerializer.Serialize(writer, memento);

            _history = writer.GetStringBuilder().ToString();

            writer.Close();
        }

        public GameMemento Load()
        {
            if (_history == null) throw new InvalidOperationException();
            XmlSerializer serializer = new XmlSerializer(typeof(GameMemento));
            StringReader reader = new StringReader(_history);

            var memento = (GameMemento)serializer.Deserialize(reader);
            reader.Close();

            return memento;
        }
    }
}
