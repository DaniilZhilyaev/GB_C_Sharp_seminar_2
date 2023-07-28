﻿﻿/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. (Проверка выхода за пределы значений недели, т.е. < 1 и > 7)
6 -> да
7 -> да
1 -> нет */

Console.Write("Введите номер дня недели, от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 0 && number < 6) Console.WriteLine("Будний день");
if (number > 5 && number < 8) Console.WriteLine("Выходной");
else if (number < 1 || number > 7) Console.WriteLine("Некорректный номер дня недели");