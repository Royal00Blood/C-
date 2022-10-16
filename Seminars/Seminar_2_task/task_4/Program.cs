int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());

void Multiplicty_check (int number_new_1,int number_new_2)
{
    if (number_new_1 * number_new_1 == number_new_2 || number_new_1 == number_new_2 * number_new_2)
        {
            Console.WriteLine($"{number_new_1},{number_new_2} -- > yes");
        }
    else 
        {
            Console.WriteLine($"{number_new_1},{number_new_2} -- > no");
        }
}
Multiplicty_check(number_1, number_2);
