/*
Используя Visual Studio, создайте проект по шаблону Console Application
Создайте программу в которой создайте целочисленную последовательность
размерностью 30 элементов (последовательность заполнить случайными числами),
содержащая как положительные, так и отрицательные числа. Вывести ее первый
положительный элемент и последний отрицательный элемент.
*/

using System;
using System.Globalization;

List<int> numbers = new List<int>();

Random random = new();
for (int i = 0; i < 30; i++)
{
    numbers.Add(random.Next(-20, 20));
}

int firstPositive = numbers.First(num => num > 0);
int lastNegative = numbers.Last(num => num < 0);

Console.WriteLine($"Первый положительный элемент коллекции: {firstPositive}");
Console.WriteLine($"Последний отрицательный элемент коллекции: {lastNegative}");
