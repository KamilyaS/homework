/* Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
a=5; b=7 ->7 max = 7
a=2; b=10 -> max = 10
a=-9; b=-3 -> max = -3 */

Console.WriteLine("Add numberA ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add numberB ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write("Max: ");
    Console.WriteLine(numberA);
    Console.Write("Min: ");
    Console.WriteLine(numberB);
}
else
{  
    Console.Write("Max: ");
    Console.WriteLine(numberB);
    Console.Write("Min: ");
    Console.WriteLine(numberA);
}
