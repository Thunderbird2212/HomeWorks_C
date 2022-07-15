//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
int a = new Random().Next(1, 8);
Console.WriteLine(a);
if ((a) <= 5)
{
    Console.WriteLine("No");
}
else
{
    Console.WriteLine("Yes");
}
