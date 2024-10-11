using Tyuiu.MolodchikovEE.Sprint6.Task0.V14.Lib;

namespace Tyuiu.MolodchikovEE.Sprint6.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = -1;
            double y = Math.Round((Math.Pow(1 - x, 2)) / (-3 * x), 3);
            var wait = 1.333;
            Assert.AreEqual(wait, y);
        }
    }
}