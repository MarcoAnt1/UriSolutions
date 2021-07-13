using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1015Tests
    {
        private Uri1015 uri1015;

        [TestInitialize]
        public void Initialize()
        {
            uri1015 = new Uri1015();
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
        }

        [TestMethod]
        public void Uri1015_Example_01()
        {
            string retorno = uri1015.SolutionForTests("1.0 7.0", "5.0 9.0");

            Assert.AreEqual("4.4721", retorno);
        }

        [TestMethod]
        public void Uri1015_Example_02()
        {
            string retorno = uri1015.SolutionForTests("-2.5 0.4", "12.1 7.3");

            Assert.AreEqual("16.1484", retorno);
        }

        [TestMethod]
        public void Uri1015_Example_03()
        {
            string retorno = uri1015.SolutionForTests("2.5 -0.4", "-12.2 7.0");

            Assert.AreEqual("16.4575", retorno);
        }
    }
}
