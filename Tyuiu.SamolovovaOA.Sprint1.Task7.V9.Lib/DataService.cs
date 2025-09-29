using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SamolovovaOA.Sprint1.Task7.V9.Lib
{
    public class DataService : ISprint1Task7V9
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Exp(x) - (Math.Pow(y, 2) + Math.Cos(3 * Math.Pow(y, 2)) + 12 * x * y - 3 * Math.Pow(x, 2)) / (Math.Cos(Math.Pow(x, 3) + 3) + 18 * y - 1);
            return res;


           
        }
    }
}
