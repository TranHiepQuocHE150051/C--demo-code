try
{
    int[] mynumbers = new int[] { 1, 2, 3 };
    int i = mynumbers[10];                 // error 
    Console.WriteLine(i);                   
}
catch (Exception ex)
{
    Console.WriteLine("Error found");
    Console.WriteLine(ex.Message);
}
// catch multiple exception

Console.WriteLine("---- Catch Multiple exceptions----");
try
{
    int a = 5;
    int b = 0;
    int c = a / b;

}
catch (DivideByZeroException e1)
{
    Console.WriteLine(e1.Message);
}
catch (Exception e2)
{
    Console.WriteLine(e2.Message);
}

// Finally block 
Console.WriteLine("---- Finally ----");

int x = 10;
int y = 0;
int z = 0;
try
{
    z = x / y;
}
catch (DivideByZeroException e1)
{
    Console.WriteLine(e1.Message);
}
finally
{
    
    Console.WriteLine(z);
}
// throw exception 
Console.WriteLine("---- Throw exception ----");

try
{
    double z1 = Divide(100, 0);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

static double Divide(double x, double y)
{
    if (y == 0)
    {
        Exception myexception = new Exception("Cannot divided by 0 ");
        throw myexception;
    }
    return x / y;
}
