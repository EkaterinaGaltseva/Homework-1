/* Напишите программу, которая на вход принимает число и выдает, является ли число четным*/

Console.Write("Введите число: ");
string numberFirst = Console.ReadLine();

int numbFirst = int.Parse(numberFirst);

if (numbFirst % 2 == 0)
        Console.WriteLine($"{numbFirst} -> да");
    else
        Console.WriteLine($"{numbFirst} -> нет");