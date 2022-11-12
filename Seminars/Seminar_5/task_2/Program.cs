//change element array - / +

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

void Change_element_array(int [] array)
{
    for(int i = 0;i < array.Length;i++)
    {
        array[i]=array[i]*-1;
    }
}

FillArray(numbers);
PrintArray(numbers);
Change_element_array(numbers);
PrintArray(numbers);
