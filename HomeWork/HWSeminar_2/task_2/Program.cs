int Number_third(int second_number_val)
{
    int result = second_number_val /100 % 100;
    return result;
}

bool Check_value(int value)
{
    if (value / 100 == 0)
        {
           return false;
        } 
    else
        {
            return true;
        }
}

int number = Convert.ToInt32(Console.ReadLine());

if (Check_value(number) == false)
    {
        Console.WriteLine($"{number} --> no third digit");
    }
else
    {
        Console.WriteLine($"{number} --> {Number_third(number)}"); 
    }