/* Напишите программу, которая на вход принимает число, а на выходе показывает все четные числа от 1 до заданного числа*/

Console.Write("Введите число: ");
string number = Console.ReadLine();

int numb = int.Parse(number);
Console.Write($"{number} -> ");
for (int numberFirst = 2; numberFirst <= numb; numberFirst ++ )
    if (numberFirst % 2 == 0)
    Console.Write($" {numberFirst},");
