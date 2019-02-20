using Refactoring.Interfaces;

namespace Refactoring.Models
{
    class Person : IPerson
    {
        readonly string Name;
        internal Credit Credit { get; }

        public Person(string name, Credit credit)
        {
            Name = name;
            Credit = credit;
        }

        public string GetName()
        {
            return Name;
        }

        public decimal GetAvailableCredit() => Credit.GetAvailableCredit();
    }
}