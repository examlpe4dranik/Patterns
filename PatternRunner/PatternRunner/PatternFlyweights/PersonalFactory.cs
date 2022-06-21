using ISO3166;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRunner.PatternFlyweights
{
    internal class PersonalFactory
    {
        private readonly Hashtable _hash;

        public PersonalFactory()
        {
            _hash = new Hashtable();
        }

        public Country GetCountry(Country country)
        {
            var hashKey = country.Name;
            if (_hash.ContainsKey(hashKey))
            {
                return (Country)_hash[hashKey];
            }
            else
            {
                _hash.Add(hashKey, country);
                return country;
            }
        }

        public DateTime GetDateBorn(DateTime dateBorn)
        {
            var hashKey = $"#{dateBorn}";
            if (_hash.ContainsKey(hashKey))
            {
                return (DateTime)_hash[hashKey];
            }
            else
            {
                _hash.Add(hashKey, dateBorn);
                return dateBorn;
            }
        }

        public void Dispose()
        {
            _hash.Clear();
        }
    }
}
