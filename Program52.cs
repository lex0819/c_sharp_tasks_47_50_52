/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetNumber(string message)
{
  int result = 0;
  while (true)
  {
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out result))
    {
      break;
    }
    else
    {
      Console.WriteLine("You've entered incorrect number, please try again");
    }
  }
  return result;
}

int[,] InitMatrix(int rows, int cols)
{
  int[,] matrix = new int[rows, cols];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(1, 10);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}, ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

double[] CalculationAverageEachColumn(int[,] matrix)
{
  int row = matrix.GetLength(0);
  int col = matrix.GetLength(1);
  double[] averages = new double[col];
  for (int j = 0; j < col; j++)
  {
    double sum = 0;
    for (int i = 0; i < row; i++)
    {
      sum += matrix[i, j];
    }
    double average = sum / row;
    averages[j] = Math.Round(average, 2);
  }
  return averages;
}

void PrintArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} , ");
  }
  Console.WriteLine();
}

int rows = GetNumber("Enter rows of matrix");
int cols = GetNumber("Enter columns of matrix");
int[,] matrix = InitMatrix(rows, cols);
PrintMatrix(matrix);

double[] averages = CalculationAverageEachColumn(matrix);

Console.Write("The averages of each column are ");
PrintArray(averages);
