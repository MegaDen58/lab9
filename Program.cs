using System;

class Car
{
    public string Name { get; set; }

    public Car(string name)
    {
        Name = name;
    }
}

class Garage
{
    public List<Car> cars = new List<Car>();

    public Garage(params Car[] autos)
    {
        foreach (Car car in autos)
        {
            cars.Add(car);
        }
    }
}

class Washer
{
    public void Wash(Car car)
    {
        Console.WriteLine($"Автомобиль {car.Name} помыт.");
    }
}

class HelloWorld
{
    static void Main()
    {
        Garage garage = new Garage(new Car("Auto"), new Car("New Auto"));
        Washer washer = new Washer();

        CarWasher carWasher = washer.Wash;

        foreach (Car car in garage.cars)
        {
            carWasher(car);
        }
    }

    delegate void CarWasher(Car car);
}