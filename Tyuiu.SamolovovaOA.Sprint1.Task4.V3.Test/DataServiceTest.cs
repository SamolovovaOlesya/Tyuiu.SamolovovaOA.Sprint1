using Tyuiu.SamolovovaOA.Sprint1.Task4.V3.Lib;

namespace Tyuiu.SamolovovaOA.Sprint1.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 3;
            double y = 2;
            double wait = 3;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
