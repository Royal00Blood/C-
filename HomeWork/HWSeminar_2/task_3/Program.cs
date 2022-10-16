string Check_day(int day)
{
    if(day <= 7 && day > 0)
    {
        if (day < 6)
            {
                return "No, it is working day";
            } 
        else
            {
                return "Yes, it is holiday";
            }
    }
    else
        {
            return "It's not day of the week";
        }
}

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number}-->{Check_day(number)}");
