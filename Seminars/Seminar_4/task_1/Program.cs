bool is_parsed = int.TryParse(Console.ReadLine(),out int a);
if(!is_parsed)
{
    Console.WriteLine();
    return;
}

int Count_number(int number)
{
   int count = 0;
   while(number > 0)
   {
    number/=10;
    count += 1;
   }
   return count;
}

int rez = Count_number(a);

Console.Write($"colichestvo = {rez}");
