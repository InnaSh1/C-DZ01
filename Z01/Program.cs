// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.WriteLine ("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()); 

Console.WriteLine ("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()); 

string s = "";
if (numberA > numberB)
{
    s = "max = numberA, min = numberB";
}
if (numberA < numberB);
{
    s = "max = numberB, min = numberA";
}
System.Console.WriteLine(s);
