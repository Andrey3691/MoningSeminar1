// Семинар Крок 6
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
         array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray( int[] array)
{
    for( int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
}

// Задача1: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
void ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/

// Задача2: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины
/*
bool Triangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}
Console.Write("Input a length a: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a length b: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a length c: ");
int sideC = Convert.ToInt32(Console.ReadLine());
bool result = Triangle(sideA, sideB, sideC);
Console.WriteLine(result);
*/

// Задача3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] Fib(int size, int a, int b)
{
    int [] newArray = new int[size];
    newArray[0] = a;
    newArray[1] = b;
    for(int i = 2; i < size; i++)
    {
        newArray[i] = newArray[i - 1] + newArray[i - 2];
    }
    return newArray;
}
Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int[] fib = Fib(size, num1, num2);
ShowArray(fib);
*/
// Задача1: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
int[] Copy(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
        newArray[i] = array[i];
    return newArray;
}
Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int[] copyArray = Copy(myArray);
ShowArray(copyArray);
myArray[myArray.Length - 1] +=10;
ShowArray(myArray);
*/