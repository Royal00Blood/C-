int[] numbers = new int[12];

Random random = new Random();

void FillArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = random.Next(-9,10);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetSumPositivNumbers(int[] numbers)
{
    int sum = 0;
    for(var i = 0; i < numbers.Length; i++)
    {
        if(numbers[i]>0)
        {
            sum += numbers[i];
        }
    }
    return sum;
}

int GetSumNegativNumbers(int[] numbers)
{
    int sum = 0;
    for(var i = 0; i < numbers.Length; i++)
    {
        if(numbers[i]<0)
        {
            sum += numbers[i];
        }
    }
    return sum;

}

(int,int) GetSumNegativNumbers_and_GetSumPositivNumbers(int[] numbers)
{
    int sum_negative = 0;
    int sum_positive = 0;
    for(var i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] < 0)
        {
            sum_negative += numbers[i];
        }
    }
     for(var i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > 0)
        {
            sum_positive  += numbers[i];
        }
    }

    return(sum_negative,sum_positive);
}



FillArray(numbers);
PrintArray(numbers);
int sumPositiv = GetSumPositivNumbers(numbers);
Console.WriteLine($"{sumPositiv}");
int sumNegativ = GetSumNegativNumbers(numbers);
Console.WriteLine($"sum negativ = {sumNegativ}");

(int, int) sum = GetSumNegativNumbers_and_GetSumPositivNumbers(numbers);
Console.WriteLine($"{sum.Item1},{sum.Item2}");