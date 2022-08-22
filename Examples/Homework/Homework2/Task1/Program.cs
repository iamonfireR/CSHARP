using System.Linq.Expressions;

int GenerateNumber(int generatedNum = 0)   // Функция генерирующая трехзначное число
{
    generatedNum = new Random().Next(100, 999);
    Console.WriteLine("Генерирую трехзначное число...");
    Console.WriteLine(generatedNum);
    return generatedNum;
}

int SecondDigitOfGenNum(int secondDig) // Функция находящая вторую цифру числа.
{
    Console.WriteLine("Ищем вторую цифру сгенерированного трехзначного числа, она равна...");
    secondDig = (secondDig / 10) % 10;
    Console.WriteLine(secondDig);
    return secondDig;
   
}

int number = GenerateNumber();
int result = SecondDigitOfGenNum(number);



