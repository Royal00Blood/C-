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

FillArray(numbers);
PrintArray(numbers);
bool is_parsed = int.TryParse(Console.ReadLine(),out int number_find);
//var result = Array.FindLast(numbers,element => element.Contains(number_find));

//Console.WriteLine(result);

bool Contains(int[] array, int number)
{
    for(int i = 0;i < array.Length; i++)
        {
            if(array[i] == number)
            {
                return true;
            }
        }
    return false;
}

FillArray(numbers);
PrintArray(numbers);
bool rezult_find = Contains(numbers,number_find);
if (rezult_find == true)
{
    Console.WriteLine("Nuber in contain");
}
else
{
    Console.WriteLine("Nuber not in contain");
}