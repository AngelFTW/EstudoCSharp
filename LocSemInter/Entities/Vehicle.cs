using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocSemInter.Entities
{
    public class Vehicle
    {
        public string Model { get; set; }

        public Vehicle (string model)
        {
            Model = model;
        }
    }
}