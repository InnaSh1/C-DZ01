﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите число : ");
int n = int.Parse(Console.ReadLine());
int count = (2);

while (count <= n) 
{
    Console.WriteLine($"{count}, ");
    count = count + 2;
}
