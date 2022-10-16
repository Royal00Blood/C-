int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());

void Multiplicty_check (int number_new_1,int number_new_2)
{
    if ((number_new_1 % number_new_2) == 0)
        {
            Console.WriteLine("multiple");
        }
    else
        {
            Console.WriteLine($"not a multiple, {number_new_1 % number_new_2}");
        }
}
Multiplicty_check(number_1, number_2);
