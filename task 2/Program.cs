/* Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
2,3,7 -> 7
44,5,78 -> 78
22,33,9 -> 22 */

Console.WriteLine("Add numberA ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add numberB ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add numberC ");
int numberC = Convert.ToInt32(Console.ReadLine());
int Max = numberA;
if (numberB > Max) Max = numberB;
if (numberC > Max) Max = numberC;
Console.Write("Max: ");
Console.WriteLine(Max);