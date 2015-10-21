using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CompressionStocking
{
    public enum Direction
    {
        CW,
        CCW,
    }
    public interface IPump
    {
        void Start(Direction direction);
        void Stop();
    }
}
