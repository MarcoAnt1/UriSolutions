using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1005Tests
    {
        private Uri1005 uri1005;

        [TestInitialize]
        public void Initialize()
        {
            uri1005 = new Uri1005();
        }

        [TestMethod]
        public void Uri1003_Example_01()
        {
            var retorno = uri1005.SolutionForTests(5.0, 7.1);

            Assert.AreEqual("6.43182", retorno);
        }

        [TestMethod]
        public void Uri1003_Example_02()
        {
            var retorno = uri1005.SolutionForTests(0.0, 7.1);

            Assert.AreEqual("4.84091", retorno);
        }

        [TestMethod]
        public void Uri1003_Example_03()
        {
            var retorno = uri1005.SolutionForTests(10.0, 10.0);

            Assert.AreEqual("10.00000", retorno);
        }
    }
}
