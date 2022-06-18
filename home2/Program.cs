int a, b, c;
int max;
Console.WriteLine("Введите три числа ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (c > max)
{
    max = c;
}


Console.WriteLine("Ваше максимальное " +max);