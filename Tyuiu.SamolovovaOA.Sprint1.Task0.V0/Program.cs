using Tyuiu.SamolovovaOA.Sprint1.Task0.V0.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DaraService ds = new DaraService();

        Console.Title = "Спринт #1 | Выполнила: Самоловова О. А. | ПИНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в S#                                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #0                                                              *");
        Console.WriteLine("* Выполнила: Самоловова Олеся Алексеевна | ПИНб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет выражение 10 / (2 + 3)            *");
        Console.WriteLine("* и печатает результат на экране                                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* 10 / (2 + 3)                                                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate());
        Console.ReadLine();
    }
}