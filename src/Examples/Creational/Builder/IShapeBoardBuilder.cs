namespace Examples.Creational.Builder
{
    public interface IShapeBoardBuilder
    {
        void SetName(string name);

        void AddCircle(Circle circle);

        void AddSquare(Square square);

        void AddTriangle(Triangle triangle);

        ShapeBoard GetShapeBoard();
    }
}