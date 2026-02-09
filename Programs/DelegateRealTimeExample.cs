using System;

namespace Programs
{
    public delegate bool IsEligibleForPromotionDelegate(Employee employee);
    internal class DelegateRealTimeExample
    {
       public static void Main()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Name = "Tej", Id = 101, Experience = 3, Salary = 3000 });
            employees.Add(new Employee() { Name = "Viji", Id = 102, Experience = 2, Salary = 2000 });
            employees.Add(new Employee() { Name = "Karti", Id = 103, Experience =4, Salary = 5000 });
            employees.Add(new Employee() { Name = "Aks", Id = 104, Experience = 5, Salary = 6000 });

            IsEligibleForPromotionDelegate e = new IsEligibleForPromotionDelegate(EligbleForPromotionCondition);

            IsEligibleForPromotionDelegate condition = delegate (Employee employee) //anonymous methood
            {
                if (employee.Experience >= 3 && employee.Salary >= 3000)
                {
                    return true;
                }
                return false;
            };

            IsEligibleForPromotionDelegate condition1 = emp => emp.Experience >= 3; //lambda experssion

            Predicate<Employee> predicate = e => e.Experience >= 3; // using predicate


            Employee.EligibleForPromotion(employees, condition1);
        }
        private static bool EligbleForPromotionCondition(Employee employee)
        {
            if(employee.Experience>=3 && employee.Salary>=3000)
            {
                return true;
            }
            return false;
        }
    }

    public class Employee
    {
        public string Name {  get; set; }

        public int Id { get; set; }

        public int Experience { get; set; }

        public double Salary { get; set; }

        public static void EligibleForPromotion(List<Employee> emp, IsEligibleForPromotionDelegate isEligible)
        {
            
            foreach (var employee in emp)
            {
                if(isEligible(employee))
                {
                    Console.WriteLine($"{employee.Name} is elligle for Promotion");
                }
            }
            
        }
    }
}
