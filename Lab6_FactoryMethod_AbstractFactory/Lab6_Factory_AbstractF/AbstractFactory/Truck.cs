using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FactoryM_AbstractF.AbstractFactory
{
    public class Truck : FourWheelVehicle
    {
        public override void CompareMilage(TwoWheelVehicle t)
        {
            Console.WriteLine("Cannot compare milage " + this.GetType().Name + " with " + t.GetType().Name);
        }
    }
}
