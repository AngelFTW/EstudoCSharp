using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocComInter.Services
{
    public class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if(amount <= 100.0)
                return amount * 0.2;
                
            else
                return amount * 0.15;
        }
    }
}