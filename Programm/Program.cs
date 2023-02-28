string[] originalArray = new string[] {"hello", "2", "world", ":-)"};
string[] resultArray = new string[originalArray.Length];
int sizeString = 3;

TransformationArray(originalArray, resultArray, sizeString);
PrintArray(resultArray);

void TransformationArray(string[] arr1, string[] arr2, int size)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if(arr1[i].Length <= size)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
