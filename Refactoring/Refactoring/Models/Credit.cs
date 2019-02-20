namespace Refactoring.Models
{
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