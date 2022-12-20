// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.WriteLine ("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()); 

Console.WriteLine ("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()); 

Console.WriteLine ("Введите число C: ");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine(max);
