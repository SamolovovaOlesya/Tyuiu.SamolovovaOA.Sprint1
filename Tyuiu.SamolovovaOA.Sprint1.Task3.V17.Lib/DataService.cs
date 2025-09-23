using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SamolovovaOA.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            number = Math.Abs(number);
            double fractional = number - Math.Floor(number);

            int d1 = (int)(fractional * 10) % 10;
            int d2 = (int)(fractional * 100) % 10;
            int d3 = (int)(fractional * 1000) % 10;

            if (d1 == 0 || d2 == 0 || d3 == 0)
                return true;

            return false;
        }
    }
}
