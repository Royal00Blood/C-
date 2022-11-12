Random random = new Random();
int[] numbers = new int[5];

void FillArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = random.Next(0,5);
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
int [] MulNumberArray(int[] array)
{
    int[] rez = new int[(array.Length+1)/2];
    for(int i = 0; i < rez.Length; i++)
    {
        if(i != (array.Length-i-1))
        {
           rez[i] = array[i] * array[array.Length-1-i];
        }
        else
        {
            rez[i] = array[i];
        }
    }
   return(rez);
}

FillArray(numbers);
PrintArray(numbers);
//MulNumberArray(numbers);
PrintArray(MulNumberArray(numbers));
