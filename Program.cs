string [] CreateStringArray(int size)
{
    string [] array = new string [size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Write a {i + 1} element of your array: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void ShowStringArray(string [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}