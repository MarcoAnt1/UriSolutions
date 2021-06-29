using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1002Tests
    {
        private Uri1002 uri1002;

        [TestInitialize]
        public void Initialize()
        {
            uri1002 = new Uri1002();
        }

        [TestMethod]
        public void Uri1002_Example_01()
        { 
            var retorno = uri1002.SolutionForTests(2.00);

            Assert.AreEqual("12.5664", retorno);
        }

        [TestMethod]
        public void Uri1002_Example_02()
        {
            string retorno = uri1002.SolutionForTests(100.64);

            Assert.AreEqual("31819.3103", retorno);
        }

        [TestMethod]
        public void Uri1002_Example_03()
        {
            var retorno = uri1002.SolutionForTests(150.00);

            Assert.AreEqual("70685.7750", retorno);
        }
    }
}
