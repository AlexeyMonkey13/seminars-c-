Console.Clear();
Console.WriteLine("Введите три значения для каждой координаты ");

double x1 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToInt32(Console.ReadLine());
double z1 = Convert.ToInt32(Console.ReadLine());
double x2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());
double z2 = Convert.ToInt32(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x1 - (x2), 2) + Math.Pow(y1 - (y2), 2) + Math.Pow(z1 - (z2), 2));
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("ответ: {0}" , d ) ;
