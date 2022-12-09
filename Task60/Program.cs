// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] GenerateUniqueRandom3DArray(int rows, int columns, int depth, int min, int max)
{
    int[,,] arr = new int[rows, columns, depth];
    Random rnd = new Random();
    for (var i = 0; i < arr.GetLength(0); i++)
    {
        for (var j = 0; j < arr.GetLength(1); j++)
        {
            for (var k = 0; k < arr.GetLength(2); k++)
            {
                bool unique = false;
                while (!unique)
                {
                    int randomValue = rnd.Next(min, max + 1);
                    if (!In3DArray(arr, randomValue))
                    {
                        arr[i, j, k] = randomValue;
                        unique = true;
                    }
                }

            }
        }
    }
    return arr;
}

bool In3DArray(int[,,] arr, int value)
{
    for (var i = 0; i < arr.GetLength(0); i++)
    {
        for (var j = 0; j < arr.GetLength(1); j++)
        {
            for (var k = 0; k < arr.GetLength(2); k++)
            {
                if (value == arr[i, j, k])
                    return true;
            }
        }
    }
    return false;
}

void Print3DArray(int[,,] arr)
{
    for (var i = 0; i < arr.GetLength(0); i++)
    {
        for (var j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("| ");
            for (var k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.Write("|");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Print3DArray(GenerateUniqueRandom3DArray(2, 2, 2, 10, 99));