bool is_parsed = int.TryParse(Console.ReadLine(),out int a);

if(!is_parsed)
{
    Console.WriteLine();
    return;
}
if (a<1)
{
    Console.Write(0);
    return;
}

int Get_sum_numbers(int number)
{
    int sum_m = 0;

    for(int i = 0 ;i <= number;i++)
    {
        sum_m += i;
    }
    return sum_m;
}

int sum = Get_sum_numbers(a);
Console.WriteLine(sum);