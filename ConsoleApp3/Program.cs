using System;

public class MyArray<T>
{
    private T[] _array;
    private int _lenght;

    public MyArray(T[] array, int lenght)
    {
        _array = new T[lenght];
        Array.Copy(array,_array,array.Length);
        _lenght = lenght;
    }

    public int Lenght
    {
        get
        {
            return _lenght;
        }
    }

    public T this[int number]
    {
        get
        {
            return _array[number];
        }
        set
        {
            _array[number] = value;
        }
    }

    public void AddElement(T item)
    {
        T[] array = new T[_lenght + 1];
        for (int i = 0; i < _lenght;i++)
        {
            array[i] = _array[i];
        }
        array[_lenght] = item;
        _lenght++;
        _array = array;
    }

    public void RemoveElement(int index)
    {

        T[] array = new T[_lenght + 1];
        for (int i = 0; i < index; i++)
        {
            array[i] = _array[i];
        }
        for (int i = index; i < _lenght - 1; i++)
        {
            array[i] = _array[i + 1];
        }
        _lenght--;
        _array = array;
    }
};

class Program
{
    static void Main(string[] args)
    {
        int[] arr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        MyArray<int> test = new MyArray<int>(arr,10);

        Console.WriteLine(test[8]);
        test.AddElement(10);

        Console.WriteLine(test[10]);
        test.RemoveElement(8);

        Console.WriteLine(test[8]);
        Console.ReadLine();
    }
}