using ISO3166;

namespace PatternRunner.PatternFlyweights
{
    internal class Personal
    {
        private readonly PersonalFactory _factory;

        protected int Id { get; set; }
        protected Country Country { get; set; }
        protected DateTime Birthday { get; set; }

        public Personal(PersonalFactory factory)
        {
            _factory = factory;
        }

        public void Set(int id, Country country, DateTime birthday)
        {
            Id = id;
            Country = _factory.GetCountry(country);
            Birthday = _factory.GetDateBorn(birthday);
        }

        public string CountryId() => Country.NumericCode;

        public string BirthdayId() => Birthday.ToString();

        public string Print() => $"{Id}::{Country.Name}::{Birthday:dd MMMM yyyy (dddd)}";
    }
}