namespace DesignPatterns.StructuralPatterns.Adapter
{
    internal class ProcessSalaryAdapter : IAdapter
    {
        ThirdPartyLib thirdPartyLib = new();
        public void ProcessSalary(string[,] employeesArray)
        {
            string id = null;
            string name = null;
            string designation = null;
            string salary = null;

            List<Employee> listEmployee = new List<Employee>();
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        id = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        name = employeesArray[i, j];
                    }
                    else if (j == 2)
                    {
                        designation = employeesArray[i, j];
                    }
                    else
                    {
                        salary = employeesArray[i, j];
                    }
                }
                listEmployee.Add(new Employee(Convert.ToInt32(id), name, designation, Convert.ToDecimal(salary)));
            }

            thirdPartyLib.ProcessSalary(listEmployee);
        }
    }
}
