using System;

public class Animal
{
    public string name;
    public string food;
    public string location;

    public Animal(string name, string food, string location)
    {
        this.name = name;
        this.food = food;
        this.location = location;
    }

    public virtual void MakeNoise()
    {
        Console.WriteLine($"{name} шумит.");
    }

    public virtual void Eat()
    {
        Console.WriteLine($"{name} ест {food}.");

    }

    public virtual void Sleep()
    {
        Console.WriteLine($"{name} спит в {location}.");
    }
}

class Dog : Animal
{
    bool collar;

    public Dog(string name, string food, string location, bool collar) : base(name, food, location)
    {
        this.name = name;
        this.food = food;
        this.location = location;
        this.collar = collar;
    }

    public override void MakeNoise()
    {
        Console.WriteLine($"Собака {name} гавкает.");
    }

    public override void Eat()
    {
        Console.WriteLine($"Собака {name} ест {food}.");

    }

    public override void Sleep()
    {
        Console.WriteLine($"Собака {name} спит в  {location}.");

    }
}

class Cat : Animal
{
    string CoatColor;

    public Cat(string name, string food, string location, string coatColor) : base(name, food, location)
    {
        this.name = name;
        this.food = food;
        this.location = location;
        this.CoatColor = coatColor;
    }

    public override void MakeNoise()
    {
        Console.WriteLine($"Кот {name} мяукает.");
    }

    public override void Eat()
    {
        Console.WriteLine($"Кот {name} ест {food}.");

    }

    public override void Sleep()
    {
        Console.WriteLine($"Кот {name} спит в {location}.");

    }
}

class Horse : Animal
{
    string owner;

    public Horse(string name, string food, string location, string owner) : base(name, food, location)
    {
        this.name = name;
        this.food = food;
        this.location = location;
        this.owner = owner;
    }

    public override void MakeNoise()
    {
        Console.WriteLine($"Лошадь {name} издает звуки.");
    }

    public override void Eat()
    {
        Console.WriteLine($"Лошадь {name} ест {food}.");

    }

    public override void Sleep()
    {
        Console.WriteLine($"Лошадь {name} спит в {location}.");

    }
}

class Veterinarian
{
    public void treatAnimal(params Animal[] animals)
    {
        foreach(Animal animal in animals){
            Console.WriteLine($"Животное {animal.name}, живущее в {animal.location}, ест {animal.food}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Cat cat = new Cat("Вася", "корм", "доме", "дымчатый");
        Dog dog = new Dog("Собака", "корм", "доме", true);
        Horse horse = new Horse("Юлий", "яблоко", "конюшне", "Иванов С.А.");
        Veterinarian veterinarian = new();

        cat.Eat();
        cat.Sleep();
        cat.MakeNoise();
        Console.WriteLine();

        dog.Eat();
        dog.Sleep();
        dog.MakeNoise();
        Console.WriteLine();

        horse.Eat();
        horse.Sleep();
        horse.MakeNoise();
        Console.WriteLine();

        veterinarian.treatAnimal(dog, cat, horse)
    }
}