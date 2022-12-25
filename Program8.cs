// Семинар Урок 9
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int num)
{
    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}
ShowNums(5);
*/
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int GetSumOfDigist(int num)
{
    if(num != 0) return GetSumOfDigist(num / 10) + num % 10;
    else return 0;
}
Console.Write(GetSumOfDigist(417));
*/
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShoyDiff(int numA, int numB)
{
    if(numA < numB) 
    {  
        ShoyDiff(numA, numB - 1);
        Console.Write( numB + " ");
    }
    if(numA > numB)
    { 
        Console.Write(numA + " ");
        ShoyDiff(numA - 1, numB);
    }
    if(numA == numB) Console.Write(numA + " ");
}
Console.Write("Input a number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N: ");
int numN = Convert.ToInt32(Console.ReadLine());
ShoyDiff(numM, numN);
*/
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/*
double Degree(int basic, int degree)
{
    if(degree > 0) return Degree(basic, degree - 1) * basic;
    else if(degree < 0) return Degree(basic, degree + 1) / basic;
    else return 1;
}
Console.WriteLine("Input a basic number");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a degree number");
int numB = Convert.ToInt32(Console.ReadLine());
double der = Degree(numA, numB);
Console.WriteLine($"{numA} raised to the power of {numB} is equal to {der}");
*/