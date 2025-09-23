using Tyuiu.SamolovovaOA.Sprint1.Task2.V24.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x;
        int y;

        Console.WriteLine("Введите значение X: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение Y: ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Квадрат разности (X - Y)^2 = " + ds.CalculateDiffSquare(x, y));

        Console.ReadLine();
    }
}