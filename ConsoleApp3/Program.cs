using System;

class SquareMatrix      //Все новое нашёл в интернете
{
    private int[,] matrix;

    public SquareMatrix(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);       

        if (rows != cols)
        {
            throw new Exception("Не квадратная");
        }

        matrix = new int[rows, rows];
        Array.Copy(array, matrix, array.Length);
    }

    public SquareMatrix ADD( SquareMatrix matrix2)
    {
        int size = this.matrix.GetLength(0);
        int[,] result = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                result[i, j] = this.matrix[i, j] + matrix2.matrix[i, j];
            }
        }

        return new SquareMatrix(result);
    }

    public SquareMatrix Minus(SquareMatrix matrix2)
    {
        int size = this.matrix.GetLength(0);
        int[,] result = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                result[i, j] = this.matrix[i, j] - matrix2.matrix[i, j];
            }
        }

        return new SquareMatrix(result);
    }

    public void PrintMatrix()
    {
        int size = matrix.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[,] array1 = {
            { 1, 2, 3 }, 
            { 4, 5, 6 }, 
            { 7, 8, 9 } 
        };
        int[,] array2 = { 
            { 9, 8, 7 }, 
            { 6, 5, 4 }, 
            { 3, 2, 1 } 
        };

        SquareMatrix matrix1 = new SquareMatrix(array1);
        SquareMatrix matrix2 = new SquareMatrix(array2);

        Console.WriteLine("Матрица 1:");
        matrix1.PrintMatrix();
        Console.WriteLine("\nМатрица 2:");
        matrix2.PrintMatrix();

        SquareMatrix sum = matrix1.ADD(matrix2);
        SquareMatrix minus = matrix1.Minus(matrix2);

        Console.WriteLine("\nСумма матриц:");
        sum.PrintMatrix();

        Console.WriteLine("\nРазность матриц:");
        minus.PrintMatrix();
    }
}