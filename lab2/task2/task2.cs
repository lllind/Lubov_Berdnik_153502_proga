bool isTrue = true;

while (isTrue)
{
    Solving.solve(inputX(), inputY());

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

static double inputX()
{
    Console.Write("Введите x: ");
    double x = Solving.input_double();
    return x;
}

static double inputY()
{
    Console.Write("Введите y: ");
    double y = Solving.input_double();
    return y;
}

public class Solving
{
    public static int solve(double x,double y)
    {

        if (y >= x && y <= 15 && y >= 0 && (x >= -15 / 1.41 || x <= 15 / 1.41) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 225))
        {
            if (Math.Abs(x) == y || (Math.Pow(x, 2) + Math.Pow(y, 2) == 225))
            {
                Console.WriteLine("На границе");
                return 0;

            }
            else
            {
                Console.WriteLine("Да");
                return 1;
            }

        }
        else
        {
            Console.WriteLine("Нет");
            return -1;
        }
    }
    public static double input_double()
    {
    while (true)
    {
        double n;

        if (!double.TryParse(Console.ReadLine(), out n))
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