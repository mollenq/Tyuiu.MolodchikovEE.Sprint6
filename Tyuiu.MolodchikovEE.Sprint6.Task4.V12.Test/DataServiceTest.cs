using Tyuiu.MolodchikovEE.Sprint6.Task4.V12.Lib;

namespace Tyuiu.MolodchikovEE.Sprint6.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1;
            double y = Math.Round((2 * Math.Cos(x) + 2) / (2 * x - 1) + Math.Cos(x) - 5 * x + 3, 2);
            var wait = 1.62;
            Assert.AreEqual(wait, y);
        }
    }
}