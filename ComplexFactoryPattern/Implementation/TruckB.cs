using ComplexFactoryPattern.Interfaces;

namespace ComplexFactoryPattern.Implementation
{
    public class TruckB : IBigFourWheeler<string>
    {
        public string VehicleModel => "TruckB";

        public string GetBigFourWheelerData()
        {
            return "TruckB GetBigFourWheelerData";
        }

        public string GetGenericFourWheelerData()
        {
            return "TruckB GetGenericFourWheelerData";
        }
    }
}
