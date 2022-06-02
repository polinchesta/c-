namespace ClassLibrary1
{
    public abstract class RectangleFigure
    {
        public abstract string Area();
        public abstract string Perimeter();
        public abstract string ShapeName();
        public abstract string GetFigureType();
    }

    public class Rectangle : RectangleFigure
    {
        double width;   
        double height;   
        public Rectangle(double rectangleWidth, double rectangleHeight)
        {
            Width = rectangleWidth;
            Height = rectangleHeight;
        }
        public double Width
        {
            get { return width; }
            set { width = value < 0 ? -value : value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value < 0 ? -value : value; }
        }
        public override string Area()
        {
            return (width * height).ToString();
        }
        public override string Perimeter()
        {
            return (width * 2 + height * 2).ToString();
        }
        public override string GetFigureType()
        {
            if (width == height) return "Квадрат";
            return "Не квадратный прямоугольник";
        }
        public override string ShapeName()
        {
            return "Прямоугольник";
        }
    }
}