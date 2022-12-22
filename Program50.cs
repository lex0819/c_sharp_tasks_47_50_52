/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

string CheckPositionElement(int row, int col, int[,] matrix)
{
  if (row > (matrix.GetLength(0) - 1) || col >= (matrix.GetLength(1) - 1))
  {
    return $"The element position {row},{col} is not exist.";
  }
  else
  {
    int res = matrix[row, col];
    return res.ToString();
  }
}

int[,] matrix = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

int row = GetNumber("Enter row position of the element in the matrix");
int col = GetNumber("Enter column position of the element in the matrix");
string result = CheckPositionElement(row, col, matrix);
Console.WriteLine(result);