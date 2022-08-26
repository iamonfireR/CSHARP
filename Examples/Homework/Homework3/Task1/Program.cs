int NumToString(int argm)
{
    if(argm < 0)  argm = argm * -1; //Если вдруг введено отрицательное число

    string NumToStr = Convert.ToString(argm); //Переводим введенное число в строку
    int length = NumToStr.Length; //Узнаем длину строки

    for (int i = 1; i <= length; i++) // Цикл
    {
        if (NumToStr[i - 1] == NumToStr[length - i])   // Пришлось написать так, ибо при 0 компилятор выдавал ошибку, что  поиск проходит за пределами заданного массива
        {
            Console.WriteLine($"{i} Элемент- {NumToStr[i - 1]}  числа {argm} равен {length - i + 1} элементу {NumToStr[length -i]}");
            if (i == length / 2) // Если количества итераций равно длине массива деленной на 2, то цикл прерывается, это сделано для
            {                                                                          //того ыто бы массив не проверялся еще раз
                Console.WriteLine($"Число {argm} является полиндромом");
                break;
            }
        }
        else
        {
            Console.WriteLine("Число не является полиндромом");
            break;
        }
    }
   
    return argm;
}

int number = Convert.ToInt32(Console.ReadLine());
NumToString(number);