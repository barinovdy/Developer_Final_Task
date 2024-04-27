string[] CreateArray(int initArrayLength)
{
    string[] array = new string[initArrayLength];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }

    return array;
}




string[] InitArray = CreateArray(5);