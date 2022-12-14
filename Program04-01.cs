/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

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
            Console.WriteLine("Ввели не число. Введите корректное число");
        }
    }
    return result;
}

int NumberA = GetNumber ("Введите первое число");
int NumberB = GetNumber ("Введите второе число");

Console.WriteLine ($"{Math.Pow(NumberA,NumberB)}");
