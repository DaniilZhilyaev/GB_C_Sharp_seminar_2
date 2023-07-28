/* Задача 4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.о */

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе  число: ");
int number2 = int.Parse(Console.ReadLine()!);



if(Convert.ToInt32(Math.Pow(number1, 2)) == number2)  Console.WriteLine($"Число {number1} квадрат числа {number2}");
else if (Convert.ToInt32(Math.Pow(number2, 2)) == number1)  Console.WriteLine($"Число {number2} квадрат числа {number1}");
else Console.WriteLine($"Числа {number1} и {number2} не являются квадратами друг друга");