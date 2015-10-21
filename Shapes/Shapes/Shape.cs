using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Coordinate
    {
        public Coordinate(int y, int x, int z)
        {
            Y = y;
            X = x;
            Z = z;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }
    }
    public class Shape
    {
        public Coordinate Origin { get; set; }

        public Shape(Coordinate origo)
        {
            Origin = origo;
        }

        public virtual void Render()
        {
            Console.WriteLine("This is a shape with origin at: ({0},{1},{2})", Origin.X, Origin.Y, Origin.Z);
        }

    }

    public class Line : Shape
    {
        protected int Lenght { get; set; }
        public Line(Coordinate origo, int lenght = 0) : base(origo)
        {
            Lenght = lenght;
        }

        public override void Render()
        {
            Console.WriteLine("This is a line with lenght {0} and origin at ({1},{2},{3})", Lenght, Origin.X, Origin.Y, Origin.Z);
        }
    }

    public class Arc : Line
    {
        int Height { get; set; }
        public Arc(Coordinate origo, int lenght = 0, int height = 0) : base(origo, lenght)
        {
            Height = height;
        }

        public override void Render()
        {
            Console.WriteLine("This is an Arc whith a height of {0} and a lenght of {1} and origin at ({2},{3},{4})", Height, Lenght, Origin.X, Origin.Y, Origin.Z);
        }
    }

    public class Circle : Arc
    {
        public Circle(Coordinate origo, int lenght = 0, int height = 0) : base(origo, lenght, height)
        {
        }
    }
}
