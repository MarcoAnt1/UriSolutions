using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1036Tests
    {
        private Uri1036 uri10356;

        [TestInitialize]
        public void Initialize()
        {
            uri10356 = new Uri1036();
        }

        [TestMethod]
        public void Uri1036_Example_01()
        {
            List<string> retorno = uri10356.SolutionForTests("10.0 20.1 5.1");

            Assert.IsTrue(retorno.Contains("R1 = -0.29788"));
            Assert.IsTrue(retorno.Contains("R2 = -1.71212"));
        }

        [TestMethod]
        public void Uri1036_Example_02()
        {
            List<string> retorno = uri10356.SolutionForTests("0.0 20.0 5.0");

            Assert.IsTrue(retorno.Contains("Impossivel calcular"));
        }

        [TestMethod]
        public void Uri1036_Example_03()
        {
            List<string> retorno = uri10356.SolutionForTests("10.3 203.0 5.0");

            Assert.IsTrue(retorno.Contains("R1 = -0.02466"));
            Assert.IsTrue(retorno.Contains("R2 = -19.68408"));
        }

        [TestMethod]
        public void Uri1036_Example_04()
        {
            List<string> retorno = uri10356.SolutionForTests("110.0 3.0 5.0");

            Assert.IsTrue(retorno.Contains("Impossivel calcular"));
        }
    }
}
