
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

string baseNumber = Console.ReadLine();

int length = baseNumber.Length;
int temp = 0;
for (int i = 0; i < length; i++)
{
    string s = char.ToString(baseNumber[i]);
    int x = int.Parse(s);
    temp += x;
}

int result = temp;

Console.WriteLine(result);

// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] NumberInput(string s)
//         {
//             s = Console.ReadLine();
//             Console.WriteLine(s);
//             return s;
//         }       
    

//         void DigitsSumm(string num)
//         {
//             Console.WriteLine(num);
//             int length = num.Length;
//             int temp = 0;
//             for (int i = 0; i < length; i++)
//             {
//                 string s = char.ToString(num[i]);
//                 int x = int.Parse(s);
//                 temp += x;
//             }

//             int result = temp;
//             Console.WriteLine(result);
//         }

//         string baseNumber = new string(baseNumber = string.Empty);

        
//         string[] baseNumber = new string[10];
//         NumberInput(baseNumber);
//         //DigitsSumm(baseNumber);
//     }
// }