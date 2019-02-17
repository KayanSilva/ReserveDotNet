using System;
using System.Collections.Generic;

namespace Refactoring.Class1
{
    class Program
    {
        void Main()
        {
            var person = new Person("Felipe Vale", new Credit(10000, 900));
            var company = new Company("AtomSoft", new Credit(100, 1));

            IList<IPerson> clients = new List<IPerson>() { person, company };

            foreach (var client in clients)
            {
                Console.WriteLine($"Available credit - Name: {client.GetName()}");
                Console.WriteLine($"Value: {client.GetAvailableCredit()}");
            }
        }
    }

    class Person : IPerson
    {
        readonly string _name;
        internal Credit _credit { get; }

        public Person(string name, Credit credit)
        {
            _name = name;
            _credit = credit;
        }

        public string GetName()
        {
            return _name;
        }

        public decimal GetAvailableCredit() => _credit.GetAvailableCredit();
    }

    class Company : IPerson
    {
        readonly string _name;
        internal Credit _credit { get; }

        public Company(string name, Credit credit)
        {
            _name = name;
            _credit = credit;
        }

        public string GetName()
        {
            return _name;
        }

        public decimal GetAvailableCredit() => _credit.GetAvailableCredit();
    }

    class Credit
    {
        public decimal _totalCredit { get; }
        public decimal _creditUsed { get; }

        public Credit(decimal totalcredit, decimal creditused)
        {
            _totalCredit = totalcredit;
            _creditUsed = creditused;
        }

        public decimal GetAvailableCredit() => _totalCredit - _creditUsed;
    }
}