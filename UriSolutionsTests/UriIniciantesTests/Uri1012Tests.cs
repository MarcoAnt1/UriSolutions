using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Globalization;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1012Tests
    {
        private Uri1012 uri1012;

        [TestInitialize]
        public void Initialize()
        {
            uri1012 = new Uri1012();
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
        }

        [TestMethod]
        public void Uri1012_Example_01()
        {
            List<string> retorno = uri1012.SolutionForTests("3.0 4.0 5.2");

            Assert.IsTrue(retorno.Contains("7.800"));
            Assert.IsTrue(retorno.Contains("84.949"));
            Assert.IsTrue(retorno.Contains("18.200"));
            Assert.IsTrue(retorno.Contains("16.000"));
            Assert.IsTrue(retorno.Contains("12.000"));
        }

        [TestMethod]
        public void Uri1012_Example_02()
        {
            List<string> retorno = uri1012.SolutionForTests("12.7 10.4 15.2");

            Assert.IsTrue(retorno.Contains("96.520"));
            Assert.IsTrue(retorno.Contains("725.833"));
            Assert.IsTrue(retorno.Contains("175.560"));
            Assert.IsTrue(retorno.Contains("108.160"));
            Assert.IsTrue(retorno.Contains("132.080"));
        }
    }
}
