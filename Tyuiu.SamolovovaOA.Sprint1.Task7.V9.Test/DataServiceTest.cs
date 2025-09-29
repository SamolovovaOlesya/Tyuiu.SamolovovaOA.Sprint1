using Microsoft.VisualBasic;
using Tyuiu.SamolovovaOA.Sprint1.Task7.V9.Lib;

namespace Tyuiu.SamolovovaOA.Sprint1.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 2.167;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
