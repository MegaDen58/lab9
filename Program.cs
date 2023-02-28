using System;

public class Program
{
    public static void Main()
    {


        Student artem = new Student("Artem", 15, new int[] { 5, 5, 3, 4, 4 });
        Student dima = new Student("Dima", 15, new int[] { 2, 5, 3, 2, 4 });
        Student nikita = new Student("Nikita", 15, new int[] { 3, 3, 3, 3, 3 });
        Student bob = new Student("Bob", 15, new int[] { 5, 5, 5, 5, 5 });
        Student tom = new Student("Tom", 15, new int[] { 2, 5, 3, 3, 4 });
        Student steve = new Student("Steve", 15, new int[] { 5, 5, 2, 4, 4 });
        Student anton = new Student("Anton", 15, new int[] { 5, 5, 3, 3, 3 });

        Student[] students = new Student[] { artem, dima, nikita, bob, tom, steve, anton };
        Student[] newStudents = new Student[7];

        int[] estimation = { artem.grade.Sum(), dima.grade.Sum(), nikita.grade.Sum(), 
            bob.grade.Sum(), tom.grade.Sum(), steve.grade.Sum(), anton.grade.Sum() };

        estimation = MyFunction(estimation);

        for(int i = 0; i < students.Length; i++)
        {
            bool letsGo = true;
            while (letsGo)
            {
                for(int k = 0; k < estimation.Length; k++)
                {
                    if (estimation[i] == students[k].grade.Sum())
                    {
                        newStudents[i] = students[k];
                        letsGo = false;
                    }
                }
            }
        }

        Console.WriteLine(ArrayToString(newStudents));
    }

    public static string ArrayToString(Student[] array)
    {
        string result = "";
        for (int i = array.Length - 1; i >= 0; i--)
        {
            result += array[i].name + " ";
        }
        return result;
    }

    public static int[] MyFunction(int[] a)
    {
        for (int i = 1; i < a.Length; i++)
        {
            int k = a[i];
            int j = i - 1;

            while (j >= 0 && a[j] > k)
            {
                a[j + 1] = a[j];
                a[j] = k;
                j--;
            }
        }

        return a;
    }
}



public struct Student
{
    public string name;
    public int groupId;
    public int[] grade;
    public Student(string name, int groupId, int[] grade)
    {
        this.name = name;
        this.groupId = groupId;
        this.grade = grade;
    }
}