// считайте строку с консоли, содержащую латинские 
// буквы. Вывести на экран согласные буквы этой строки.

void Main()
{
    System.Console.Write("Введите строку: ");
    string? str = Console.ReadLine();
    PrintConsonants(str);
}
// i - индекс, который мы используем для того, чтобы пробегаться по строке.
void PrintConsonants(string input)
{
    if(input.Length < 1) return;
    // char c = char.ToLower(input[i]);
    // if(IsConsonant(c))
    // либо можно модернезировать строку, не создавая новой переменной
    if(IsConsonant(char.ToLower(input[0])))
        System.Console.Write(input[0] + " ");
    PrintConsonants(input [1..]);
}

// функция, которая проверит, является ли наше значение согласным
bool IsConsonant(char c)
{
    // Contains - метод, который помогает проверить содержит ли данная строка тот символ,
    // который мы отправили на проверку
    return"qwrtpsdfghjklzxcvbnm".Contains(c);
}

Main();