// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Первое число ");
int Num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число ");
int Num2 = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if(Num1 > Num2)
{
    max = Num1;
    min = Num2;
}

else{
    max = Num2;
    min = Num1;
}
Console.WriteLine("большее = " + max + "    " + "меньшее = " + min);
