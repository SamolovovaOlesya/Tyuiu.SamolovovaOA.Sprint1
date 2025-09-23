using Tyuiu.SamolovovaOA.Sprint1.Task2.V24.Lib;

namespace Tyuiu.SamolovovaOA.Sprint1.Task2.V24.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 3;

            var res = ds.CalculateDiffSquare(x, y);
            Assert.AreEqual(4, res);
        }
    }
}

