// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int [,] CreateRandom2dArray(int rows, int columns, int minVolue, int maxVolue)
{
    int [,] array = new int [rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minVolue, maxVolue + 1);
    return array;
}
void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

            Console.WriteLine();
    }
}

Console.Write("Input a number rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
*/
//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

// int[,] ArrayIJ()
// {
//     Console.Write("Input number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)    
//         for(int j = 0; j < columns; j++)
//             array[i,j] = i + j;

//     return array;
// }

// int[,] userArray = ArrayIJ();
// Show2DArray(userArray);


//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// void QuadEvenElements(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i += 2)
//         for(int j = 0; j < array.GetLength(1); j +=2)
//             array[i,j] *= array[i,j];
// }

// QuadEvenElements(userArray);

// Show2DArray(userArray);


//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int SumDiag(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(1) && i < array.GetLength(0); i++)
        sum += array[i,i];

    return sum;
}

int userSum = SumDiag(userArray);
Console.WriteLine(userSum);
*/
//