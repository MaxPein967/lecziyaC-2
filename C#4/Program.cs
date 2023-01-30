// Поиск элемента в заданном массиве 
//               0  1   2   3    4   5  6   7  8  
int[] array = { 7, 16, 38, 41, 76, 69, 7, 89, 76 };

int n = array.Length;
int find = 76;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1
    index++;
}