// Написать программу, определение координат

int FindQadrand (double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}
Console.Write("Input an x-coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an y-coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());
int qadNum = FindQadra(xA, yA);
Console.WriteLine($"The point A {xA},{yA} is on the {qadNum} qadRand");

