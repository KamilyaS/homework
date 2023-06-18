/* Напишите программу, которая принимает на вход число и выдает, является ли число четным (делится ли оно на 2 без остатка)
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Add numberA ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 0) 
    Console.Write("Yes");
else
{
    Console.Write("No");
}
