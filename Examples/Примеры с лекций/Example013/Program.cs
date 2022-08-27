

using System.Diagnostics;
int[] arr = {1, 3, 5, 6, 7, 8, 2, 9, 1 , 1};

void PrintArray(int[] ar)
{
    int length = ar.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{ar[i]}     ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j; 
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
         
    }
}

void SelectionSortFromMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)                       
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j; 
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
         
    }
}

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);


