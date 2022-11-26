Console.Write("Input start number--> ");
bool isParsed_1 = int.TryParse(Console.ReadLine(),out int number_in);
if(!isParsed_1)
{
    Console.WriteLine("Error");
    return;
}

Console.Write($"Sum = {SumNumber(number_in)} ");

int SumNumber(int number, int sum = 0)
{
    sum += number % 10;
    number = number/10;
    if(number > 0)
    {
     sum = SumNumber(number, sum);   
    }
     return sum;   
}
