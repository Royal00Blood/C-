Console.Write("Input number_1--> ");
bool isParsed_1 = int.TryParse(Console.ReadLine(),out int number_1);
Console.Write("Input number_2--> ");
bool isParsed_2 = int.TryParse(Console.ReadLine(),out int number_2);
Console.Write($"{number_1} ^ ({number_2}) = ");
if(!isParsed_1 || !isParsed_2)
{
    Console.WriteLine("Error");
    return;
}

Console.WriteLine($" {FunctionAkkerman(number_1,number_2)} ");

int FunctionAkkerman(int m,int n)
{
    if (m==0)
    {
        return  n+1;
    }
    else
    {
        if (n == 0)
            {
                return FunctionAkkerman(m-1,1);
            }
            else
            {
                return  FunctionAkkerman(m-1,FunctionAkkerman(m,n-1));
            }
    }
}
