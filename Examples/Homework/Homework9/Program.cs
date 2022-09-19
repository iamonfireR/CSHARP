// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

for (int i = n; i <= m; i++)
{
    Console.Write(n++ + " ");
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int cnt = y - x;
int summ = x;

for (int i = 1; i <= cnt; i++)
{
    x = x + 1;
    summ += x;
}
Console.WriteLine(summ);




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29


int firstNumber  = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

AkkerCalc(firstNumber,secondNumber);

void AkkerCalc(int m, int n)
{
    Console.Write(Akk(m, n)); 
}

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return (Akk(m - 1, Akk(m, n - 1)));
    }
}