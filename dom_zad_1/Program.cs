/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.Clear();
System.Console.WriteLine("Эта программа покажет какое из чисел больше!");
System.Console.Write("Введите 1-ое число: ");
int firstNumber = int.Parse(Console.ReadLine());
System.Console.Write("Введите 2-ое число: ");
int secondNumber = int.Parse(Console.ReadLine());
if (firstNumber > secondNumber)
    System.Console.WriteLine("Наибольшее из введенных чисел: " + firstNumber);
else
    System.Console.WriteLine("Наибольшее из введенных чисел: " + secondNumber);
