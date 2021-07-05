using ComplexFactoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ComplexFactoryPattern
{
    class VehicleFactory : IVehicleFactory
    {
        private readonly IEnumerable<IVehicle> vehicles;

        public VehicleFactory(IEnumerable<IVehicle> vehicles)
        {
            this.vehicles = vehicles;
        }

        public T GetVehicleObject<T>(string vehicleModel)
        {
            return (T) vehicles.FirstOrDefault(x => x.VehicleModel.Equals(vehicleModel));
        }
    }
}
