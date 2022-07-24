namespace DesignPatterns.CreationPatterns.Fluent
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Employee GetClone()
            => (Employee)this.MemberwiseClone();
    }
}
