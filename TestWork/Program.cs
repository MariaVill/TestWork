// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] firstMassiv = CreateArray();
Console.WriteLine("Из имеющегося массива:");
PrintArray(firstMassiv);
Console.WriteLine();
Console.WriteLine("Представим массив, в котoром " +
                  "длинна эллементов меньше или равна 3:");
NewArray(firstMassiv);

string[] CreateArray()
{
    Console.WriteLine("Введите эллементы массива через пробел:");
    string[] array = Console.ReadLine().Split(" ");
    return array;
}

string[] PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    return array;
}

void NewArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int size = 3;
        if (array[i].Length <= size)
        {
            Console.Write(array[i] + "\t");
        }
    }
}
