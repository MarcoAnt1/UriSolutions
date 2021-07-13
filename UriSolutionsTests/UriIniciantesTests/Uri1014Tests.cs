using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1014Tests
    {
        private Uri1014 uri1014;

        [TestInitialize]
        public void Initialize()
        {
            uri1014 = new Uri1014();
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
        }

        [TestMethod]
        public void Uri1014_Example_01()
        {
            string retorno = uri1014.SolutionForTests(500, 35.0);

            Assert.AreEqual("14.286", retorno);
        }

        [TestMethod]
        public void Uri1014_Example_02()
        {
            string retorno = uri1014.SolutionForTests(2254, 124.4);

            Assert.AreEqual("18.119", retorno);
        }

        [TestMethod]
        public void Uri1014_Example_03()
        {
            string retorno = uri1014.SolutionForTests(4554, 464.6);

            Assert.AreEqual("9.802", retorno);
        }
    }
}
