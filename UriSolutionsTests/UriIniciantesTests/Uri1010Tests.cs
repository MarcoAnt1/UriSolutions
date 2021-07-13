using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1010Tests
    {
        private Uri1010 uri1010;

        [TestInitialize]
        public void Initialize()
        {
            uri1010 = new Uri1010();
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
        }

        [TestMethod]
        public void Uri1010_Example_01()
        {
            string retorno = uri1010.SolutionForTests("12 1 5.30", "16 2 5.10");

            Assert.AreEqual("15.50", retorno);
        }

        [TestMethod]
        public void Uri1010_Example_02()
        {
            string retorno = uri1010.SolutionForTests("13 2 15.30", "161 4 5.20");

            Assert.AreEqual("51.40", retorno);
        }

        [TestMethod]
        public void Uri1010_Example_03()
        {
            string retorno = uri1010.SolutionForTests("1 1 15.10", "2 1 15.10");

            Assert.AreEqual("30.20", retorno);
        }
    }
}
