namespace PatternRunner.PatternBridge
{
    public class StringOperator
    {
        public StringOperator()
        { }

        public string Add(string value1, string value2) => $"{value1}-{value2}";

        public string Mix(string value1, string value2)
        {
            if (string.IsNullOrEmpty(value1))
            {
                return value2;
            }
            else if (string.IsNullOrEmpty(value2))
            {
                return value1;
            }
            else
            {
                var result = string.Empty;
                int largeLenght = value1.Length >= value2.Length ? value1.Length : value2.Length;

                for (int i = 0; i < largeLenght; i++)
                {
                    result += (value1.Length > i) ? value1[i] : string.Empty;
                    result += (value2.Length > i) ? value2[i] : string.Empty;
                }

                return result;
            }
        }
    }
}