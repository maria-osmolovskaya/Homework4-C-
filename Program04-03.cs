/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int [] GetMassive ()
{
int [] massive = new int [8];
Random rnd = new Random();
for (int i = 0; i < massive.Length; i++)
{
   massive [i] = rnd.Next (0,100);
   
}
return massive;
}

int [] array = GetMassive ();

for (int i = 0; i < array.Length; i++)

Console.Write($"{array[i]}, ");
