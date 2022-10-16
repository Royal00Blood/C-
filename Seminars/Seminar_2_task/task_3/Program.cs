int number = Convert.ToInt32(Console.ReadLine());


void Multiplicty_check (int number_new)
{
    if ((number_new % 7 == 0) & (number_new % 23 == 0))
        {
            Console.WriteLine($"{number_new}-->yes");
        }
    else
        {
            Console.WriteLine($"{number_new} --> no");
        }
}
Multiplicty_check(number);
