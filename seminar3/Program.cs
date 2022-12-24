// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


// ЗАДАЧА СПИСАНА ИЗ ИНТЕРНЕТА ПОЧТИ ПОЛНОСТЬЮ, т.к. сломал голову как развернуть строку или число!!!
Console.Clear();
Console.WriteLine("введите число, а мы определим палиндром оно или нет ");

int n = int.Parse(Console.ReadLine());
int temp = n;
int Reverse = 0;

while (Convert.ToBoolean(n))
{
     int b = n % 10;   
     Reverse = (Reverse * 10) + b;
     n = n / 10; 
}
Console.WriteLine("реверс   {0}",Reverse);

if (temp == Reverse)
{
    Console.WriteLine("да это же ПАЛИНДРОМ");
}
else
{
    Console.WriteLine("просто число");
}

