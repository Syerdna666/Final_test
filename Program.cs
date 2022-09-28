

string[] array = { "carpe", "diem", "et", "memento", "mori" };

System.Console.WriteLine($"[{string.Join(", ", array)}]");

string[] SetArray(string[] arr)
{
    int length = arr.Length;
    string[] result = new string[length];
    int count = 0;
    int wordLength = 3;

    for (int i = 0; i < length; i++)
    {
        if (arr[i].Length <= wordLength)
        {
            result[count] = arr[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}

string[] resArr = SetArray(array);

System.Console.WriteLine($"[{string.Join(", ", resArr)}]");