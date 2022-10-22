//task 23
bool is_parsed_number = int.TryParse(Console.ReadLine(),out int number);

if (!is_parsed_number)
    {
        Console.WriteLine("Error, type is not compilit");
        return;
    }


int [] Work (int number_2)
{
    int[] array = new int[number_2+1];
    
    for(int i=1; i <= number_2; i++)
        {
            array[i] = i*i*i;   
        }
    return array;
}

Print_array(Work(number),number);

void Print_array(int [] array_1, int number_3)
{
    Console.Write($"{number_3}-->");

    for(int i = 0;i < array_1.Length; i++) 
        {
            Console.Write($" {array_1[i]} ");
        }
}