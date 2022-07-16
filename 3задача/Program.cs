// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if ((num == 6) | (num == 7)) Console.WriteLine("Выходной день");
else if (num <= 5) Console.WriteLine("Будний день");
else Console.WriteLine("Нет такого дня недели");