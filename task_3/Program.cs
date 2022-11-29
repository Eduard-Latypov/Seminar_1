System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int num_2 = -1 * num;
while (num_2 != num + 1)
{
    System.Console.Write(num_2 + " ");
    num_2++;
}
