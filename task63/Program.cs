﻿// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("введите натуральное число");
int number = int.Parse(Console.ReadLine());
NaturalNumbers(number);
void NaturalNumbers(int num)
{
    if(num == 0) return;
   
    Console.Write($"{num} ");
     NaturalNumbers(num - 1);
}
