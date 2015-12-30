using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovsSubstitutionPrinciple.Better
{
    public class UKProduct : Product
    {
        public override IFormatProvider GetProductDisplayFormat()
        {
            return new CultureInfo("US-us");
        }
    }
}
