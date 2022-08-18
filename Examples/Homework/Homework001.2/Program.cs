int[] numbers = {2, 3, 7};
int result = numbers[0];

for (int i = 0; i < numbers.Length; i++) 
{
    if (result < numbers[i]) 
    {
        result = numbers[i];
    }
    i++;
}

Console.WriteLine(result);

// ЗАДАЧА 2 //

int[] numbers1 = {44, 5, 78};
int result1 = numbers1[0];

for (int i = 0; i < numbers.Length; i++) 
{
    if (result < numbers[i]) 
    {
        result = numbers[i];
    }
    i++;
}

Console.WriteLine(result1);

// ЗАДАЧА 3 //

int[] numbers2 = {22, 3, 9};
int result2 = numbers2[0];

for (int i = 0; i < numbers.Length; i++) 
{
    if (result < numbers[i]) 
    {
        result = numbers[i];
    }
    i++;
}

Console.WriteLine(result2);
