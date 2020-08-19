using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_02
{
    class LegalPerson : Person
    {
        public int EmployeesQuantity { get; set; }

        public LegalPerson(int employeesQuantity,string name, double anualIncome) : base(name,anualIncome)
        {
            EmployeesQuantity = employeesQuantity;
        }

        public override double Taxes()
        {
            if (EmployeesQuantity > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
