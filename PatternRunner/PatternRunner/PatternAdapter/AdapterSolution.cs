namespace PatternRunner.PatternAdapter
{
    internal class AdapterSolution : IPatternSolution
    {
        public void Execute()
        {
            var xml = "<Item><f>value Item.f from XML</f></Item>";
            var json = "{\"f\":\"value Item.f from JSON\"}";

            var parserXml = new DeserializerItemFromXml();
            Console.WriteLine($"{nameof(DeserializerItemFromXml)}: {parserXml.GetObject(xml).f}");

            var parserJson = new ParserItemFromJson();
            Console.WriteLine($"{nameof(ParserItemFromJson)}: {parserJson.ExtractObject(json).f}");

            var adapterJson = new AdapterParserJson(new ParserItemFromJson());
            Console.WriteLine($"{nameof(AdapterParserJson)}: {adapterJson.GetObject(json).f}");
        }
    }
}