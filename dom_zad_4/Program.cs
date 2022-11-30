// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
System.Console.WriteLine("Эта программа показывает все четные числа от 0 до введенного числа!");
System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
for (int i = 2; i <= num; i += 2)
{
    System.Console.WriteLine(i);
}

