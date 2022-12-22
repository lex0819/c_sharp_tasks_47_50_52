/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
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

double GetRandomNumber(double minimum, double maximum)
{
  Random random = new Random();
  return random.NextDouble() * (maximum - minimum) + minimum;
}

double[,] InitMatrix(int rows, int cols)
{
  double[,] matrix = new double[rows, cols];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      double inputValue = GetRandomNumber(-99, 100);
      matrix[i, j] = Math.Round(inputValue, 2);
    }
  }
  return matrix;
}

void PrintArray(double[,] matrix)
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

int rows = GetNumber("Enter rows of matrix");
int cols = GetNumber("Enter columns of matrix");
double[,] matrix = InitMatrix(rows, cols);
PrintArray(matrix);
