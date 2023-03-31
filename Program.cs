using System;

class Class<T>
{
    public List<T> list = new List<T>();
    public List<T> login = new List<T>();
    public List<T> password = new List<T>();

    public void addNumber(params T[] value)
    {
        foreach (T a in value)
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

class User<T> : Class<T>
{
    public User(T login, T password) 
    {
        this.login.Add(login);
        this.password.Add(password);
    }
}


public class Program
{
    public static void Main()
    {
        Class<string> text = new Class<string>();
        Class<int> number = new Class<int>();
        Class<double> doubles = new Class<double>();

        text.addNumber("tom", "text", "college");
        number.addNumber(5, 10, 20);
        doubles.addNumber(1.35, 0.66, 122.1);

        User<string> first = new User<string>("ggff", "password123");
        User<string> second = new User<string>("login", "123");
    }
}