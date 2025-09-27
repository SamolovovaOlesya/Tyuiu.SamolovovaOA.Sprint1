using Tyuiu.SamolovovaOA.Sprint1.Task4.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x, y;

        Console.WriteLine("Введите значение X: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение Y: ");
        y = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("√3x/(x - y)^2 = " + ds.Calculate(x, y));
        
        Console.ReadLine();
    }
}