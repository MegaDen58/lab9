using System;
using System.ComponentModel.DataAnnotations;

class Class<T>
{
    List<T> list = new List<T>();

    public void addNumber(params T[] value)
    {
        foreach(T a in value)
        {
            list.Add(a);
        }
    }

    public void deleteNumber(int number)
    {
        list.RemoveAt(number);
    }

    public T getNumber(int number)
    {
        return list[number];
    }

    public int getLenght()
    {
        return list.Count;
    }
}
public class Program
{
    public static void Main()
    {
        Class<String> text = new Class<String>();
        Class<int> number = new Class<int>();
        Class<double> doubles = new Class<double>();

        text.addNumber("tom", "text", "college");
        number.addNumber(5, 10, 20);
        doubles.addNumber(1.35, 0.66, 122.1);
    }
}