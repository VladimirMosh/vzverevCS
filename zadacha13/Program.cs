﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введи число: ");
int anyNum = Convert.ToInt32(Console.ReadLine());
string anyNumText = Convert.ToString(anyNum);
if (anyNumText.Length > 2)
{
    Console.WriteLine("третья цифра -" + anyNumText[2]);
}
else
{
    Console.WriteLine("-третьей цифры нет");
}