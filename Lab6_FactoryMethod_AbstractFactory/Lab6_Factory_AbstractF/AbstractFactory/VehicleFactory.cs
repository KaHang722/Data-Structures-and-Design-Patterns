using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FactoryM_AbstractF.AbstractFactory
{
    public abstract class VehicleFactory
    {
        public abstract TwoWheelVehicle CreateTwoWheelVehicle();
        public abstract FourWheelVehicle CreateFourWheelVehicle();

    }
}
