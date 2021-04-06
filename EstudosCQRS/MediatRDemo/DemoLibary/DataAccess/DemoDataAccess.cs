using DemoLibary.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoLibary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Kayan", LastName = "Silva" });
            people.Add(new PersonModel { Id = 2, FirstName = "Kalahan", LastName = "Florencio" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPeople(string firstName, string lastName)
        {
            PersonModel p = new() { FirstName = firstName, LastName = lastName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;
        }
    }
}