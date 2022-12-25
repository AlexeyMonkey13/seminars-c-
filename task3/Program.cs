// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

Console.WriteLine("введите цифру, вообще любую положитльную цифру");

double number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ваш столбец квадратов");

for (int i = 1; i <= number; i++)
{
    Console.WriteLine(i * i * i );
}