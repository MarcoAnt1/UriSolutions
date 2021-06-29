using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1019Tests
    {
        private Uri1019 uri1019;

        [TestInitialize]
        public void Initialize()
        {
            uri1019 = new Uri1019();
        }

        [TestMethod]
        public void Uri1018_Example_01()
        {
            string retorno = uri1019.SolutionForTests(556);

            Assert.AreEqual("0:9:16", retorno);
        }

        [TestMethod]
        public void Uri1018_Example_02()
        {
            string retorno = uri1019.SolutionForTests(1);

            Assert.AreEqual("0:0:1", retorno);
        }

        [TestMethod]
        public void Uri1018_Example_03()
        {
            string retorno = uri1019.SolutionForTests(140153);

            Assert.AreEqual("38:55:53", retorno);
        }
    }
}
