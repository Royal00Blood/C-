bool is_parsed = int.TryParse(Console.ReadLine(),out int a);
if(!is_parsed)
{
    Console.WriteLine();
    return;
}

int Mul(int number)
{
    int Mul_number = 1;
    for(int i = 1; i <= number;i++)
    {
        Mul_number *= i;
    }
    return Mul_number;
}

Console.Write($"Mul = {Mul(a)} ");