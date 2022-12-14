/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int GetNumber(string message)
{
bool isCorrect = false;
int result = 0;

while(!isCorrect)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result))
{
isCorrect = true;
}
else
{
Console.WriteLine("Ввели не число. Введите число.");
}
}

return result;
}

void PrintDigitSum (int number)

{
int sum = 0;
while (number>0)
{
    int digit = number % 10;
    sum = sum + digit;
    number = number / 10;
}
Console.WriteLine ($"{sum}");
}

int number = Math.Abs(GetNumber("Введите число"));
PrintDigitSum (number);