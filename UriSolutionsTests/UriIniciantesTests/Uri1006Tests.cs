using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1006Tests
    {
        private Uri1006 uri1006;

        [TestInitialize]
        public void Initialize()
        {
            uri1006 = new Uri1006();
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
        }

        [TestMethod]
        public void Uri1006_Example_01()
        {
            var retorno = uri1006.SolutionForTests(5.0, 6.0, 7.0);

            Assert.AreEqual("6.3", retorno);
        }

        [TestMethod]
        public void Uri1006_Example_02()
        {
            var retorno = uri1006.SolutionForTests(5.0, 10.0, 10.0);

            Assert.AreEqual("9.0", retorno);
        }

        [TestMethod]
        public void Uri1006_Example_03()
        {
            var retorno = uri1006.SolutionForTests(10.0, 10.0, 5.0);

            Assert.AreEqual("7.5", retorno);
        }
    }
}
