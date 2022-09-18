/*
    Задача 4:
        Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        2, 3, 7 -> 7
        44 5 78 -> 78
        22 3 9 -> 22
*/

Console.WriteLine("Пожалуйста введите 1-е число: ");

int firstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста введите 2-е число: ");

int secondNum = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста введите 3-е число: ");

int thirdNum = int.Parse(Console.ReadLine());

if (firstNum > secondNum && firstNum > thirdNum)
{
    Console.WriteLine(firstNum);
}
else if (secondNum > thirdNum)
{
    Console.WriteLine(secondNum);
}
else
{
    Console.WriteLine(thirdNum);
}