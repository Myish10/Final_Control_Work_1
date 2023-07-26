int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string InputItem(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

string[] CreateArray(int num)
{
    return new string[num];
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputItem($"Введите {i + 1}-й элемент массива: ");
    }
}

string[] CreateNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return new string[count];
}

void FillNewArray(string[] array, string[] newArray)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3) continue;
        else newArray[j] = array[i];
        j++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
}

int number = InputNum("Введите количество элементов массива: ");
string[] myArray = CreateArray(number);
FillArray(myArray);
Console.WriteLine();
PrintArray(myArray);
Console.WriteLine();
string[] myNewArray = CreateNewArray(myArray);
FillNewArray(myArray, myNewArray);
PrintArray(myNewArray);