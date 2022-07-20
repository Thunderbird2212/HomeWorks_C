//Напишите программу для вычисления площади круга, прямоугольника и треугольника. 
//Ввод данных осуществляется в диалоговом режиме. 
//На первом шаге у пользователя запрашивается фигура, площадь которой нужно вычислить. 
//На втором шаге пользователь вводит параметры, необходимые для рассчета.
//Затем, выводится результат.

Console.WriteLine("Enter your figure ");
Console.ReadLine();
Console.Write("Rectangle side 1:  ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Rectangle side 2:  ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Triangle base:  ");
int x3 = int.Parse(Console.ReadLine());
Console.Write("Triangle height:  ");
int x4 = int.Parse(Console.ReadLine());
Console.Write("Circle radius:  ");
int x5 = int.Parse(Console.ReadLine());
double x6 = 3.14;


Console.WriteLine("Rectangle Area = " + GetRectangleArea(x1, x2));

int GetRectangleArea(int x1, int x2)
{
    int RectangleArea = x1 * x2;
    return RectangleArea;
}


Console.WriteLine("Triangle Area = " + GetTriangleArea(x3, x4));

int GetTriangleArea(int x3, int x4)
{
    int TriangleArea = x3 / 2 * x4;
    return TriangleArea;
}

Console.WriteLine("Circle Area = " + GetCircleArea(x5, x6));

double GetCircleArea(int x5, double x6)
{
    double CircleArea = (x6 * (x5 * x5));
    return CircleArea;
}



