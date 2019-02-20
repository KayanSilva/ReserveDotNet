using Refactoring.Interfaces;

namespace Refactoring.Models
{
    class Company : IPerson
    {
        readonly string Name;
        internal Credit Credit { get; }

        public Company(string name, Credit credit)
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
