string Input = Console.ReadLine();
bool is_parsed_1 = int.TryParse(Input,out int a);
if(!is_parsed_1)
{
    Console.WriteLine();
    return;
}

int Sun_number(int number,string col)
{
    int sum = 0;
    for(int i = 0; i< col.Length; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

Console.Write($"sum = {Sun_number(a,Input)}");
