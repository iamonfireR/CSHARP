int GenerateNumber(int generatedNum = 0)   // Функция генерирующая число
{
    generatedNum = new Random().Next(10, 999999); // здесь можно поставить двухзначное число и проверить, попадает ли оно в первое условие второй функции
    Console.WriteLine("Генерирую число...");
    Console.WriteLine(generatedNum);
    return generatedNum;
}

int findThirdDigit(int thirdDigit = 0)
{
    string digitToString = thirdDigit.ToString(); // Переводим число в строку
    if (digitToString.Length < 3) // Если короче 3 символов, то число нам не подходит
    {
        Console.WriteLine("Слишком короткое число... Попробуйте снова...");
    }
    else // В других вариантах, а именно от 3 символов, будет выведен 3 символ строки (у него индекс 2, потмоу что индексирование начинается с 0)
    {
        char thirdDigitIs = digitToString[2]; 
        Console.WriteLine(thirdDigitIs);
    }
    return thirdDigit;
}


int number = GenerateNumber();
int result = findThirdDigit(number);
