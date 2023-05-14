/*
Используя Visual Studio, создайте проект по шаблону Console Application
Создайте программу в которой создайте последовательность, которая содержит
сведения о клиентах фитнес-центра. Каждый элемент последовательности включает
следующие целочисленные поля: «Код клиента», «Год», «Номер месяца»,
«Продолжительность занятий (в часах)». Найти элемент последовательности с
минимальной продолжительностью занятий. Вывести эту продолжительность, а также
соответствующие ей год и номер месяца (в указанном порядке на той же строке). Если
имеется несколько элементов с минимальной продолжительностью, то вывести данные
того из них, который является последним в исходной последовательности.
*/


List<Clients> clients = new()
{
    new(1, 1995, 09, 100),
    new(2, 1998, 05, 150),
    new(3, 1999, 11, 45),
    new(4, 1993, 03, 80),
    new(5, 1994, 10, 55),
};

var durationList = clients.OrderBy(d => d.HourDuration);

var info = from c in durationList
           select new {c.HourDuration, c.Year, c.Month, c.ID};

foreach (var item in info)
{
    Console.WriteLine($"ID клиента: {item.ID} \nПродолжительность занятий: {item.HourDuration} часов \nГод {item.Year}, месяц {item.Month}");
}

class Clients
{
    public int ID { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
    public int HourDuration { get; set; }

    public Clients(int iD, int year, int month, int hourDuration)
    {
        ID = iD;
        Year = year;
        Month = month;
        HourDuration = hourDuration;
    }
}