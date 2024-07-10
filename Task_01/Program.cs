// // Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// // Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

void Main()
{
    bool run = true;
    while (run)
    {
        run = GetResult(ReadString());

    }
}


bool GetResult(string? input)
{
    if (input == "q")
        return false;
    else if (StringIsDigits(input) == false)
    {
        System.Console.WriteLine("Вы ввели не целое число!!!");
        return true;
    }
    else
    {
        return NumbersResult(Convert.ToInt32(input));
    }
}


string? ReadString()
{
    System.Console.WriteLine("Введите целое чило или символ q для выхода из программы: ");
    return Console.ReadLine();
}


bool StringIsDigits(string? input)
{
    foreach (var item in input)
    {
        if (!char.IsDigit(item))
            return false;
    }
    return true;
}


bool NumbersResult(int input)
{
    int result = 0;
    while (input > 0)
    {
        result += input % 10;
        input /= 10;
    }
    if (result % 2 == 0)
        return false;
    else
        return true;
}

Main();


