using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1001Tests
    {
        private Uri1001 uri1001;

        [TestInitialize]
        public void Initialize()
        {
            uri1001 = new Uri1001();
        }

        [TestMethod]
        public void Uri1001_Example_01()
        {
            var retorno = uri1001.SolutionForTests(10, 9);

            Assert.AreEqual(19, retorno);
        }

        [TestMethod]
        public void Uri1001_Example_02()
        {
            var retorno = uri1001.SolutionForTests(-10, 4);

            Assert.AreEqual(-6, retorno);
        }

        [TestMethod]
        public void Uri1001_Example_03()
        {
            var retorno = uri1001.SolutionForTests(15, -7);

            Assert.AreEqual(8, retorno);
        }
    }
}
