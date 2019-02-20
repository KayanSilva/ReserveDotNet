namespace Refactoring.Models
{
    class Employee
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string CellPhone { get; set; }
        public string FunctionalCode { get; set; }
        public decimal Salary { get; set; }
        private readonly decimal Cost;

        public Employee(string name, string telephone, string cellphone)
        {
            Name = name;
            Telephone = telephone;
            CellPhone = cellphone;
        }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public Employee(decimal cost)
        {
            Cost = cost;
        }

        public void GiveRise(decimal rise)
        {
            Salary *= 1.0m + (rise / 100.0m);
        }

        public decimal GetCost()
        {
            return Cost;
        }

        public override string ToString() => $"{Name}, {CellPhone}";
    }
}