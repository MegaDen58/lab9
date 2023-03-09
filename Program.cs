using System;


abstract class Transport
{
    public Transport(string name, int speed, double weight, int distance)
    {
        Name = name;
        Speed = speed;
        Weight = weight;
        Distance = distance;
    }
    public abstract string Name { get; set; }
    public abstract int Speed { get; set; }
    public abstract double Weight { get; set; }
    public abstract int Distance { get; set; }
}

abstract class Auto : Transport
{
    public Auto(string name, int speed, double weight, int distance) : base(name, speed, weight, distance) { }
    public abstract void NameInfo();
    public abstract void SpeedInfo();
    public abstract void WeightInfo();
    public abstract void DistanceInfo();
}

abstract class Airplane : Transport
{
    public Airplane(string name, int speed, double weight, int distance) : base(name, speed, weight, distance) { }
    public abstract void NameInfo();
    public abstract void SpeedInfo();
    public abstract void WeightInfo();
    public abstract void DistanceInfo();
}

abstract class Ship : Transport
{
    public Ship(string name, int speed, double weight, int distance) : base(name, speed, weight, distance) { }
    public abstract void NameInfo();
    public abstract void SpeedInfo();
    public abstract void WeightInfo();
    public abstract void DistanceInfo();
}

class Ford : Auto
{
    public Ford(string name, int speed, double weight, int distance) : base(name, speed, weight, distance) { }
    public override string Name { get; set; }
    public override int Speed { get; set;}
    public override double Weight { get; set;}
    public override int Distance { get; set;}

    public override void NameInfo()
    {
        Console.WriteLine($"Наименование авто: {Name}.");
    }

    public override void DistanceInfo()
    {
        Console.WriteLine($"Дистанция, проезжаемая автомобилем: {Distance} км.");
    }

    public override void WeightInfo()
    {
        Console.WriteLine($"Грузоподъемность автомобиля: {Weight} тонн.");
    }

    public override void SpeedInfo()
    {
        Console.WriteLine($"Скорость автомобиля: {Speed}");
    }
}

class Boieng : Airplane
{
    public Boieng(string name, int speed, double weight, int distance) : base(name, speed, weight, distance) { }
    public override string Name { get; set; }
    public override int Speed { get; set; }
    public override double Weight { get; set; }
    public override int Distance { get; set; }

    public override void NameInfo()
    {
        Console.WriteLine($"Наименование самолёта: {Name}.");
    }

    public override void DistanceInfo()
    {
        Console.WriteLine($"Дистанция, пролетаемая самолетом: {Distance} км.");
    }

    public override void WeightInfo()
    {
        Console.WriteLine($"Грузоподъемность самолёта: {Weight} тонн.");
    }

    public override void SpeedInfo()
    {
        Console.WriteLine($"Скорость самолёта: {Speed}");
    }
}

class Titanic : Ship
{
    public Titanic(string name, int speed, double weight, int distance) : base(name, speed, weight, distance) { }
    public override string Name { get; set; }
    public override int Speed { get; set; }
    public override double Weight { get; set; }
    public override int Distance { get; set; }

    public override void NameInfo()
    {
        Console.WriteLine($"Наименование корабля: {Name}.");
    }

    public override void DistanceInfo()
    {
        Console.WriteLine($"Дистанция, проходимая короблём: {Distance} км.");
    }

    public override void WeightInfo()
    {
        Console.WriteLine($"Грузоподъемность коробля: {Weight} тонн.");
    }

    public override void SpeedInfo()
    {
        Console.WriteLine($"Скорость коробля: {Speed}");
    }
}

public class Program
{
    public static void Main()
    {
        Ford ford = new Ford("Ford", 100, 5, 500);
        Boieng boieng = new Boieng("Boieng 777", 300, 1000, 10000);
        Titanic titanic = new Titanic("Titanic", 200, 5000, 7000);

        ford.NameInfo();
        ford.DistanceInfo();
        ford.WeightInfo();
        ford.SpeedInfo();
    }
}