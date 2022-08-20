// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
int sum = 0;

while (true)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ",");

    }
    if (i > num)
    {
        break;
    }    
i ++;    
}
