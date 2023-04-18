// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = new string[3];
Console.WriteLine("Вам необходимо ввести 3 разных значение (текстовые/числовые)");
Console.WriteLine("Введите первое значение");
array[0] = Console.ReadLine()!;
Console.WriteLine("Введите второе значение");
array[1] = Console.ReadLine()!;
Console.WriteLine("Введите третье значение");
array[2] = Console.ReadLine()!;

PrintArray(array);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}
