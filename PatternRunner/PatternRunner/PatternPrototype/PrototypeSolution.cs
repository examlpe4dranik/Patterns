namespace PatternRunner.PatternPrototype
{
    public class PrototypeSolution : IPatternSolution
    {
        public void Execute()
        {
            var AgneszkaAccount = new Account()
                .SetOwner("Agneszka")
                .AddCurrency(Currency.PLN)
                .RankUp().RankUp()
                .Debit(Currency.PLN, 100);

            var PetrikAccount = new Account()
                .SetOwner("Petrik")
                .AddCurrency(Currency.PLN)
                .AddCurrency(Currency.EUR)
                .RankDown()
                .Debit(Currency.PLN, 100)
                .Debit(Currency.EUR, 50);

            var CloneAccount = PetrikAccount.Clone("Clone")
                                            .AddCurrency(Currency.USD)
                                            .Debit(Currency.USD, -500)
                                            .RankDown().RankDown();

            Print(AgneszkaAccount);
            Print(PetrikAccount);
            Print(CloneAccount);
        }

        private static void Print(Account acc)
        {
            Console.WriteLine(acc.Owner());
            Console.WriteLine(acc.Stocks());
        }
    }
}