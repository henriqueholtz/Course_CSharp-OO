using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_02
{
    class PhysicalPesron : Person
    {
        public double HealthExpenditures { get; set; }

        public PhysicalPesron(double healthExpenditures,string name,double anualIncome) : base(name,anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            double x;
            if (AnualIncome < 20000)
            {
                x = (AnualIncome * 0.15);
            }
            else
            {
                x = (AnualIncome * 0.25);
            }

            if (HealthExpenditures > 0)
            {
                return x - (HealthExpenditures * 0.5);
            }
            else
            {
                return x;
            }
        }

        public override string ToString()
        {
            return Name + ": $ " + Taxes();
        }
    }
}
