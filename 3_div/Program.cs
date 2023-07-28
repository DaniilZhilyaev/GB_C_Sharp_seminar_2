/* Задача 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно */

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе  число: ");
int number2 = int.Parse(Console.ReadLine()!);

// Console.WriteLine(n);
// int res = ((n - n % 100) / 100) + n % 10;
// Console.Write((n - n % 100) / 100);
// Console.WriteLine(n % 10);

if(number1 % number2 == 0)
{
    Console.WriteLine($"Число {number1} кратно {number2}");
}
else 
{
    Console.WriteLine($"Не кратно, остаток {number1 % number2} ");
}