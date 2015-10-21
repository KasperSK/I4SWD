using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressionStocking
{
    public class CompressionCtrl : ICompressionCtrl
    {
        private IPump _pump { get; set; }
        private ITimer _timer { get; set; }

        public CompressionCtrl(IPump pump, ITimer timer)
        {
            _pump = pump;
            _timer = timer;
        }
        public void Compress()
        {
            Console.WriteLine("Compressíng");
            _pump.Start(Direction.CW);
            _timer.Start(5000);
            _pump.Stop();
            Console.WriteLine("Compressíng done!");
        }

        public void Decompress()
        {
            Console.WriteLine("Decompressíng");
            _pump.Start(Direction.CCW);
            _timer.Start(2000);
            _pump.Stop();
            Console.WriteLine("Decompressíng done!");
        }
    }
}
