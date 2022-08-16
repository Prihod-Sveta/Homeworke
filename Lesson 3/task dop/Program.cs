// Доп. задача
// Написать программу для разворота массива
void PrintArray(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(arr[index] + " ");
        index++;
    }
}
int[] arr = { 48, 75, 13, 94, 50, 14 };
int N = arr.Length;
PrintArray(arr);
Console.WriteLine();
// var str = string.Join(" ", arr);
// Console.WriteLine(str);

for (int i = 0; i < N / 2; i++)
{
    int temp = arr[i];
    arr[i] = arr[N - i - 1];
    arr[N - i - 1] = temp;
}

PrintArray(arr);
