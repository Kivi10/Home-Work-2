// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool ValidateRank(int num)
{
    if (num > 100)
    {
        return true;
    }
    System.Console.WriteLine("Третьей цифры нет.");
    return false;
}

int number = InputInt("Введите число ");

if (ValidateRank(number))
{
    while (number > 1000) number = number / 10;
    int result = number % 10;
    System.Console.WriteLine($"Третье число = {result}");
}
