/*
    Задача 2
    
    Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

    a = 5; b = 7 -> max = 7
    a = 2 b = 10 -> max = 10
    a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Пожалуйста введите 1-е число: ");

int firstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста введите 2-е число: ");

int secondNum = int.Parse(Console.ReadLine());

if (firstNum > secondNum)
{
    Console.WriteLine($"Большее число: {firstNum}, меньшее {secondNum}");
}
else
{
    Console.WriteLine($"Большее число: {secondNum}, меньшее {firstNum}");
}