bool is_parsed_1 = int.TryParse(Console.ReadLine(),out int a);
bool is_parsed_2 = int.TryParse(Console.ReadLine(),out int b);
if(!is_parsed_1 || !is_parsed_2)
{
    Console.WriteLine();
    return;
}

int Pow(int number_1, int number_2)
{
    int pow = 1;
    for(int i=0;i < number_2; i++)
    {
        pow *= number_1;
    }
    return pow;
}

Console.Write($"{a} ^ {b} = {Pow(a, b)} or {Math.Pow(a,b)} ");