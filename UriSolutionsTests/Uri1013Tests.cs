using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1013Tests
    {
        private Uri1013 uri1013;

        [TestInitialize]
        public void Initialize()
        {
            uri1013 = new Uri1013();
        }

        [TestMethod]
        public void Uri1013_Example_01()
        {
            int retorno = uri1013.SolutionForTests("7 14 106");

            Assert.AreEqual(106, retorno);
        }

        [TestMethod]
        public void Uri1013_Example_02()
        {
            int retorno = uri1013.SolutionForTests("217 14 6");

            Assert.AreEqual(217, retorno);
        }
    }
}
