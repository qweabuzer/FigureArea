using figure_area;

Shape circle = new Circle(5);
Shape triangle = new Triangle(4, 5);

double circleArea = circle.CalculateArea();
double triangleArea = triangle.CalculateArea();

Console.WriteLine("Площадь круга: " + circleArea);
Console.WriteLine("Площадь треугольника : " + triangleArea);
