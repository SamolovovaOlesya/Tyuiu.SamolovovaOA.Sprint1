using Tyuiu.SamolovovaOA.Sprint1.Task6.V16.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool result = ds.CheckSpecSymbols(input);
        if (result)
            Console.WriteLine("Строка содержит одновременно символы ! и ?.");
        else 
            Console.WriteLine("В строке нет обоих символов одновременно.");
            
        Console.ReadLine();
    }
}