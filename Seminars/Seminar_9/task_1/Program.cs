Console.Write("Input n--> ");
bool isParsed_2 = int.TryParse(Console.ReadLine(),out int N);
Console.WriteLine($"Count number{N}:");
if( !isParsed_2)
{
    Console.WriteLine("Error");
    return;
}

int number = 1;
PrintNextNumber(number, N);

void PrintNextNumber(int m,int n)
{
Console.Write($"{number} ");
    if(number < n)
    {
        number++;
        PrintNextNumber(number,n);
    }
}