using ComplexFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexFactoryPattern.Implementation
{
    public class CarB : ISmallFourWheeler
    {
        public string VehicleModel => "CarB";

        public string GetGenericFourWheelerData()
        {
            return "CarB GetGenericFourWheelerData";
        }

        public string GetSmallFourWheelerData()
        {
            return "CarB GetSmallFourWheelerData";
        }
    }
}
