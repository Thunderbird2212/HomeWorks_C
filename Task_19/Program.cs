//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int number = new Random().Next(10000, 100000);
Console.WriteLine(number);

int temporaryNumber = number;
int newNumber = 0;

while (temporaryNumber > 0)
{
    newNumber *= 10;
    newNumber += temporaryNumber % 10;
    temporaryNumber /= 10;

}
if (number == newNumber)
    Console.WriteLine("Number is a Palindrome");
else
    Console.WriteLine("Number is not a Palindrome");

