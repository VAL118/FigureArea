using System;

namespace FigureArea
{
    public class Triangle : IFigure
    {
        private readonly double _sideA, _sideB, _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double Area
        {
            get
            {
                double p = (_sideA + _sideB + _sideC) / 2;
                return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
            }
        }

        public bool IsRightTriangle()
        {
            return _sideA == Math.Sqrt(Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2)) ||
                   _sideB == Math.Sqrt(Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2)) ||
                   _sideC == Math.Sqrt(Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2));
        }
    }
}