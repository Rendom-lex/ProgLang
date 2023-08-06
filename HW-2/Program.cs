// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

int num1, num2;
Console.WriteLine("Введите два числа:");
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("{0} максимальное", num1);
    Console.WriteLine("{0} минимальное", num2);
}
if (num2 > num1)
{
    Console.WriteLine("{0} максимальное", num2);
    Console.WriteLine("{0} минимальное", num1);
}
Console.ReadLine();


