int[] array = {1, 5, 6, 9, 7, 8, 15, 69, 48, 58 };
int n = array.Length;
int find = 58;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index ++;
}
