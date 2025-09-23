using Tyuiu.SamolovovaOA.Sprint1.Task1.V20.Lib;

namespace Tyuiu.SamolovovaOA.Sprint1.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 2.0;
            
            var res = ds.Calculate(x, y);
            Assert.AreEqual(13, res);
        }
    }
}
