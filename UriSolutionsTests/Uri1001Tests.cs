using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1001Tests
    {
        [TestMethod]
        public void Solution_Example_01()
        {
            var retorno = Uri1001.SolutionForTest(10, 9);

            Assert.AreEqual(19, retorno);
        }

        [TestMethod]
        public void Solution_Example_02()
        {
            var retorno = Uri1001.SolutionForTest(-10, 4);

            Assert.AreEqual(-6, retorno);
        }

        [TestMethod]
        public void Solution_Example_03()
        {
            var retorno = Uri1001.SolutionForTest(15, -7);

            Assert.AreEqual(8, retorno);
        }
    }
}
