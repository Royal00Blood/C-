// напишите программу
int Get_random_namber(int min_value, int max_value)
    {
        Random random = new Random();
        int random_number = random.Next(min_value,max_value);
        return random_number;
    }

int Del_second_number(int number_del)
{
    int val_001 = number_del % 10;
    int val_100 = number_del / 100;
    int result = val_001 + val_100 * 10;
    return result;
}

int nambet_log = Get_random_namber(100,1000);

Console.Write(nambet_log + "--del--" + Del_second_number(nambet_log));
