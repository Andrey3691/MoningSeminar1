// Написать программу, определение координат
/*
int FindQuadrand (double x, double y)
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
int qadNum = FindQuadrad(xA, yA);
Console.WriteLine($"The point A {xA},{yA} is on the {qadNum} qadRand");
*/


/*
int GetCoordinates(int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x>0, y>0");
    else if(quadrant == 2) Console.WriteLine("x<0, y>0");
    else if(quadrant == 3) Console.WriteLine("x<0, y<0");
    else if(quadrant == 4) Console.WriteLine("x>0, y<0");
    else Console.WriteLine("There is on such quadrant");
}

Console.WriteLine("Input number is the quadrant: ");
int quadrantPoits = Convert.ToInt32(Console.ReadLine());

GetCoordinates(quadrantPoits);
*/

/*
void GetCoordinates(int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x>0, y>0");
    else if(quadrant == 2) Console.WriteLine("x<0, y>0");
    else if(quadrant == 3) Console.WriteLine("x<0, y<0");
    else if(quadrant == 4) Console.WriteLine("x>0, y<0");
    else Console.WriteLine("There is on such quadrant");
}
Console.WriteLine("Input number is the quadrant: ");
int quadrantPoits = Convert.ToInt32(Console.ReadLine());

GetCoordinates(quadrantPoits);
*/

/*
double Distance(double xA, double yA, double xB, double yB)
{
    double Lingh = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
    return Math.Round(Lingh, 2);
}
Console.WriteLine("Input an x-coordonate of point A: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input an y-coordonate of point A: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input an x-coordonate of point B: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input an y-coordonate of point B: ");
double yB = Convert.ToDouble(Console.ReadLine());

double distanceBetweenAB = Distance(xA, xB, yA, yB);

Console.WriteLine("Distance Between points A and B is {distanceBetweenAB}.");
*/
