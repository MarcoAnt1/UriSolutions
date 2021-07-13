using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1011Tests
    {
        private Uri1011 uri1011;

        [TestInitialize]
        public void Initialize()
        {
            uri1011 = new Uri1011();
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
        }

        [TestMethod]
        public void Uri1011_Example_01()
        {
            string retorno = uri1011.SolutionForTests(3);

            Assert.AreEqual("113.097", retorno);
        }

        [TestMethod]
        public void Uri1011_Example_02()
        {
            string retorno = uri1011.SolutionForTests(15);

            Assert.AreEqual("14137.155", retorno);
        }

        [TestMethod]
        public void Uri1011_Example_03()
        {
            string retorno = uri1011.SolutionForTests(1523);

            Assert.AreEqual("14797486501.627", retorno);
        }
    }
}
