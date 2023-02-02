// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool ValidateNumRank3(int number)
{
    if (number > 99 && number < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Число не трехзначное");
    return false;
}

int number = InputInt("Введите трехзначное число");

if (ValidateNumRank3(number))
{
    int midRank = number % 100 / 10;

    System.Console.WriteLine($"Вторая цифра числа {number} равна {midRank}");
}