//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int a = new Random().Next(100, 1000);
Console.WriteLine(a);

int result = FindSecondDigit(a);
Console.WriteLine(result);

int FindSecondDigit(int number)
{
    int secondDigit = (number / 10 % 10);
    return secondDigit;
}