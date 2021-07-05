using ComplexFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexFactoryPattern.Implementation
{
    public class BikeA : ITwoWheeler<string>
    {
        public string VehicleModel => "BikeA";

        public string GetGenericTwoWheelerData()
        {
            return "BikeA GetGenericTwoWheelerData";
        }
    }
}
