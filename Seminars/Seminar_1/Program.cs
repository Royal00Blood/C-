/*
//Task_1
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());
if (number_1==number_2*number_2)
{
    Console.WriteLine("YES");
}
else 
{
    Console.WriteLine("No");
}
*/
/*
//Task_2
int number_day = Convert.ToInt32(Console.ReadLine());

switch (number_day)
    {
        case 1: 
            Console.WriteLine("понедельник");
            break;
        case 2: 
            Console.WriteLine("вторник");
            break;
        case 3: 
            Console.WriteLine("среда");
            break;
        case 4: 
            Console.WriteLine("четверг");
            break;
        case 5: 
            Console.WriteLine("пятница");
            break;
        case 6: 
            Console.WriteLine("суббота");
            break;
        case 7: 
            Console.WriteLine("воскресение");
            break;
        default:
            Console.WriteLine("не день недели");
            break;

    }
    */
    /*
    //Task_3
    int number_R = Convert.ToInt32(Console.ReadLine());

    for(int i = -number_R;i<number_R+1;i++)
    {
        Console.WriteLine(i);
    }
*/

//Task_4
string number_str = Console.ReadLine();

Console.WriteLine(number_str[2]);
Console.WriteLine(number_str[number_str.Length-1]);
Console.WriteLine(Convert.ToInt32(number_str)%10);