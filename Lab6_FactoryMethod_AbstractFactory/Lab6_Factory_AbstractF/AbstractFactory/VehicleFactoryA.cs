using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FactoryM_AbstractF.AbstractFactory
{
    public class VehicleFactoryA : VehicleFactory
    {
        public override FourWheelVehicle CreateFourWheelVehicle()
        {
            return new Truck();
        }

        public override TwoWheelVehicle CreateTwoWheelVehicle()
        {
            return new Bicycle();
        }
    }
}
