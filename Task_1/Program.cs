// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
//a = 5; b = 7 -> max = 7 
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int numberA = new Random().Next(-100, 100);
Console.WriteLine(numberA);
int numberB = new Random().Next(-100, 100);
Console.WriteLine(numberB);
int max = numberA;

if(numberA > max) max = numberA;
if(numberB > max) max = numberB;
Console.Write("max= ");
Console.WriteLine(max);
