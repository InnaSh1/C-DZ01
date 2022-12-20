// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делиться ли оно на два без остатка)

Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.Read());

if (a % 2 == 0) 
    Console.WriteLine("Да, число четное");

else 
    Console.WriteLine("Нет, число нечетное");
