/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();
int firstNumber, secondNumber, thirdNumber;
System.Console.WriteLine("Введите числа для сравнения");
System.Console.Write("1-ое число: ");
firstNumber = int.Parse(Console.ReadLine());
System.Console.Write("2-ое число: ");
secondNumber = int.Parse(Console.ReadLine());
System.Console.Write("3-ое число: ");
thirdNumber = int.Parse(Console.ReadLine());
if (secondNumber < firstNumber)
{
    int temp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temp;
}
if (secondNumber > thirdNumber)
{
    int temp_1 = secondNumber;
    secondNumber = thirdNumber;
    thirdNumber = temp_1;
}
System.Console.WriteLine("Наибольшее число: " + thirdNumber);






