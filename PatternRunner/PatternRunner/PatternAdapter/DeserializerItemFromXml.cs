using System.Xml.Serialization;

namespace PatternRunner.PatternAdapter
{
    public class DeserializerItemFromXml : ISerializerItem
    {
        public Item GetObject(string xml)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Item));

            using TextReader reader = new StringReader(xml);

            return (Item)formatter.Deserialize(reader);
        }
    }
}