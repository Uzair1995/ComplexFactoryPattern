using ComplexFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexFactoryPattern.Implementation
{
    public class BikeB : ITwoWheeler<string>
    {
        public string VehicleModel => "BikeB";

        public string GetGenericTwoWheelerData()
        {
            return "BikeB GetGenericTwoWheelerData";
        }
    }
}
