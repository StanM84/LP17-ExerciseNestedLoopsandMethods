int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

double result = CalcFack(num1, num2);

Console.WriteLine(result);


static double CalcFack(double num1, double num2)
{
    double fack1 = 1;
    double fack2 = 1;
    //double result = 0;

    for (double i = num1; i >= 1; i--)
    {
        fack1 *= i;
    }
    for (double i = num2; i >= 1; i--)
    {
        fack2 *= i;
    }

    return fack1 / fack2;
}