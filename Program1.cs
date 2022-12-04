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

int GutNumber(int num)
{
    int ed = num % 10;
    int des = num / 10;

    int result = des >= ed
}