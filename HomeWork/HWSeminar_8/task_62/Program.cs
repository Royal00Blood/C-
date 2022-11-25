/*
Напишите метод, который заполнит спирально массив 
4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
void Print2DarraySpiral(int [,] array)
{
    int Ni = 4;
    int Nj = 4;
    int i1 = 0;
    int j1 = 0;
    int number = 0;
    for (int i = i1; i < Ni; i++)
    {
        for (int j = j1 ; j < Nj; j++)
        {
            array[j,i] = number + 1;
        }
        j1++;
    }
    for (int i = 0; i < Ni; i++)
    {
        for (int j = 0; j < Nj; j++)
        {
            array[j,i] = number + 1;
        }
    }
}