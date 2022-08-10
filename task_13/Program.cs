/*
 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
через строки:
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number / 100) == 0) Console.WriteLine($"У числа {number} нет третьей цифры");
else
{
    string num = Convert.ToString(number);  //возможно есть метод конвертации переменной, но я его пока не знаю, поэтому ввела еще одну переменную :)
    Console.WriteLine($"У числа {number} третья цифра {num[2]}");
}
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number / 100) == 0) Console.WriteLine($"У числа {number} нет третьей цифры");

int count = 0;
int num = number;

while (num > 0)
{
    count++;
    num /= 10;
}
 
int div = Convert.ToInt32(Math.Pow(10, (count - 3)));

int digit = number / div % 10;

Console.Write($"у числа {number} третья цифра равна {digit}");