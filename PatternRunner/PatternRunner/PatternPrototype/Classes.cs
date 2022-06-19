namespace PatternRunner.PatternPrototype
{
    public class Account
    {
        private readonly decimal DefaultStock = decimal.Zero;
        private readonly int DefaultRank = 0;

        private Personal _owner { get; set; }
        private List<MoneyStock> _stocks { get; set; }

        public Account()
        {
            _owner = null;
            _stocks = new List<MoneyStock>();
        }

        public string Owner() => $"{_owner.Name}({_owner.Rank}*)";

        public string Stocks()
        {
            var answer = string.Empty;

            _stocks.ForEach(s => answer += $"{s.Currency}: {s.Amount}{Environment.NewLine}");

            return answer;
        }

        public Account SetOwner(string name)
        {
            _owner = new Personal
            {
                Name = name,
                Rank = DefaultRank
            };

            return this;
        }

        public Account RankUp()
        {
            _owner.Rank++;
            return this;
        }

        public Account RankDown()
        {
            _owner.Rank--;
            return this;
        }

        public Account AddCurrency(Currency currency)
        {
            if (GetCurrency(currency) == null)
            {
                _stocks.Add(new MoneyStock { Currency = currency, Amount = DefaultStock });
            }

            return this;
        }

        public Account Debit(Currency currency, decimal value)
        {
            ChangeStock(currency, value);

            return this;
        }

        public Account Credit(Currency currency, decimal value)
        {
            ChangeStock(currency, -value);

            return this;
        }

        public Account Clone(string name) => new Account().SetOwner(name);

        private MoneyStock GetCurrency(Currency currency) => _stocks.FirstOrDefault(f => f.Currency == currency);

        private void ChangeStock(Currency currency, decimal value)
        {
            var stock = GetCurrency(currency);
            if (stock == null)
            {
                throw new NullReferenceException();
            }

            stock.Amount += value;
        }
    }

    public class Personal
    {
        public string Name { get; set; }
        public int Rank { get; set; }
    }

    public class MoneyStock
    {
        public Currency Currency { get; set; }
        public decimal Amount { get; set; }
    }

    public enum Currency
    {
        EUR = 0,
        USD = 1,
        PLN = 2,
        BYN = 3
    }
}