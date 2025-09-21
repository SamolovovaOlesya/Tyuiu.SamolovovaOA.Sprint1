using Tyuiu.SamolovovaOA.Sprint1.Task0.V26.Lib;

namespace Tyuiu.SamolovovaOA.Sprint1.Task0.V26.Test
{
    [TestClass]
    public sealed class DaraServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DaraService ds = new DaraService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
