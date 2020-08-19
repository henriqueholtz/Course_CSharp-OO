using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Service
{
    class PaypalService : IOnlinePaymentService
    {
        private const double FeePorcentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double paymentFee(double amount)
        {
            return amount * FeePorcentage;
        }
    }
}
