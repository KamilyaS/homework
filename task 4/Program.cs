﻿/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
5 -> 2,4
8 -> 2,4,6,8 */

Console.WriteLine("Add numberA ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 2;

while (numberA >= numberB)
{
    Console.Write(numberB + " ");
    numberB = numberB +2;
}