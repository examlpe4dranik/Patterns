using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRunner.PatternBridge
{
    public class BridgeOperator : IBridgeOperator
    {
        private readonly DigitOperator _digitOperator;
        private readonly StringOperator _stringOperator;

        public BridgeOperator()
        {
            _digitOperator = new DigitOperator();
            _stringOperator = new StringOperator();
        }

        public int Sum(int termFirst, int termSecond) => _digitOperator.Summa(termFirst, termSecond);

        public int Multiply(int termFirst, int termSecond) => _digitOperator.Multy(termFirst, termSecond);

        public string Sum(string termFirst, string termSecond) => _stringOperator.Add(termFirst, termSecond);

        public string Multiply(string termFirst, string termSecond) => _stringOperator.Mix(termFirst, termSecond);
    }
}
