﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Service
{
    interface IOnlinePaymentService
    {
        double paymentFee(double amount);
        double interest(double amount, int months);

    }
}
