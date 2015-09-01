using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public interface Engine
    {
        uint MaxThrottle { get; }
        uint CurrentThrottle {get; set;}

    }

    public class GasEngine : Engine
    {
        public uint CurrentThrottle { get; set; }
        public uint MaxThrottle { get; private set; }
      
        public GasEngine(uint maxthrottle)
        {
            MaxThrottle = maxthrottle;
            CurrentThrottle = 0;
        }

    }

    public class DieselEngine : Engine
    {
        public uint CurrentThrottle { get; set; }
        public uint MaxThrottle { get; private set; }

        public DieselEngine(uint maxthrottle)
        {
            MaxThrottle = maxthrottle;
            CurrentThrottle = 0;
        }

    }

    public class MotorBike
    {
        Engine Engine;
        
        public MotorBike(Engine engine)
        {
            Engine = engine;
        }

        void RunAtHalfSpeed()
        {
            Engine.CurrentThrottle = Engine.MaxThrottle/2;
        }
    }
}
