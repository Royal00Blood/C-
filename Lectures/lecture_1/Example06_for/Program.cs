int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max=");
Console.WriteLine(max);

for (int i = 0; i < 50; i++)
{

}

while(a<10)
{
    a = 100;
}

Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");

int xa = 40, ya = 1, 
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int x = xa, y = ya;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0,3);
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count += 1;
}