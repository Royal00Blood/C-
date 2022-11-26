// Console.Write("Input number_1--> ");
// bool isParsed_1 = int.TryParse(Console.ReadLine(),out int number_1);
// Console.Write("Input number_2--> ");
// bool isParsed_2 = int.TryParse(Console.ReadLine(),out int number_2);
// Console.Write($"{number_1} ^ ({number_2}) = ");
// if(!isParsed_1 || !isParsed_2)
// {
//     Console.WriteLine("Error");
//     return;
// }
// if(number_2 != 0)
// {
//   Console.WriteLine($"{NumberGoUp(number_1,number_2)}");  
// }
// else
// {
//     Console.WriteLine($"{1}"); 
// }


// double NumberGoUp(int number,int number_up)
// {   
//     if (number_up > 1)
//     {
//         number_up--;
//         number = number * NumberGoUp(number,number_up); 
//     }
//     if(number_up < 1)
//     {
//         number_up++;
//         number = 1/number * NumberGoUp(number,number_up); 
//     }
//     return number;
// }

int A = Convert.ToInt32(Console.ReadLine()); 
int B = Convert.ToInt32(Console.ReadLine()); 
int exp = Exponentiate(A, B); 
Console.WriteLine(exp); 
int Exponentiate(int A, int B) 
{ 
    int exp = 1; 
    if (B != 0) 
    { 
        exp *= A; 
        B--; 
        exp *= Exponentiate(A,B); 
    } 
    return exp; 
} 