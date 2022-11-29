System.Console.WriteLine("Введите числа, которые нужно проверить");
System.Console.WriteLine("Введите число № 1");
int firstNumber = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число № 2");
int secondNumber = int.Parse(Console.ReadLine());
if (secondNumber * secondNumber == firstNumber)
    System.Console.WriteLine("Первое число является квадратом второго");
else
    System.Console.WriteLine("Первое число никак не связано со вторым");
