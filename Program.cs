using MindboxApp;

Circle circle = new Circle(5);
double circleArea = circle.CalculateArea();
Console.WriteLine($"Circle Area : {circleArea}");

Triangle triangle = new Triangle(5, 6, 7);
double triangleArea = triangle.CalculateArea();
bool isRightAngled = triangle.IsRightAngled();
Console.WriteLine($" Triangle Area: {triangleArea}");
Console.WriteLine($"Triangle Is right angled: {isRightAngled}");
