using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice13.Classes
{
    internal class Point
    {
        private double _posX;
        private double _posY;

        public double PosX { get { return _posX; } set { _posX = value; } }
        public double PosY { get { return _posY; } set { _posY = value; } }

        public Point(double posX, double posY)
        {
            PosX = posX;
            PosY = posY;
        }

        public override string ToString()
        {
            return $"({PosX} ; {PosY})";
        }
    }
}
