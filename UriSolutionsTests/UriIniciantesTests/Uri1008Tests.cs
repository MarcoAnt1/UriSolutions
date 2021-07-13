using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Globalization;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1008Tests
    {
        private Uri1008 uri1008;

        [TestInitialize]
        public void Initialize()
        {
            uri1008 = new Uri1008();
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
        }

        [TestMethod]
        public void Uri1008_Example_01()
        {
            Dictionary<int, string> retorno = uri1008.SolutionForTests(25, 100, 5.50);

            Assert.IsTrue(retorno.ContainsKey(25));
            Assert.IsTrue(retorno.ContainsValue("550.00"));
        }

        [TestMethod]
        public void Uri1008_Example_02()
        {
            Dictionary<int, string> retorno = uri1008.SolutionForTests(1, 200, 20.50);

            Assert.IsTrue(retorno.ContainsKey(1));
            Assert.IsTrue(retorno.ContainsValue("4100.00"));
        }

        [TestMethod]
        public void Uri1008_Example_03()
        {
            Dictionary<int, string> retorno = uri1008.SolutionForTests(6, 145, 15.55);

            Assert.IsTrue(retorno.ContainsKey(6));
            Assert.IsTrue(retorno.ContainsValue("2254.75"));
        }
    }
}
