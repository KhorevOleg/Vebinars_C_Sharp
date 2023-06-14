int[] array = { 13, 22, 48, 4, 55, 61, 17, 48, 19 };

int n = array.Length;
int find = 48;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}