namespace NET_012_Inheritance
{
    internal class ComissionEmployeeTest
    {
        static void Main(string[] args)
        {
            var employee = new CommissionEmployee("Sue", "Jones", "222-222-2222", 10000.0M, .06M);

            Console.WriteLine("Employee information obtained by properties and methods: \n");
            Console.WriteLine($"First name is {employee.FirstName}");
            Console.WriteLine($"Last name is {employee.LastName}");
            Console.WriteLine($"Social security number {employee.SocialSecurityNumber}");
            Console.WriteLine($"Gross sales {employee.GrossSales:C}");
            Console.WriteLine($"Commission rate {employee.CommissionRate:F2}");
            Console.WriteLine($"Earnings are {employee.Earnings():C}");

            employee.GrossSales = 5000.0M;
            employee.CommissionRate = 0.1M;

            Console.WriteLine("\nUpdated employee information obtained by ToString() method:\n");
            Console.WriteLine(employee);
            Console.WriteLine($"earnings {employee.Earnings():C}");

        }
    }
}