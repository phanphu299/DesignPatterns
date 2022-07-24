namespace DesignPatterns.CreationPatterns.Fluent
{
    internal static class EmployeeExtensions
    {
        public static Employee WithName(this Employee employee, string name)
        {
            employee.Name = name;
            return employee;
        }

        public static Employee LivingAt(this Employee employee, string address)
        {
            employee.Address = address;
            return employee;
        }

        public static Employee Born(this Employee employee, DateTime dateOfBirth)
        {
            employee.DateOfBirth = dateOfBirth;
            return employee;
        }
    }
}
