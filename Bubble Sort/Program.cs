// See https://aka.ms/new-console-template for more information



int[] array = { 64, 34, 25, 12, 22, 11, 90 };
int n = array.Length;
for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
}
