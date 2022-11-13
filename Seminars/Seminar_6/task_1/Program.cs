Console.Write("Значение первой стороны триугольника==>");
bool is_parsed_1 = int.TryParse(Console.ReadLine(),out int a);
Console.Write("Значение второй стороны триугольника==> ");
bool is_parsed_2 = int.TryParse(Console.ReadLine(),out int b);
Console.Write("Значение третьей стороны триугольника==> ");
bool is_parsed_3 = int.TryParse(Console.ReadLine(),out int c);

bool CheckingTriangle(int a,int b, int c)
{
    if( a <= 0 & b <= 0 & c <= 0)
    {
        return false;
    }
    return a < b + c & b < a + c & c < a + b;
}

Console.WriteLine(CheckingTriangle(a,b,c));