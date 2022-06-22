int N, i;

Console.Write("Выберите диапазон ");
N = Convert.ToInt32(Console.ReadLine());

i = 1;

while (i <= N)
{
    if (i%2 == 0)
    {   
      
       Console.Write(i + " ");
    }
    i++;
}