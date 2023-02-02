// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int daynum = InputInt("Введите номер дня недели ");
if (daynum < 7)
{
    if (daynum == 6 || daynum == 7)
    {
        System.Console.WriteLine("Выходной день.");
    }
    else System.Console.WriteLine("Будний день.");
}
else System.Console.WriteLine("Нет такого дня недели.");


