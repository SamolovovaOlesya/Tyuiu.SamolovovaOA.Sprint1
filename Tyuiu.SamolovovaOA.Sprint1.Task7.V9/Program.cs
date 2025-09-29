using System.Globalization;
using Tyuiu.SamolovovaOA.Sprint1.Task7.V9.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("            2      3           2");
        Console.WriteLine("           y + cosx + 12xy - 3x");
        Console.WriteLine("      x");
        Console.WriteLine(" z = e  -  - - - - - - - - - - - -");
        Console.WriteLine("                3");
        Console.WriteLine("           cos(x + 3) + 18y - 1");

        double x, y;

        Console.WriteLine("Введите значение X: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y: ");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.Calculate(x, y);
        Console.WriteLine(res.ToString("F3", CultureInfo.InvariantCulture));
        Console.ReadKey();

    }
}