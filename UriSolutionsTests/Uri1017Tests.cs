using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1017Tests
    {
        private Uri1017 uri1017;

        [TestInitialize]
        public void Initialize()
        {
            uri1017 = new Uri1017();
        }

        [TestMethod]
        public void Uri1017_Example_01()
        {
            string retorno = uri1017.SolutionForTests(10, 85);

            Assert.AreEqual("70.833", retorno);
        }

        [TestMethod]
        public void Uri1017_Example_02()
        {
            string retorno = uri1017.SolutionForTests(2, 92);

            Assert.AreEqual("15.333", retorno);
        }

        [TestMethod]
        public void Uri1017_Example_03()
        {
            string retorno = uri1017.SolutionForTests(22, 67);

            Assert.AreEqual("122.833", retorno);
        }
    }
}
