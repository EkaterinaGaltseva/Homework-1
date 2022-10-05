/* Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее*/

Console.WriteLine("Введите первое число: ");
string numberFirst = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string numberSecond = Console.ReadLine();

int numbFirst = int.Parse(numberFirst);
int numbSecond = int.Parse(numberSecond);

if (numbFirst > numbSecond)
        Console.WriteLine($"a = {numbFirst}; b = {numbSecond} -> max = {numbFirst}");
    else
        Console.WriteLine($"a = {numbFirst}; b = {numbSecond} -> max = {numbSecond}");