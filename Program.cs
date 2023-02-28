using System;

enum Day
{
    Понедельник,
    Вторник,
    Среда,
    Четверг,
    Пятница,
    Суббота,
    Воскресенье
}

enum Time
{
    Утро,
    День,
    Вечер,
    Ночь
}

public class Program
{


    public static void Main()
    {
        Console.Write("Введите день недели: ");
        string day = Console.ReadLine();

        Console.Write("Введите время в часах: ");
        int time = Convert.ToInt32(Console.ReadLine());
        string result = "";

        switch (day)
        {
            case "Понедельник":
                result += "Сейчас " + Day.Понедельник; break;
            case "Вторник":
                result += "Сейчас " + Day.Вторник; break;
            case "Среда":
                result += "Сейчас " + Day.Среда; break;
            case "Четверг":
                result += "Сейчас " + Day.Четверг; break;
            case "Пятница":
                result += "Сейчас " + Day.Пятница; break;
            case "Суббота":
                result += "Сейчас " + Day.Суббота; break;
            case "Воскресенье":
                result += "Сейчас " + Day.Воскресенье; break;
        }

        if (time >= 0 && time <= 6)
        {
            result += ", " + Time.Ночь;
        }
        if (time >= 7 && time <= 12)
        {
            result += ", " + Time.Утро;
        }
        if (time >= 13 && time <= 18)
        {
            result += ", " + Time.День;
        }
        if (time >= 19 && time <= 23)
        {
            result += ", " + Time.Вечер;
        }

        Console.WriteLine(result);
    }
}