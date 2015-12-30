using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovsSubstitutionPrinciple.Better
{
   public abstract class Product
    {
        public int Sku { get; set; }
        public decimal Cost { get; set; }

        public abstract IFormatProvider GetProductDisplayFormat();
    }
}
