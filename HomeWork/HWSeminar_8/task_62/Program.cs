/*
Напишите метод, который заполнит спирально массив 
4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Print2Darray(Print2DarraySpiral(4));
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
int [,] Print2DarraySpiral(int n)
{
    int Ni = n;
    int Nj = n;
    int j1 = 0;
    int number = 0;
    var result = new int[n, n];

        int index = 0;
        //первая срока
            for (int j = j1; j < Nj; j++)
            {
                result[index,j] = number;
                number++;
            }
        // последний столбик
            index = 3;
            j1 = 1;
             for (int j = j1; j < Nj; j++)
            {
                result[j,index] = number;
                number++;
            }
        //нижняя строка
            j1 = 2;
            Nj = 0;
             for (int j = j1; j >= Nj; j--)
            {
                result[index,j] = number;
                number++;
            }
        //первый столбик
            index = 0;
            j1 = 2;
            Nj = 1;
             for (int j = j1; j >= Nj; j--)
            {
                result[j,index] = number;
                number++;
            }
        //вторая строка
            index = 1;
            j1 = 1;
            Nj = 2;
            for (int j = j1; j <= Nj; j++)
            {
                result[index,j] = number;
                number++;
            }
        //третья строка
            index = 2;
            j1 = 2;
            Nj = 1;
            for (int j = j1; j >= Nj; j--)
            {
                result[index,j] = number;
                number++;
            }
    return result;

}