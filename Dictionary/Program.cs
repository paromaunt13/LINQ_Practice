/*
 Используя Visual Studio, создайте проект по шаблону Console Application
Создайте программу, в которой, используя динамические и анонимные типы данных,
создайте Англо-Русский словарь на 10 слов и выведите на экран его содержание.
*/

Dictionary<dynamic, dynamic> dictionary = new();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Введите слово:");
    var word = Console.ReadLine();

    Console.WriteLine("Введите перевод:");
    dynamic translation = Console.ReadLine();

    dictionary.Add(word, translation);
}

foreach (var item in dictionary)
{
    Console.WriteLine(item.Key + " - " + item.Value);
}
