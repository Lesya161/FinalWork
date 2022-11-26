string [] CreateStringArray(int size)
{
    string [] array = new string [size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Write a {i + 1} element of your array: ");
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

Console.WriteLine("Input a size for yor array: ");
int size = Convert.ToInt32(Console.ReadLine());
string [] myArray = CreateStringArray(size);
ShowStringArray(myArray);

string [] NewStringArray(string [] array)
{
    int count = 0;
    string [] endArray = new string [array.Length];
    for(int i = 0; i < endArray.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            endArray[count] = array[i];
            count++;
        }
    }
    return endArray;
}

string [] finalArray = NewStringArray(myArray);
ShowStringArray(finalArray);