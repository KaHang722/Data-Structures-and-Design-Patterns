using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_FactoryM_AbstractF.AbstractFactory
{
    public class Client
    {
        private TwoWheelVehicle tw;
        private FourWheelVehicle fw;
        public Client(VehicleFactory vf)
        {
            fw = vf.CreateFourWheelVehicle();
            tw = vf.CreateTwoWheelVehicle();
        }
        public void Compare()
        {
            fw.CompareMilage(tw);
        }
    }
}
