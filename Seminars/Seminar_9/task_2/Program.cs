Console.Write("Input start number--> ");
bool isParsed_1 = int.TryParse(Console.ReadLine(),out int M);
Console.Write("Input end number--> ");
bool isParsed_2 = int.TryParse(Console.ReadLine(),out int N);
Console.WriteLine($"Numbers {M} --> {N}:");
if(!isParsed_1 || !isParsed_2)
{
    Console.WriteLine("Error");
    return;
}

if (M<N)
{
    PrintNextNumber(M, N);
}
else
{
    Console.WriteLine("Error");
}

void PrintNextNumber(int m,int n)
{
 Console.Write($"{m}");
 if(m < n)
 {
    m++;
    PrintNextNumber(m,n);
 }
}
