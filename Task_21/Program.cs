//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter coordinate X1 ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter coordinate Y1 ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter coordinate Z1 ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter coordinate X2 ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter coordinate Y2 ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter coordinate Z2 ");
int z2 = int.Parse(Console.ReadLine());


Console.WriteLine("Distance = " + GetLength(x1, y1, z1, x2, y2, z2));




double GetLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double Distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return Distance;
}