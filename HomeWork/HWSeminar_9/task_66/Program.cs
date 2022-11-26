Console.Write("Input number_1--> ");
bool isParsed_1 = int.TryParse(Console.ReadLine(),out int number_1);
Console.Write("Input number_2--> ");
bool isParsed_2 = int.TryParse(Console.ReadLine(),out int number_2);
Console.Write($"{number_1} --> ({number_2}) = ");
if(!isParsed_1 || !isParsed_2)
{
    Console.WriteLine("Error");
    return;
}
if (number_1 <= number_2)
{
    Console.WriteLine($"{SumElementInRange(number_1,number_2)} ");
}
else
{
    Console.WriteLine($"{SumElementInRange(number_2,number_1)} ");
}


int SumElementInRange(int a,int b, int sum = 0)
{   
    if (a <= b)
    { 
        sum += (a + SumElementInRange(a+1,b,sum));
    }
    return sum;
}
