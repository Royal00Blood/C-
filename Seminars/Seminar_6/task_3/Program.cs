Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
PrintArray(Fibonachi(number));

double[] Fibonachi(int n)
{
    double[] array = new double[n];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.WriteLine();
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}