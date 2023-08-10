// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1




Console.Write("Введи трёхзначное число- ");
int threeDigitNum = Convert.ToInt32(Console.ReadLine());
string stringNum = Convert.ToString(threeDigitNum);
Console.WriteLine("вторая цифра этого числа -> " + stringNum[1]);
