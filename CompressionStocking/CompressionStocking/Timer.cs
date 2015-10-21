using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressionStocking
{
    public class Timer : ITimer
    {
        public void Start(int time)
        {
            System.Threading.Thread.Sleep(time);
        }
    }
}
