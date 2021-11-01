void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9, 9);
        index++;
    }

}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int Checkposition(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }

    return position;
}
int Checkposition1(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;


        }

        index++;
    }

    return position;
}
int difpos = 0;
int[] array = new int[30];
int NumberK(int[] collection)
{
    int size = 30;
    int index = 0;
    int count = 0;
    int k = 5;
    while (index < size)
    {
        if (collection[index] == k)
        {
            count++;

        }
        index++;
    }
    return count;
}

int Diff(int S)
{
    difpos = Checkposition1(array, 5) - Checkposition(array, 5);
    return difpos;
}


FillArray(array);
PrintArray(array);
Console.WriteLine();
int k = NumberK(array);
Console.WriteLine(k);
Console.WriteLine();
int firstpos = Checkposition(array, 5);
Console.WriteLine(firstpos);
int secondpos = Checkposition1(array, 5);
Console.WriteLine(secondpos);
Console.WriteLine();
Diff(difpos);
Console.WriteLine(difpos);

