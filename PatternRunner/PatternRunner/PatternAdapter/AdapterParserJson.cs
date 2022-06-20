namespace PatternRunner.PatternAdapter
{
    public class AdapterParserJson : ISerializerItem
    {
        private IParserJson _parserJson;

        public AdapterParserJson(IParserJson parserJson)
        {
            _parserJson = parserJson;
        }

        public Item GetObject(string value)
        {
            return _parserJson.ExtractObject(value);
        }
    }
}