// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                var employee = new Employee(
                    id: int.Parse(employeesArray[i, 0]),
                    name: employeesArray[i, 1],
                    designation: employeesArray[i, 2],
                    salary: decimal.Parse(employeesArray[i, 3])
                );

                //cuz billing system expexts a luist?
                thirdPartyBillingSystem.ProcessSalary(new List<Employee> { employee });
            }
        }
    }
}
