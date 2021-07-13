using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Globalization;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1009Tests
    {
        private Uri1009 uri1009;

        [TestInitialize]
        public void Initialize()
        {
            uri1009 = new Uri1009();
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
        }

        [TestMethod]
        public void Uri1009_Example_01()
        {
            Dictionary<string, string> retorno = uri1009.SolutionForTests("JOAO", 500.00, 1230.30);

            Assert.IsTrue(retorno.ContainsKey("JOAO"));
            Assert.IsTrue(retorno.ContainsValue("684.54"));
        }

        [TestMethod]
        public void Uri1009_Example_02()
        {
            Dictionary<string, string> retorno = uri1009.SolutionForTests("PEDRO", 700.00, 0.00);

            Assert.IsTrue(retorno.ContainsKey("PEDRO"));
            Assert.IsTrue(retorno.ContainsValue("700.00"));
        }

        [TestMethod]
        public void Uri1009_Example_03()
        {
            Dictionary<string, string> retorno = uri1009.SolutionForTests("MANGOJATA", 1700.00, 1230.50);

            Assert.IsTrue(retorno.ContainsKey("MANGOJATA"));
            Assert.IsTrue(retorno.ContainsValue("1884.58"));
        }
    }
}
