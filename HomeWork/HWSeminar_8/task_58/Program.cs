//Задайте две матрицы. 
//Напишите метод, 
//который будет находить произведение двух матриц.
Console.Write("Input m_1--> ");
bool isParsed_1 = int.TryParse(Console.ReadLine(),out int m_1);
Console.Write("Input n_1--> ");
bool isParsed_2 = int.TryParse(Console.ReadLine(),out int n_1);
Console.Write("Input m_2--> ");
bool isParsed_3 = int.TryParse(Console.ReadLine(),out int m_2);
Console.Write("Input n_2--> ");
bool isParsed_4 = int.TryParse(Console.ReadLine(),out int n_2);
if(!isParsed_1 || !isParsed_2 || !isParsed_3 || !isParsed_4)
{
    Console.WriteLine("Error");
    return;
}
if (n_1 == m_2)
{
    Console.WriteLine($"Array {m_1} x {n_1}:");
    int [,] matrix_1 = CreateRandom2DArray(m_1,n_1);
    Print2Darray(matrix_1);
    Console.WriteLine();
    Console.WriteLine($"Array {m_2} x {n_2}:");
    int [,] matrix_2 = CreateRandom2DArray(n_2,m_2);
    Print2Darray(matrix_2);
    Console.WriteLine();
    Print2Darray(MultiplicationMatrixs(matrix_1,matrix_2));
}
else
{
    Console.WriteLine("Matrixs can't be multiplication");
}

int[,] CreateRandom2DArray(int num_m, int num_n)
{
    int[,] array = new int [num_m, num_n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1,10);
        }
    }
    return array;
}
void Print2Darray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] MultiplicationMatrixs(int [,] array_1, int[,]array_2)
{
    int [,] new_matrix = new int [array_1.GetLength(1),array_2.GetLength(0)];
    for (int k = 0; k < array_1.GetLength(0); k++)
    {
        for (int i = 0; i < array_1.GetLength(1); i++)
        {
            for (int j = 0; j < array_2.GetLength(0); j++)
            {
            new_matrix[k,i] += array_1[k,j] * array_2[j,i]; 
            }
        }
    }
    return new_matrix;
}

