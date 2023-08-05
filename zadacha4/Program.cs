// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Первое число")
int Num1 = convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число")
int Num2 = convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье число")
int Num3 = convert.ToInt32(Console.ReadLine());
int max = 0;
if (Num1 > max)
{
    max = Num1;
}
if (Num2 > max)
{
    max = Num2;
}
if (Num3 > max)
{
    max = Num3;
}

Console.WriteLine("максимальное число" max);