/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу в которой создайте класс Calculator, методы которого принимают
аргументы и возвращают значения типа dynamic.
*/

Calculator calculator = new();

Console.WriteLine(calculator.Addition(10, "hi"));
Console.WriteLine(calculator.Subtract(34.8756, 0.34598));
Console.WriteLine(calculator.Multiply(90.34, 71.386));
Console.WriteLine(calculator.Divide(12409, 73));
class Calculator
{
    public dynamic Addition(dynamic a, dynamic b)
    {
        return a + b;
    }
    public dynamic Subtract(dynamic a, dynamic b)
    {
        return a - b;
    }
    public dynamic Multiply(dynamic a, dynamic b)
    {
        return a * b;
    }
    public dynamic Divide(dynamic a, dynamic b)
    {
        return a / b;
    }
}