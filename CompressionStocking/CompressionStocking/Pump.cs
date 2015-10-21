using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressionStocking
{
    public class Pump : IPump
    {
        public void Start(Direction direction)
        {
            System.Console.WriteLine("Air Pump Startet running in: " + direction.ToString());
        }

        public void Stop()
        {
            System.Console.WriteLine("Air Pump Stopped");
        }
    }
}
