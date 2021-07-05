using ComplexFactoryPattern.Interfaces;

namespace ComplexFactoryPattern
{
    public interface IVehicleFactory
    {
        T GetVehicleObject<T>(string vehicleModel);
    }
}
