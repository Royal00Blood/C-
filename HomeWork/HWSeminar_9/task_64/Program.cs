Console.Write("Input n--> ");
bool isParsed_2 = int.TryParse(Console.ReadLine(),out int N);
Console.WriteLine($"Count number{N}:");
if( !isParsed_2)
{
    Console.WriteLine("Error");
    return;
}

PrintNextNumber(N);

void PrintNextNumber(int n ,int m = 1)
{
    Console.Write($"{n} ");
    if(m < n)
    {
        n--;
        PrintNextNumber(n,m);
    }
}
