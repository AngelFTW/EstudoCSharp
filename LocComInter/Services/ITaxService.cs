using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocComInter.Services
{
    public interface ITaxService
    {
        double Tax(double amount);
    }
}