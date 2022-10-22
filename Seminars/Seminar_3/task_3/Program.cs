bool is_parsed_number = int.TryParse(Console.ReadLine(),out int number);

if (!is_parsed_number)
    {
        Console.WriteLine("Error, type is not compilit");
        return;
    }


void Work (int number_2)
{
    int[] array = new int[number_2+1];
    Console.Write($"{number_2}-->");
    for(int i=1; i <= number_2; i++)
        {
            array[i] = i * i;   
            Console.Write($" {array[i]} ");
        }
}

Work(number);