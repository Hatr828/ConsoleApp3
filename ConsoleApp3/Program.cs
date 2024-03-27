using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;

public class MyClass
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Value { get; set; }
    public DateTime Date { get; set; }
}

public static class Extensions
{
    public static int  CountSameNumber<T>(this IEnumerable<T> obj, T value)
    {
        return obj.Count(item => item.Equals(value));
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass[] objects = new MyClass[]
        {
            new MyClass { Id = 1, Name = "Object 1", Description = "Description 1", Value = 10.5, Date = DateTime.Now },
            new MyClass { Id = 2, Name = "Object 2", Description = "Description 2", Value = 20.3, Date = DateTime.Now },
            new MyClass { Id = 3, Name = "Object 3", Description = "Description 3", Value = 30.8, Date = DateTime.Now }
        };

        var sP = objects.Select(obj => new { obj.Name, obj.Value }).ToArray();
        foreach (var obj in sP)
        {
            Console.WriteLine($"Name: {obj.Name}, Value: {obj.Value}");
        }
        ///////////////////////////////////////////////////////////////////////////
        dynamic expando = new ExpandoObject();

        expando.Name = "John";
        expando.Age = 30;

        Console.WriteLine($"Name: {expando.Name}, Age: {expando.Age}");
    }
   
}