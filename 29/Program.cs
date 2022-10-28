Console.Clear();
Console.WriteLine("  Введите элементы массива");
int[] a = FillArray();
PrintArray(a);

void PrintArray(int[] mass )
{
    int line = mass.Length;
    int count = 0;
    Console.WriteLine( " Элементы массива: ");
    while(count < line)
    {
       Console.Write($"{mass[count]} ");
       count++; 
    }
}

int[] FillArray()
{
    Console.WriteLine(" Введите колличество элементов массива:");
    int Length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[Length];
    int index = 0;
    while (index < Length)
    {
        array[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
   return array; 
}






