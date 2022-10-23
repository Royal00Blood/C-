int [] Array_complit()
{
    Random rand = new Random();
    int [] array = new int [8];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(2);
    }
    return array;
}


void OutPut(int [] array_1)
{
   for(int i = 0; i < array_1.Length; i++)
    {
        Console.Write($"array = {array_1[i]} ");
    } 
}

OutPut(Array_complit());