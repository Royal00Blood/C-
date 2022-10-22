bool is_parsed_x_1 = int.TryParse(Console.ReadLine(),out int x_1);
bool is_parsed_y_1 = int.TryParse(Console.ReadLine(),out int y_1);
bool is_parsed_x_2 = int.TryParse(Console.ReadLine(),out int x_2);
bool is_parsed_y_2= int.TryParse(Console.ReadLine(),out int y_2);

if (!is_parsed_x_1 || !is_parsed_x_2 || !is_parsed_y_1 || !is_parsed_y_2)
    {
        Console.WriteLine("Error, type is not compilit");
        return;
    }

double Distance(int Ax,int Ay, int Bx, int By)
    {
        double distance = Math.Sqrt(Math.Pow((Ax - Bx),2) + Math.Pow((Ay-By),2));
        return distance;
    }

Console.WriteLine($"value distance = {Distance(x_1,y_1,x_2,y_2)}");