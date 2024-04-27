string[] CreateArray()
{
    Console.Write("Введите количество элементов массива: ");
    int initArrayLength = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите последовательно элементы массива в виде строк: ");

    string[] array = new string[initArrayLength];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }

    return array;
}

string[] ReduceCopyArray(string[] array, int numMaxStringLetters)
{
    int numShortElm = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numMaxStringLetters)
        {
            numShortElm ++;
        }
    }

    if (numShortElm == 0)
    {
        string[] ResultArrayNull = new string[1];
        return ResultArrayNull;
    }

    string[] ResultArray = new string[numShortElm];
    int resArrayIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numMaxStringLetters)
        {
            ResultArray[resArrayIndex] = array[i];
            resArrayIndex ++;
        }
    }

    return ResultArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

string[] InitArray = CreateArray();
PrintArray(InitArray);
string[] ResArray = ReduceCopyArray(InitArray, 3);
PrintArray(ResArray);