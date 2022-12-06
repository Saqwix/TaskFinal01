using static System.Console;
Clear();

string[] array1 = {"hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};
string[][] matrix = new string[][] {array1, array2, array3};

for (int i = 0; i < matrix.Length; i++)
{
    Write("[");
    PrintArray(matrix[i]);
    Write("]");

    Write(" -> ");

    Write("[");
    int length_array = GetLengthArray(GetArrayLimitLength(matrix[i]));
    PrintArray(GetResArray(GetArrayLimitLength(matrix[i]), length_array));
    WriteLine("]");
}


string[] GetArrayLimitLength(string[] arr)
{
    string[] result = new string[arr.Length];
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            {
                result[k] = arr[i];
                k++;
            }
    }
    return result;
}


int GetLengthArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != null) count++;
    }
    return count;
}


string[] GetResArray(string[] arr, int length)
{
    string[] result = new string[length];
    for (int i = 0; i < length; i++) 
    {
        result[i] = arr[i];
    }
    return result;
}


void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]}");
        if (i != arr.Length - 1) Write(", ");
    }
}