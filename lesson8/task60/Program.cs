// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]}({i},{j},{k})" + "\t");
            }
        }
        System.Console.WriteLine();
    }
}


void FillThreArray(int[,,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(min, max);
                // долго бьюсь уже, с уникальностью чисел,мозгов не хватает
                // for (int x = 0; x < array.Length; x++)
                // {
                //     for (int y = 0; y < array.Length; y++)
                //     {
                //         for (int z = 0; z <array.Length; z++)
                //         {
                //             if (array[i, j, k] != array[i + x, j + x, k + x])
                //             {
                //                 array[i, j, k]++;
                //             }
                //         }

                //     }
                // }
            }

        }
    }
}

int rows = 2;
int cols = 2;
int depth = 2;
int[,,] massive = new int[rows, cols, depth];
FillThreArray(massive, 10, 100);

PrintArray(massive);

