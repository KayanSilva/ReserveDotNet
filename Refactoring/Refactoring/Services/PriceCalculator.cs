namespace Refactoring.Services
{
    static class PriceCalculator
    {
        private const decimal MaximumDiscount = 50m;
        private const decimal IncrementDiscountQuantity = 15m;
        private const decimal IncreaseDiscountTime = 10m;
        private const decimal InitialDiscountCeiling = 50m;
        private const int LimitMinimumYearsCustomer = 4;
        private const int LimitMinimumQuantity = 100;

        public static decimal GetFinalDiscounts(decimal initialDiscount, int amount, int customerManyYears, bool customerNegative)
        {
            if (customerNegative)
            {
                return 0;
            }

            var result = initialDiscount;
            if (initialDiscount > InitialDiscountCeiling)
            {
                result = MaximumDiscount;
            }
            if (amount > LimitMinimumQuantity)
            {
                result += IncrementDiscountQuantity;
            }
            if (customerManyYears > LimitMinimumYearsCustomer)
            {
                result += IncreaseDiscountTime;
            }
            return result;
        }
    }
}