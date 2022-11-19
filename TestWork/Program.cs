// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string[] CreateArray()
{
    Console.WriteLine("Введите эллементы массива через пробел:");
    string[] array = Console.ReadLine().Split(" ");
    return array;
}