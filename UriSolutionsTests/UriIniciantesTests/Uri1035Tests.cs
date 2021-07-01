using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1035Tests
    {
        private Uri1035 uri1035;

        [TestInitialize]
        public void Initialize()
        {
            uri1035 = new Uri1035();
        }

        [TestMethod]
        public void Uri1035_Example_01()
        {
            string retorno = uri1035.SolutionForTests("5 6 7 8");

            Assert.AreEqual("Valores nao aceitos", retorno);
        }

        [TestMethod]
        public void Uri1035_Example_02()
        {
            string retorno = uri1035.SolutionForTests("2 3 2 6");

            Assert.AreEqual("Valores aceitos", retorno);
        }
    }
}
