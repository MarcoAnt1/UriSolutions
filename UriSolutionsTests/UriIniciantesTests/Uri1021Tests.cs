using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1021Tests
    {
        private Uri1021 uri1021;

        [TestInitialize]
        public void Initialize()
        {
            uri1021 = new Uri1021();
        }

        [TestMethod]
        public void Uri1021_Example_01()
        {
            List<string> retorno = uri1021.SolutionForTests("576.73");

            Assert.IsTrue(retorno.Contains("5 nota(s) de R$ 100.00"));
            Assert.IsTrue(retorno.Contains("1 nota(s) de R$ 50.00"));
            Assert.IsTrue(retorno.Contains("1 nota(s) de R$ 20.00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 10.00"));
            Assert.IsTrue(retorno.Contains("1 nota(s) de R$ 5.00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 2.00"));
            Assert.IsTrue(retorno.Contains("1 moeda(s) de R$ 1.00"));
            Assert.IsTrue(retorno.Contains("1 moeda(s) de R$ 0.50"));
            Assert.IsTrue(retorno.Contains("0 moeda(s) de R$ 0.25"));
            Assert.IsTrue(retorno.Contains("2 moeda(s) de R$ 0.10"));
            Assert.IsTrue(retorno.Contains("0 moeda(s) de R$ 0.05"));
            Assert.IsTrue(retorno.Contains("3 moeda(s) de R$ 0.01"));
        }

        [TestMethod]
        public void Uri1021_Example_02()
        {
            List<string> retorno = uri1021.SolutionForTests("4.00");

            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 100.00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 50.00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 20.00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 10.00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 5.00"));
            Assert.IsTrue(retorno.Contains("2 nota(s) de R$ 2.00"));
            Assert.IsTrue(retorno.Contains("0 moeda(s) de R$ 1.00"));
            Assert.IsTrue(retorno.Contains("0 moeda(s) de R$ 0.50"));
            Assert.IsTrue(retorno.Contains("0 moeda(s) de R$ 0.25"));
            Assert.IsTrue(retorno.Contains("0 moeda(s) de R$ 0.10"));
            Assert.IsTrue(retorno.Contains("0 moeda(s) de R$ 0.05"));
            Assert.IsTrue(retorno.Contains("0 moeda(s) de R$ 0.01"));
        }

        [TestMethod]
        public void Uri1021_Example_03()
        {
            List<string> retorno = uri1021.SolutionForTests("91.01");

            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 100.00"));
            Assert.IsTrue(retorno.Contains("1 nota(s) de R$ 50.00"));
            Assert.IsTrue(retorno.Contains("2 nota(s) de R$ 20.00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 10.00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 5.00"));
            Assert.IsTrue(retorno.Contains("0 nota(s) de R$ 2.00"));
            Assert.IsTrue(retorno.Contains("1 moeda(s) de R$ 1.00"));
            Assert.IsTrue(retorno.Contains("0 moeda(s) de R$ 0.50"));
            Assert.IsTrue(retorno.Contains("0 moeda(s) de R$ 0.25"));
            Assert.IsTrue(retorno.Contains("0 moeda(s) de R$ 0.10"));
            Assert.IsTrue(retorno.Contains("0 moeda(s) de R$ 0.05"));
            Assert.IsTrue(retorno.Contains("1 moeda(s) de R$ 0.01"));
        }
    }
}
