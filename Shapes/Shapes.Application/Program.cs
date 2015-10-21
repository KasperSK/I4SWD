using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape myShape = new Line(new Coordinate(0, 0, 0), 10);
            myShape.Render();
            myShape = new Arc(new Coordinate(1,1,1),5,20);
            myShape.Render();

        }
    }
}
