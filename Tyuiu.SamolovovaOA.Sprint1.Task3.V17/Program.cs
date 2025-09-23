using Tyuiu.SamolovovaOA.Sprint1.Task3.V17.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        
        Console.WriteLine("Введите вещественное число:");
        double number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool result = ds.ZeroCheck(number);
        if (result)
            Console.WriteLine("Среди первых трех цифр дробной части есть 0");
        else
            Console.WriteLine("Среди первых трех цифр дробной части нет 0");
        Console.ReadLine();
    }
}