using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1004Tests
    {
        private Uri1004 uri1004;

        [TestInitialize]
        public void Initialize()
        {
            uri1004 = new Uri1004();
        }

        [TestMethod]
        public void Uri1003_Example_01()
        {
            var retorno = uri1004.SolutionForTests(3, 9);

            Assert.AreEqual(27, retorno);
        }

        [TestMethod]
        public void Uri1003_Example_02()
        {
            var retorno = uri1004.SolutionForTests(-30, 10);

            Assert.AreEqual(-300, retorno);
        }

        [TestMethod]
        public void Uri1003_Example_03()
        {
            var retorno = uri1004.SolutionForTests(0, 9);

            Assert.AreEqual(0, retorno);
        }
    }
}
