// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.

void Main()
{
    int N = ReadInt("введите натуральное число: ");
    if(N < 1)
    {
        System.Console.WriteLine("Вы ввели некорректное число");
        return;
    }
    PrintNaturals(N);
}

void PrintNaturals(int N)
{
    if(N < 1) return;
    PrintNaturals(N - 1);
    System.Console.Write(N + " ");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();