/* Напишите программу, которая принимает на вход случайное трехзначное число и удаляет вторую цифру этого числа
456 -> 46
782 -> 72
918 -> 98 */

int n = new Random().Next(1000);

// Console.WriteLine(n);
// int res = ((n - n % 100) / 100) + n % 10;
// Console.Write((n - n % 100) / 100);
// Console.WriteLine(n % 10);

string nstr = n.ToString();

if(nstr.Length == 3)
{
    Console.WriteLine($"Трехзначное число {n} без второй цифры имее вид {nstr[0]}{nstr[2]}");

}
else 
{
    Console.WriteLine($"число {n} не трехзначное");
}
