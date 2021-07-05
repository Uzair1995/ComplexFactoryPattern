using ComplexFactoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ComplexFactoryPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CallingController : ControllerBase
    {
        private readonly IVehicleFactory vehicleFactory;

        public CallingController(IVehicleFactory vehicleFactory)
        {
            this.vehicleFactory = vehicleFactory;
        }

        [HttpGet]
        public string Get([FromQuery] string vehicleModel)
        {
            var vehicleObj = vehicleFactory.GetVehicleObject<ISmallFourWheeler>(vehicleModel);

            var genericData = vehicleObj.GetGenericFourWheelerData();
            return vehicleObj.VehicleModel;
        }
    }
}
