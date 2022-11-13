Console.Write("Input b1 = ");
bool is_parsed_1 = double.TryParse(Console.ReadLine(),out double b1);
Console.Write("Input k1 = ");
bool is_parsed_2 = double.TryParse(Console.ReadLine(),out double k1);
Console.Write("Input b2 = ");
bool is_parsed_3 = double.TryParse(Console.ReadLine(),out double b2);
Console.Write("Input k2 = ");
bool is_parsed_4 = double.TryParse(Console.ReadLine(),out double k2);
// y= k * x + b
if(!is_parsed_1 | !is_parsed_2 | !is_parsed_3 | !is_parsed_4)
{
    Console.WriteLine();
    return;
}
double[] array_out = PointOfIntersectionLines(k1,k2,b1,b2);
if (CheckSolution(k1,k2,b1,b2,array_out[0],array_out[1]))
    {
        Console.WriteLine($"Points intersection ({array_out[0]},{array_out[1]})" );
    }
else
    {
        Console.WriteLine($"No solution" );
    }
double[] PointOfIntersectionLines(double k_1, double k_2, double b_1, double b_2)
{
    double[] array = new double[2];
    double x = (b_2-b_1)/(k_1-k_2); 
    double y = k_1 * x + b_1;
    array[0] = x;
    array[1] = y;
    return array;
}
bool CheckSolution (double k_1, double k_2, double b_1, double b_2, double x, double y)
{
    if( k_1 * x + b_1 - y == 0 & k_2 * x + b_2 - y == 0 )
    {
        return true;
    }
    return false;
}

Console.WriteLine("Have a good day!!!");