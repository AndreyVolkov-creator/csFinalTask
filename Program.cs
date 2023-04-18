// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] firstArray = new string[4];
string[] secondArray = new string[firstArray.Length];
Console.WriteLine("Вам необходимо ввести 4 разных значение (текстовые/числовые)");
Console.WriteLine("Введите первое значение");
firstArray[0] = Console.ReadLine()!;
Console.WriteLine("Введите второе значение");
firstArray[1] = Console.ReadLine()!;
Console.WriteLine("Введите третье значение");
firstArray[2] = Console.ReadLine()!;
Console.WriteLine("Введите четвертое значение");
firstArray[3] = Console.ReadLine()!;

PrintArray(firstArray);
FillArray(firstArray, secondArray);
PrintArray(secondArray);




void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

void FillArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
