namespace DesignPatterns.CreationPatterns.Fluent
{
    internal class FluentEmployee
    {
        private Employee _employee = new();

        public FluentEmployee WithName(string name)
        {
            _employee.Name = name;
            return this;
        }

        public FluentEmployee Born(DateTime dateOfBirth)
        {
            _employee.DateOfBirth = dateOfBirth;
            return this;
        }

        public FluentEmployee LivingAt(string address)
        {
            _employee.Address = address;
            return this;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {_employee.Name}");
            Console.WriteLine($"Living at: {_employee.Address}");
            Console.WriteLine($"Born: {_employee.DateOfBirth.ToLongDateString()}");
        }
    }
}
