int[] array = {1,2,3,4,5,6,7,8,9};

/*int Max(int elem_1, int elem_2, int elem_3)
{
    int max = elem_1;
    if (max < elem_2) max = elem_2;
    if (max < elem_3) max = elem_3;
    return max;
}
*/
int max = array[0];
for (int i = 0; i <= 8; i++)
{
    if (max < array[i]) max = array[i];
}
Console.WriteLine(max);