//распечатать массив на консоль 
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}


string[] array = {"one", "two", "three", "four", "five", "six", "seven", "-1"};

int resultArraySize = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) 
        resultArraySize++;
}

string[] resultArray =  new string[resultArraySize];

int j = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) 
    {
        resultArray[j] = array[i];
        j++;
    }
}

Console.WriteLine("Исходный массив:");
PrintArray(array);

Console.WriteLine("Массив, состоящий из элементов исходного, длина которых <= 3:");
PrintArray(resultArray);