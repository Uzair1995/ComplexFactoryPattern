using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexFactoryPattern.Interfaces
{
    public interface IBigFourWheeler<T> : IFourWheeler<T>
    {
        public string GetBigFourWheelerData();
    }
}
