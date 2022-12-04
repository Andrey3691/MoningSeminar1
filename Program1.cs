/*
int CutNumber(int num)
{
    int ed = num % 10;
    int sot = num / 100;

    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random().Next(100, 1000);
int newNum = CutNumber(randNum);

Console.WriteLine($"New version of a nuber {randNum} is {newNum}");
*/

// Случайное число из отрезка от 10 до 99 и показывает наибольшую цифру числа.
/*
int Rand(int num)
{
    int ed = num % 10;
    int nextN = num / 10;
    int max = ed;
    if (max < nextN) max = nextN;
    return max;
}
int randNum = new Random().Next(10,100);
int newNum = Rand(randNum);
    Console.WriteLine($"Random Number: {randNum} is nixt number: {newNum}");
*/

// Напишите программу которая на входе принимает число и проверяет, кратно ли оно одновременно a и b.

Console.WriteLine(("Запросить число"));
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(("Кратно первому"));
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(("Кратно второму"));
int b = Convert.ToInt32(Console.ReadLine());

void Rand(int num, int a, int b)
{
    if(num % a ==0 && num % b ==0)
    {
        Console.WriteLine("Число равно двум");
    }
    else
    {
        Console.WriteLine("Не кратно");
    }

}
Rand(num, a, b);
