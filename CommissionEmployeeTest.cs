namespace NET_012_Inheritance
{
    internal class CommissionEmployeeTest
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
            Console.WriteLine($"earnings {employee.Earnings():C}\n");

            //
            var bpemployee = new BasePlusCommissionEmployee("Bob", "Lewis", "333-333-3333", 5000.0M, .04M, 300);
            Console.WriteLine("BP Employee information obtained by properties and methods: \n");
            Console.WriteLine($"First name is {bpemployee.FirstName}");
            Console.WriteLine($"Last name is {bpemployee.LastName}");
            Console.WriteLine($"Social security number {bpemployee.SocialSecurityNumber}");
            Console.WriteLine($"Gross sales {bpemployee.GrossSales:C}");
            Console.WriteLine($"Commission rate {bpemployee.CommissionRate:F2}");
            Console.WriteLine($"Earnings are {bpemployee.Earnings():C}");
            Console.WriteLine($"Base salary {bpemployee.BaseSalary:C}");


            bpemployee.BaseSalary = 1000.0M;

            Console.WriteLine("\nUpdated bpemployee information obtained by ToString() method:\n");
            Console.WriteLine(bpemployee);
            Console.WriteLine($"earnings {bpemployee.Earnings():C}");

        }
    }
}