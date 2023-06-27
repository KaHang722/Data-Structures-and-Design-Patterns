using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FactoryM_AbstractF.AbstractFactory
{
    public class Car : FourWheelVehicle
    {
        public override void CompareMilage(TwoWheelVehicle t)
        {
            Console.WriteLine("Milage of " + this.GetType().Name + " is higher than " + t.GetType().Name);
        }
    }
}
