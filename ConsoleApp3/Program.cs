using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

public class Something<T> : Collection<T>
{
    public Something() : base(new List<T>()) { }

    public T this[int index]
    {
        get { return Items[index]; }
        set { Items[index] = value; }
    }

    public void AddItem(T item)
    {
        Add(item);
    }

    public void RemoveItemAt(int index)
    {
        RemoveAt(index);
    }

    public void ClearItems()
    {
        Clear();
    }

    public bool ContainsItem(T item)
    {
        return Contains(item);
    }

    public int IndexOfItem(T item)
    {
        return IndexOf(item);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Something<int> collection = new Something<int>();

        collection.AddItem(99);
        collection.AddItem(2);
        collection.AddItem(3);

        Console.WriteLine(collection[0]);

        collection.ClearItems();

        Console.ReadLine();
    }
}