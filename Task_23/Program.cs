//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter your number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Table of Cubes ");

for (int i = 1; i < number + 1; i++)
{
    int TableCubes = i * i * i;
    Console.Write($"{" "} {TableCubes}");
}
Console.WriteLine();