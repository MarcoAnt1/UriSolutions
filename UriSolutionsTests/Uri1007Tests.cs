using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1007Tests
    {
        private Uri1007 uri1007;

        [TestInitialize]
        public void Initialize()
        {
            uri1007 = new Uri1007();
        }

        [TestMethod]
        public void Uri1003_Example_01()
        {
            var retorno = uri1007.SolutionForTests(5, 6, 7, 8);

            Assert.AreEqual(-26, retorno);
        }

        [TestMethod]
        public void Uri1003_Example_02()
        {
            var retorno = uri1007.SolutionForTests(0, 0, 7, 8);

            Assert.AreEqual(-56, retorno);
        }

        [TestMethod]
        public void Uri1003_Example_03()
        {
            var retorno = uri1007.SolutionForTests(5, 6, -7, 8);

            Assert.AreEqual(86, retorno);
        }
    }
}
