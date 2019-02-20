using System;

namespace Refactoring
{
    internal static class Program
    {
        private static void Main()
        {
            var menus = new string[] {
                "1. Bank",
                "2. Add parameters",
                "3. CollapseHierarchy"
            };

            Console.WriteLine("PROGRAM INDEX");
            Console.WriteLine("===================");

            var program = 0;
            string line;
            do
            {
                foreach (var menu in menus)
                {
                    Console.WriteLine(menu);
                }

                Console.WriteLine();
                Console.WriteLine("Choose a program:");

                line = Console.ReadLine();
                int.TryParse(line, out program);
                switch (program)
                {
                    case 1:
                        Codes.Bank.BankMain();
                        break;
                    case 2:
                        Codes.AddParameters.AddParamMain();
                        break;
                    case 3:
                        Codes.CollapseHierarchy.CollapseMain();
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("PRESS A KEY TO CONTINUE...");
                Console.ReadKey();
                Console.Clear();
            } while (line.Length > 0);
        }
    }
}