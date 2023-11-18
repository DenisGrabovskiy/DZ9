 
int ReadInt(string msg)
{
    Console.WriteLine(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintNumbers(int n)
{
    if (n<=1)
    {
        Console.Write($"{n}\t");
        return;
    }
    Console.Write($"{n}\t");
    PrintNumbers(n-1);
}

int n=ReadInt("Введите натуральное число: ");
while (n<1)
{
    Console.Write("Число не натуральное. ");
    n=ReadInt("Введите натуральное число: ");
}
PrintNumbers(n);