using ISO3166;

namespace PatternRunner.PatternFlyweights
{
    internal class FlyweightsSolution : IPatternSolution
    {
        public void Execute()
        {
            var population = GererationPersonal(1000000);

            Console.WriteLine($"Count items: {population.Count}");
            Console.WriteLine($"Count countries: {population.Select(s => s.CountryId()).Distinct().Count()}");
            Console.WriteLine($"Count birthdays: {population.Select(s => s.BirthdayId()).Distinct().Count()}");

            //population.ForEach(p => Console.WriteLine(p.Print()));
        }

        private static List<Personal> GererationPersonal(int count)
        {
            var result = new List<Personal>();

            int lastTime = 0;
            int deepTime = 365;
            Country[] countries = ISO3166.Country.List;

            var random = new Random();
            int indexCountry;
            int indexBorn;
            PersonalFactory personalFactory = new PersonalFactory();
            for (int i = 0; i < count; i++)
            {
                indexCountry = random.Next(0, countries.Length - 1);
                indexBorn = random.Next(lastTime, deepTime);

                var newPersonal = new Personal(personalFactory);
                newPersonal.Set(i, countries[indexCountry], DateTime.Now.AddDays(-indexBorn).Date);

                result.Add(newPersonal);
            }

            return result;
        }
    }
}