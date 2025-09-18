
using Tyuiu.SamolovovaOA.Sprint1.Task0.V0.Lib;

namespace Tyuiu.SamolovovaOA.Sprint1.Task0.V0.Test
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
