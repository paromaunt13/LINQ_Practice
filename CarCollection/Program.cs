/*
Используя Visual Studio, создайте проект по шаблону Console Application
Создайте программу для автостанции, в которой вам необходимо создать простую
коллекцию автомобилей со следующими данными: Марка автомобиля, модель, год
выпуска, цвет. А также вторую коллекцию с моделью автомобиля, именем покупателя и
его номером телефона. Используя простейший LINQ запрос, выведите на экран
информацию о покупателе одного из автомобилей и полную характеристику
приобретенной ними модели.
*/

using System.Collections;
using System.Collections.Generic;

List<Car> cars = new()
{
    new("Volvo","C40", 2020, "красный"),
    new("Audi","A3", 2013, "серый"),
    new("KIA","Sportage", 2017, "белый"),
    new("Citroen","Berlingo", 2009, "синий"),
    new("BMW","X5", 2019, "черный")
};

List<Customer> customers = new()
{
    new("C40", "Александр", "+380957856437"),
    new("A3", "Роман", "+380963540928"),
    new("Sportage", "Дмитрий", "+380930129345"),
    new("Berlingo", "Кирилл", "+380998473610"),
    new("X5", "Сергей", "+380970918231"),
};

var infoList = from car in cars
               join customer in customers on car.Model equals customer.Model
               select new {car.Brand, car.Model, car.Color, car.ManufactureYear, customer.Name, customer.PhoneNumber };

foreach (var item in infoList)
{
    Console.WriteLine("\tИнформация о покупателе:");
    Console.WriteLine($"Имя - {item.Name} \nНомер телефона: {item.PhoneNumber}");
    Console.WriteLine("\tИнформация о приобретенном автомобиле:");
    Console.WriteLine($"Марка {item.Brand}" +
        $"\nМодель {item.Model} " +
        $"\nЦвет {item.Color} " +
        $"\nГод выпуска {item.ManufactureYear}");
    Console.WriteLine(new string('-', 60));
}

class Car 
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int ManufactureYear { get; set; }
    public string Color { get; set; }
    public Car(string brand, string model, int year, string color)
    {
        Brand = brand;
        Model = model;
        ManufactureYear = year;
        Color = color;
    }
}

class Customer
{
    public string Model { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public Customer(string model, string name, string phoneNumber)
    {
        Model = model;
        Name = name;
        PhoneNumber = phoneNumber;
    }
}

