using System;
using Refactoring.Models;

namespace Refactoring.Codes
{
    public static class CollapseHierarchy
    {
        public static void CollapseMain()
        {
            var funcionario = new Employee("Walter White", "555-12345", "666-65432");

            Console.WriteLine(funcionario.ToString());
        }
    }
}