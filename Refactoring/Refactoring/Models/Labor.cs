namespace Refactoring.Models
{
    class Labor : ServiceItem
    {
        private readonly Employee Employee;

        public Labor(int quantity, Employee employee)
            : base(quantity)
        {
            Employee = employee;
        }

        public override decimal GetUnitPrice()
        {
            return Employee.GetCost();
        }

        public Employee GetEmployee()
        {
            return Employee;
        }
    }
}