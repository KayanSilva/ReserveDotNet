using System;
using System.Collections.Generic;
using Refactoring.Interfaces;
using Refactoring.Models;

namespace Refactoring.Codes
{
    public static class Bank
    {
        public static void BankMain()
        {
            var person = new Person("Felipe Vale", new Credit(10000, 900));
            var company = new Company("AtomSoft", new Credit(100, 1));

            IList<IPerson> clients = new List<IPerson> { person, company };

            foreach (var client in clients)
            {
                Console.WriteLine($"Available credit - Name: {client.GetName()}");
                Console.WriteLine($"Value: {client.GetAvailableCredit()}");
            }
        }
    }
}