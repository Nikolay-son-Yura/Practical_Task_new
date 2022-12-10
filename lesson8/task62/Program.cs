// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillArraySpiral( int[,]array, int rows, int cols )
{
  int sum = rows * cols;
  int numY = 0;
  int numx = 0;
  int num = 1;
  while( cols > 0 )
  {
    for ( int i = 0; i < array.GetLength(0); i++ )
    {
      for ( int j = 0; j < ( ( rows < cols ) ? cols : rows ); j++ )
      {
        if ( i == 0 && j < rows - numx && num <= sum )
          array[i + numY,j + numx] = num++;
        if ( i == 1 && j < cols - numY && j != 0 && num <= sum )
          array[j + numY,rows - 1] = num++;
        if ( i == 2 && j < rows - numx && j != 0 && num <= sum )
          array[cols - 1,rows - (j + 1)] = num++;
        if ( i == 3 && j < cols - ( numY + 1 ) && j != 0 && num <= sum )
          array[cols - (j + 1),numY] = num++;
      }
    }
    cols--;
    rows--;
    numY += 1;
    numx += 1;
  }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int rows = 5;
int cols = 5;
int[,] massive = new int[rows, cols];
FillArraySpiral(massive,rows,cols);
PrintArray(massive);
