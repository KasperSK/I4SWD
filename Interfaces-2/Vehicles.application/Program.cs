using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.application
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles.MotorBike MyBike = new Vehicles.MotorBike(new GasEngine(200));
        }
    }
}
