using System;

namespace FigureArea
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area => Math.PI * Math.Pow(_radius, 2);
    }
}