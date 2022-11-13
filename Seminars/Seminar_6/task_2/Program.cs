string result = ConvertDecToBinary(4); //вызвали метод
Console.WriteLine(result); //вывели на экран

string ConvertDecToBinary(int number) //объявили метод
{
    string tmp = "";
    while (number > 0)
    {
        int remainder = number % 2;
        number /= 2;
        tmp = remainder.ToString() + tmp;   
    }
    return tmp; //вернули результат
}

