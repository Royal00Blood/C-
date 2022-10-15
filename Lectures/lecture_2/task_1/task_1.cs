int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}

// array
int[] number = {15,21,39,12,23,33,13,23,33};

int max = number[0];
//variant_1
if (max < number[1]) max = number[1];
if (max < number[2]) max = number[2];
if (max < number[3]) max = number[3];
if (max < number[4]) max = number[4];
if (max < number[5]) max = number[5];
if (max < number[6]) max = number[6];
if (max < number[7]) max = number[7];
if (max < number[8]) max = number[8];
//variant_2
int max_1 = Max(number[0],number[1],number[2]);
int max_2 = Max(number[3],number[4],number[5]);
int max_3 = Max(number[6],number[7],number[8]);
int max_new = Max(max_1,max_2,max_3);
//vaiant_3
int max_new_2 = Max(
    Max(number[0],number[1],number[2]),
    Max(number[3],number[4],number[5]),
    Max(number[6],number[7],number[8]));

Console.Write( max_new);