/* Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 88 */

int n = new Random().Next(200);

if (n > 10 && n < 100)
{
    string nstr = n.ToString();
    string n11 = nstr[0].ToString();
    string n22 = nstr[1].ToString();
    int n1 = Convert.ToInt32(n11);
    int n2 = Convert.ToInt32(n22);
    if (n1 > n2) Console.WriteLine($"В цифре {n}, число {n1} наибольшее");
    if (n1 < n2) Console.WriteLine($"В цифре {n}, число {n2} наибольшее");
}
else
{
    Console.WriteLine($"число {n} не в дипазоне от 10 до 99");
}
