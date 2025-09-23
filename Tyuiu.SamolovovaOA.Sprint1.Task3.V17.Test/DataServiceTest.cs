using Tyuiu.SamolovovaOA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.SamolovovaOA.Sprint1.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double number = 1.706;
            bool wait = true;

            var res = ds.ZeroCheck(number);

            Assert.AreEqual(wait, res);
        }
    }
}
