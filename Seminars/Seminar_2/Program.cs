int Get_random_namber(int min_value, int max_value)
    {
        Random random = new Random();
        int random_number = random.Next(min_value,max_value);
        return random_number;
    }

void Max_number(int number)
    {
        int max = number % 10;
        number = number/10;

        while(number > 0)
        {
            int last_number = number % 10;
            if (last_number > max)
            {
                max = last_number;
            }
            number = number / 10;
        }
        Console.Write(" Max_number = " + max + "  ");

    }

int number_find = Get_random_namber(10,100);
Console.Write(number_find);
Max_number(number_find);

