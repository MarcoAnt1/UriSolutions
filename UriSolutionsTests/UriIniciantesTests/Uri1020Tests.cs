using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1020Tests
    {
        private Uri1020 uri1020;

        [TestInitialize]
        public void Initialize()
        {
            uri1020 = new Uri1020();
        }

        [TestMethod]
        public void Uri1018_Example_01()
        {
            List<string> retorno = uri1020.SolutionForTests(400);

            Assert.IsTrue(retorno.Contains("1 ano(s)"));
            Assert.IsTrue(retorno.Contains("1 mes(es)"));
            Assert.IsTrue(retorno.Contains("5 dia(s)"));
        }

        [TestMethod]
        public void Uri1018_Example_02()
        {
            List<string> retorno = uri1020.SolutionForTests(800);

            Assert.IsTrue(retorno.Contains("2 ano(s)"));
            Assert.IsTrue(retorno.Contains("2 mes(es)"));
            Assert.IsTrue(retorno.Contains("10 dia(s)"));
        }

        [TestMethod]
        public void Uri1018_Example_03()
        {
            List<string> retorno = uri1020.SolutionForTests(30);

            Assert.IsTrue(retorno.Contains("0 ano(s)"));
            Assert.IsTrue(retorno.Contains("1 mes(es)"));
            Assert.IsTrue(retorno.Contains("0 dia(s)"));
        }
    }
}
