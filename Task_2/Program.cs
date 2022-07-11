//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int numberA = new Random().Next(-100, 100);
Console.WriteLine(numberA);
int numberB = new Random().Next(-100, 100);
Console.WriteLine(numberB);
int numberC = new Random().Next(-100, 100);
Console.WriteLine(numberC);
int max = numberA;

if(numberA > max) max = numberA;
if(numberB > max) max = numberB;
if(numberC > max) max = numberC;
Console.Write("max= ");
Console.WriteLine(max);
