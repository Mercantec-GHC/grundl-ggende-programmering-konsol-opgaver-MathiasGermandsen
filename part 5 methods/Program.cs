// SayHello();
// void SayHello()
// {
//     Console.WriteLine("Hello");
// }

int[] a = { 1, 2, 3, 4, 5 };

Console.WriteLine("contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.WriteLine($"  {x}");
    }
    Console.WriteLine();
}


Console.ReadLine();