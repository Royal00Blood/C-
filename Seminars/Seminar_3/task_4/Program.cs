//int x = Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());
bool is_parsed_x1 = int.TryParse(Console.ReadLine(),out int x);
bool is_parsed_y1 = int.TryParse(Console.ReadLine(),out int y);

if (!is_parsed_x1 || !is_parsed_y1)
    {
        Console.WriteLine("Error, type is not compilit");
        return;
    }
//Console.WriteLine($"{number_new} --> no");
bool namber_check(int X, int Y)
{
    if (X != 0 && Y != 0)
        {
            return true;
        }
    else
        {
            return false;
        }
}

int Identifity_quater(int X_n, int Y_n)
{
    if (namber_check(X_n, Y_n) != false)
        {
            if (X_n > 0)
                {
                    if(Y_n > 0)
                        {
                            return 1;
                        }
                    else
                        {
                            return 4;
                        }
                }
            else
                {
                      if(Y_n > 0)
                        {
                            return 2;
                        }
                    else
                        {
                            return 3;
                        }
                }
        }
    else
        {
            return 0;
        }
}

void Print_work(int X_check,int Y_check)
{
    if (Identifity_quater(X_check,Y_check) != 0)
        {
            Console.WriteLine($"The quater name is-> {Identifity_quater(X_check,Y_check)}");
        }
    else
        {
            Console.WriteLine("Error, number out of range ");
        } 
}

Print_work(x, y);