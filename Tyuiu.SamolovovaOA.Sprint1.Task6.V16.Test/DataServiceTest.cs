using Tyuiu.SamolovovaOA.Sprint1.Task6.V16.Lib;
namespace Tyuiu.SamolovovaOA.Sprint1.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string value = "Hello! How are you?";
            bool res = ds.CheckSpecSymbols(value);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidBoolean() 
        {
            DataService ds = new DataService();
            string value = "Hello how are you";
            bool res = ds.CheckSpecSymbols(value);

            bool wait = false;

            Assert.AreEqual(wait, res);
        }

    }
}
