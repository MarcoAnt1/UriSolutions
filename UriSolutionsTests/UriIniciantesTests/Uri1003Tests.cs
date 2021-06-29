using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1003Tests
    {
        private Uri1003 uri1003;

        [TestInitialize]
        public void Initialize()
        {
            uri1003 = new Uri1003();
        }

        [TestMethod]
        public void Uri1003_Example_01()
        {
            var retorno = uri1003.SolutionForTests(30, 10);

            Assert.AreEqual(40, retorno);
        }

        [TestMethod]
        public void Uri1003_Example_02()
        {
            var retorno = uri1003.SolutionForTests(-30, 10);

            Assert.AreEqual(-20, retorno);
        }

        [TestMethod]
        public void Uri1003_Example_03()
        {
            var retorno = uri1003.SolutionForTests(0, 0);

            Assert.AreEqual(0, retorno);
        }
    }
}
