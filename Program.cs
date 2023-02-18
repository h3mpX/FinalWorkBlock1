string[] ShowCutArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int size = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            newArray[size] = array[i];
            size++;
        }
    Array.Resize(ref newArray, size);
    return newArray;
}

void ShowArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
Console.Write(array[i] + " ");
Console.WriteLine();
}

string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2" };
string[] newArray = (ShowCutArray(array));
ShowArray(newArray);