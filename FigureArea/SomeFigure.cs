namespace FigureArea
{
    public class SomeFigure : IFigure
    {
        private readonly IFigure _figure;

        public SomeFigure(double radius)
        {
            _figure = new Circle(radius);
        }
        
        public SomeFigure(double sideA, double sideB, double sideC)
        {
            _figure = new Triangle(sideA,sideB,sideC);
        }
        
        public double Area => _figure.Area;
    }
}