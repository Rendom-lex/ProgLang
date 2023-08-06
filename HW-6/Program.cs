// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

int num;
Console.WriteLine("Введите число:");
num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("{0} четное", num);
}
else
{
    Console.WriteLine("{0} не четное", num);
};