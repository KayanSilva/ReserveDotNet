using Refactoring.Models;

namespace Refactoring.Codes
{
    static class ParameterMethod
    {
        static void ParameterMethodMain()
        {
            var funcionario1 = new Employee("Tony Estarque", 10000);
            var funcionario2 = new Employee("Pedro Parques", 2000);

            funcionario1.GiveRise(5);
            funcionario2.GiveRise(10);
        }
    }
}