/* Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел*/

Console.Write("Введите первое число: ");
string numberFirst = Console.ReadLine();

Console.Write("Введите второе число: ");
string numberSecond = Console.ReadLine();

Console.Write("Введите третье число: ");
string numberThird = Console.ReadLine();

int numbFirst = int.Parse(numberFirst);
int numbSecond = int.Parse(numberSecond);
int numbThird = int.Parse(numberThird);

if (numbFirst > numbSecond && numbFirst > numbThird)
        Console.WriteLine($"a = {numbFirst}; b = {numbSecond}; c = {numbThird} -> max = {numbFirst}");
else if (numbSecond > numbFirst && numbSecond > numbThird)
        Console.WriteLine($"a = {numbFirst}; b = {numbSecond}; c = {numbThird} -> max = {numbSecond}");
else if (numbThird > numbFirst && numbThird > numbSecond)
        Console.WriteLine($"a = {numbFirst}; b = {numbSecond}; c = {numbThird} -> max = {numbThird}");
