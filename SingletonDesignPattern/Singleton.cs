using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    sealed class Singleton
    {
        private List<Country> countries;
        public int Id { get; private set; }

        private static Singleton _instance;
        private static readonly object lockObject = new object();

        private Singleton() 
        {
            
        }

        public static Singleton Instance(int id) 
        {
            if (_instance == null)
            {
                lock (lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                        _instance.Id = id;
                    }
                }
            }
            return _instance;
        }

        public List<Country> GetCountries()
        {
            if (countries == null)
            {
                lock (lockObject)
                {
                    if (countries == null)
                    {
                        countries = new List<Country>();
                        countries.Add(new Country() { Name = "Bangladesh" });
                        countries.Add(new Country() { Name = "India" });
                    }
                }
            }
            return countries;
        }

    }
}
