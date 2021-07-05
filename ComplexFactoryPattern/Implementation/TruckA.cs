using ComplexFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexFactoryPattern.Implementation
{
    public class TruckA : IBigFourWheeler<string>
    {
        public string VehicleModel => "TruckA";

        public string GetBigFourWheelerData()
        {
            return "TruckA GetBigFourWheelerData";
        }

        public string GetGenericFourWheelerData()
        {
            return "TruckA GetGenericFourWheelerData";
        }
    }
}
