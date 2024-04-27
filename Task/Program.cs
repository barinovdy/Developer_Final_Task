string[] CreateArray(int initArrayLength)
{
    string[] array = new string[initArrayLength];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }

    return array;
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


string[] InitArray = CreateArray(5);
PrintArray(InitArray);