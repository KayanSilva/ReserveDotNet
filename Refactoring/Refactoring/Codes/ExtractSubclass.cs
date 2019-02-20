using System;
using Refactoring.Models;

namespace Refactoring.Codes
{
    public static class ExtractSubclass
    {
        public static void ExtractSubMain()
        {
            var Joao = new Employee(50);
            ServiceItem s1 = new Labor(5, Joao);
            ServiceItem s2 = new RawMaterial(15, 10);
            var TotalService = s1.GetTotalPrice() + s2.GetTotalPrice();

            Console.WriteLine(TotalService);
        }
    }
}