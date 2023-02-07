// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillMatrix(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}

void PrintMartix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}

void PrintUMartix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        double count = 0;
        double summ = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            summ += matr[i,j];
            count++;
        }       
        double result = summ / count;
        System.Console.Write($"{Math.Round(result,1)} ");
    }

}

int[,] matrix = FillMatrix(4, 4);
PrintMartix(matrix);
System.Console.WriteLine();
PrintUMartix(matrix);

