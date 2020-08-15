using System;
using System.Globalization;

namespace Interface
{
    class Installment
    {
        public DateTime dueDate { get; set; }
        public double amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            this.dueDate = dueDate;
            this.amount = amount;
        }
        public override string ToString()
        {
            return dueDate.ToString("dd/MM/yyyy") + " - " + amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
