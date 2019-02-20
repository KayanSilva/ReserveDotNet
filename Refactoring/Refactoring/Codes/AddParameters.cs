using System;
using Refactoring.Services;

namespace Refactoring.Codes
{
    public static class AddParameters
    {
        public static void AddParamMain()
        {
            var discountClient1 = PriceCalculator.GetFinalDiscounts(23, 10, 3, false);

            Console.WriteLine($"Final discount: {discountClient1}");

            var discountClient2 = PriceCalculator.GetFinalDiscounts(30, 4, 5, true);

            Console.WriteLine($"Final discount: {discountClient2}");
        }
    }
}