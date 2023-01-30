// Поиск элементов в массиве случайных чисел
// Метод, которые ничего ен возвращает
// Метод войд, который заполняет массив случайными числами
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

// Метод войд, который будет печатает массив 
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

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;// хитрый ход для не существующей позиции
    
    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;// оператор для остановки на первом элементе
        }
        index++;
    }
    return position;
}
// Создаем массив, в котором 10 элементов
int[] array = new int[10];

FillArray(array);
array[6] = 4;// исскуственное добавление искомых элементов
PrintArray(array);
Console.WriteLine();

int pos = indexOf(array, 321);
Console.WriteLine(pos);
