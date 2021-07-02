using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1037Tests
    {
        private Uri1037 uri10357;

        [TestInitialize]
        public void Initialize()
        {
            uri10357 = new Uri1037();
        }

        [TestMethod]
        public void Uri1037_Example_01()
        {
            string retorno = uri10357.SolutionForTests(25.01);

            Assert.AreEqual("Intervalo [25,50]", retorno);
        }

        [TestMethod]
        public void Uri1037_Example_02()
        {
            string retorno = uri10357.SolutionForTests(25.00);

            Assert.AreEqual("Intervalo [0,25]", retorno);
        }

        [TestMethod]
        public void Uri1037_Example_03()
        {
            string retorno = uri10357.SolutionForTests(100.00);

            Assert.AreEqual("Intervalo [75,100]", retorno);
        }

        [TestMethod]
        public void Uri1037_Example_04()
        {
            string retorno = uri10357.SolutionForTests(-25.02);

            Assert.AreEqual("Fora de intervalo", retorno);
        }
    }
}
