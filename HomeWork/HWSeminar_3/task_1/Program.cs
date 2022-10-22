//bool is_parsed_number= int.TryParse(Console.ReadLine(),out int number);

int [] Read_console()
{
    
    Console.Write("Input number:");
    string a = Console.ReadLine();
    int [] array_m = new int [a.Length];
    for(int i = 0;i < a.Length;i++)
        {
            array_m[i] = Convert.ToInt32(a[i]);
        }
    return array_m;
}
string Polindrom_check(int[] array_m2)
{
  for(int i = 0; i <= array_m2.Length/2; i++)
    {
        if (array_m2[i] == array_m2[array_m2.Length-i-1])
        {
            continue;
        }
        else
        {
            return "No.It is not polindrom";
        }
    } 
    return "Yes. It is polindrom"; 
}

Console.Write(Polindrom_check(Read_console()));








