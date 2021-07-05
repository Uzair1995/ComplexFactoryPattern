using ComplexFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexFactoryPattern.Implementation
{
    public class BikeC : ITwoWheeler<string>
    {
        public string VehicleModel => "BikeC";

        public string GetGenericTwoWheelerData()
        {
            return "BikeC GetGenericTwoWheelerData";
        }
    }
}
