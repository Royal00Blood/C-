void FillArray(int[]collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index<lenght)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write(col[position]);
        position++;
    }
}

int IndexOf(int[]collection,int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            //break;   // для получения первой позиии при наличии нескольких 4 в массиве
        }
        index++;
    }

    return position;
}

int[] array = new int [10];

FillArray(array);
PrintArray(array);

int pos = IndexOf(array,4);
Console.WriteLine("");
Console.WriteLine(pos);