using ComplexFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexFactoryPattern.Implementation
{
    public class CarA : ISmallFourWheeler
    {
        public string VehicleModel => "CarA";

        public string GetGenericFourWheelerData()
        {
            return "CarA GetGenericFourWheelerData";
        }

        public string GetSmallFourWheelerData()
        {
            return "CarA GetSmallFourWheelerData";
        }
    }
}
