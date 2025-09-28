using Tyuiu.SamolovovaOA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.SamolovovaOA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double temp = 68;
            DataService ds = new DataService();

            int result = ds.FahrenheitToСelsius(temp);
            int wait = 20;
            Assert.AreEqual(wait, result);
        }
    }
}
