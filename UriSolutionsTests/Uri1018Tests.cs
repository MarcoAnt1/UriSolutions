using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1018Tests
    {
        private Uri1018 uri1018;

        [TestInitialize]
        public void Initialize()
        {
            uri1018 = new Uri1018();
        }

        [TestMethod]
        public void Uri1018_Example_01()
        {
            List<string> retorno = uri1018.SolutionForTests(576);

            Assert.IsTrue(retorno.Contains("5 nota(s) de R$ 100,00"));
            Assert.IsTrue(retorno.Contains("1 nota(s) de R$ 50,00"));
            Assert.IsTrue(retorno.Contains("1 nota(s) de R$ 20,00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 10,00"));
            Assert.IsTrue(retorno.Contains("1 nota(s) de R$ 5,00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 2,00"));
            Assert.IsTrue(retorno.Contains("1 nota(s) de R$ 1,00"));
        }

        [TestMethod]
        public void Uri1018_Example_02()
        {
            List<string> retorno = uri1018.SolutionForTests(11257);

            Assert.IsTrue(retorno.Contains("112 nota(s) de R$ 100,00"));
            Assert.IsTrue(retorno.Contains("1 nota(s) de R$ 50,00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 20,00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 10,00"));
            Assert.IsTrue(retorno.Contains("1 nota(s) de R$ 5,00"));
            Assert.IsTrue(retorno.Contains("1 nota(s) de R$ 2,00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 1,00"));
        }

        [TestMethod]
        public void Uri1018_Example_03()
        {
            List<string> retorno = uri1018.SolutionForTests(503);

            Assert.IsTrue(retorno.Contains("5 nota(s) de R$ 100,00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 50,00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 20,00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 10,00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 5,00"));
            Assert.IsTrue(retorno.Contains("1 nota(s) de R$ 2,00"));
            Assert.IsTrue(retorno.Contains("1 nota(s) de R$ 1,00"));
        }
    }
}
