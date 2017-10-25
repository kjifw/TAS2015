public class Figure
{
    public Figure(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public double Width { get; set; }
    public double Height { get; set; }

    public static Figure GetRotatedFigure(Figure currentFigure, double angleOfRotation)
    {
        double cosine = Math.Cos(angleOfRotation);
        double sine = Math.Sin(angleOfRotation);

        double rotatedWitdth = Math.Abs(cosine) * currentFigure.Width +
            Math.Abs(sine) * currentFigure.Height;
        double rotatedHeight = Math.Abs(sine) * currentFigure.Width +
            Math.Abs(cosine) * currentFigure.Height;

        Figure rotatedFigure = new Figure(rotatedWitdth, rotatedHeight);

        return rotatedFigure;
    }
}