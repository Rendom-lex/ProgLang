// Задача 4: Напишите программу, 
//которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1, num2, num3;
Console.WriteLine("Введите три числа:");
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.Write("max = ");
Console.WriteLine(max);