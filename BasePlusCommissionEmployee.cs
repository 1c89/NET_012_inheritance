using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_012_Inheritance
{
    public class BasePlusCommissionEmployee
    {
             public string FirstName { get; }
            public string LastName { get; }
            public string SocialSecurityNumber { get; }

            private decimal grossSales;
            private decimal commissionRate;
            private decimal baseSalary;

            public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate, decimal baseSalary)
            {
                FirstName = firstName;
                LastName = lastName;
                SocialSecurityNumber = socialSecurityNumber;
                GrossSales = grossSales;
                CommissionRate = commissionRate;
                BaseSalary = baseSalary;
            }

            public decimal GrossSales
            {
                get
                {
                    return grossSales;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value),
                            value, $"{nameof(GrossSales)} must be >= 0");
                    }
                    grossSales = value;
                }
            }

            public decimal CommissionRate

            {
                get { return commissionRate; }
                set
                {
                    if (value <= 0 || value >= 1)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(CommissionRate)} must be > 0 and < 1");
                    }
                    commissionRate = value;
                }
            }
       
        public decimal BaseSalary

        {
            get { return baseSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(CommissionRate)} must be >= 0");
                }
                baseSalary = value;
            }
        }

        public decimal Earnings() => baseSalary + (grossSales * commissionRate);

            public override string ToString() =>
                $"Commission employee: {FirstName} {LastName}\n"
                + $"Social security number: {SocialSecurityNumber}\n"
                + $"Gross sales: {grossSales}\n"
                + $"Comission rate: {commissionRate}\n"
                + $"Base salary: {baseSalary}\n";




        }

}
