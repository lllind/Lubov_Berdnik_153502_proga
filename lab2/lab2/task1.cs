bool isTrue = true;

while (isTrue)
{
    if(Solving.isEven(input()))
    {
        Console.WriteLine("Cумма цифр двухзначного числа является четной!");
    }
    else
    {
        Console.WriteLine("Cумма цифр двухзначного числа не является четной :(");
    }

    string? str = null;
    while (str != "Да" && str != "Нет")
    {
        Console.WriteLine("Хотите продолжить? (Да/Нет)");
        str = Console.ReadLine();
    }
    switch (str)
    {
        case "Да":
            continue;
        case "Нет":
            isTrue = false;
            break;
        default:
            break;
    }
}

static int input()
{
    Console.Write("Введите двузначное число: ");
    int number = Solving.inputInt();
    return number;
}
public class Solving
{
    public static bool isEven(int number)
    {
        int a = number % 10, b = number / 10;
        if ((a + b) % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int inputInt()
    {
        while (true)
        {
            int n;

            if (!int.TryParse(Console.ReadLine(), out n) || n < 10 || n > 99)
            {
                Console.WriteLine("Ошибка ввода! Повторите попытку!");
            }
            else
            {
                return n;
            }
        }
    }
}

