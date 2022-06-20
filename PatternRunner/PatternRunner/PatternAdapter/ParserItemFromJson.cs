using Newtonsoft.Json;

namespace PatternRunner.PatternAdapter
{
    public class ParserItemFromJson : IParserJson
    {
        public Item ExtractObject(string json) => JsonConvert.DeserializeObject<Item>(json);
    }
}