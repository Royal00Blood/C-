using System;

int [] Enter_array()
{
    //Random rand = new Random();
    int [] array = new int [8];
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Enter number array[{i}]->");
        bool is_parsed = int.TryParse(Console.ReadLine(),out int a);
        if(!is_parsed)
        {
            Console.WriteLine("Error, You mast enter only numbers");
            System.Environment.Exit(0);
        } 
        array[i] = a;
    }
    return array;
}


void OutPut(int [] array_1)
{
    Console.Write("array = {");
   for(int i = 0; i < array_1.Length; i++)
    {
        
        Console.Write($" {array_1[i]} ");
        
    }
    Console.Write("} "); 
}

OutPut(Enter_array());
