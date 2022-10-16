int Second_number(int second_number_val)
{
    int result = second_number_val /10 % 10;
    return result;
}
bool Check_value(int value)
{
    if (value/100 == 0 || value / 100 > 9)
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
        Console.WriteLine($"{number} --> Error");
    }
else
    {
        Console.WriteLine($"{number} --> {Second_number(number)}"); 
    }