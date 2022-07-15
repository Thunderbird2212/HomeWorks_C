//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int a = new Random().Next(100, 1000);
Console.WriteLine(a);

int result = FindSecondNumber(a);
Console.WriteLine(result);

int FindSecondNumber(int number)
{
    int secondDigit = number % 100 / 10;
    return secondDigit;
}