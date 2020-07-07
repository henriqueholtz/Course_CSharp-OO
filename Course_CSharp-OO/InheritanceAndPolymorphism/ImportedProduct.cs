using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price,double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return base.priceTag();
        }
        public double TotalPrice()
        {
            return 0;
        }
    }
}
