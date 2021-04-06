using DemoLibary.Models;
using System.Collections.Generic;

namespace DemoLibary.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();

        PersonModel InsertPeople(string firstName, string lastName);
    }
}