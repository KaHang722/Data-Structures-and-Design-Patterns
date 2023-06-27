using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FactoryM_AbstractF.AbstractFactory
{
    public class VehicleFactoryB : VehicleFactory
    {
        public override FourWheelVehicle CreateFourWheelVehicle()
        {
            return new Car();
        }
        public override TwoWheelVehicle CreateTwoWheelVehicle()
        {
            return new Motorcycle();
        }
    }
}
