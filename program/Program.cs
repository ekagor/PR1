string[] array1 = new string[5] {"577363", "666", "hi", "press", "min"};
string[] array2 = new string[array1.Length];
PrintInfo();
SecondArray(array1, array2);
PrintArray(array2);

void PrintInfo(){
    Console.WriteLine("Программа из имеющегося массива строк формирует массив из строк,");
    Console.WriteLine("длина которых меньше либо равна 3 символам");
}

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}