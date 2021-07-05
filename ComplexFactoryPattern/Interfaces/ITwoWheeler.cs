using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexFactoryPattern.Interfaces
{
    public interface ITwoWheeler<T> : IVehicle
    {
        public string GetGenericTwoWheelerData();
    }
}
