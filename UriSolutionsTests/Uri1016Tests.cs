using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1016Tests
    {
        private Uri1016 uri1016;

        [TestInitialize]
        public void Initialize()
        {
            uri1016 = new Uri1016();
        }

        [TestMethod]
        public void Uri1014_Example_01()
        {
            int retorno = uri1016.SolutionForTests(30);

            Assert.AreEqual(60, retorno);
        }

        [TestMethod]
        public void Uri1014_Example_02()
        {
            int retorno = uri1016.SolutionForTests(110);

            Assert.AreEqual(220, retorno);
        }

        [TestMethod]
        public void Uri1014_Example_03()
        {
            int retorno = uri1016.SolutionForTests(7);

            Assert.AreEqual(14, retorno);
        }
    }
}
