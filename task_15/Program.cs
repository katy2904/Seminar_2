﻿/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите номер дня недели: ");
int weekday = Convert.ToInt32(Console.ReadLine());

if (weekday == 6 || weekday == 7) Console.WriteLine("Этот день выходной");
else Console.WriteLine("Это рабочий день");