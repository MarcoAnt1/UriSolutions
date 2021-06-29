using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UriSolutions;

namespace UriSolutionsTests
{
    [TestClass]
    public class Uri1866Tests
    {
        [TestMethod]
        public void Uri1866_Example_01()
        {
            List<int> retorno = new Uri1866().SolutionForTests("3 11 7 18");

            Assert.IsTrue(retorno[0].Equals(1));
            Assert.IsTrue(retorno[1].Equals(1));
            Assert.IsTrue(retorno[2].Equals(0));
        }
    }
}
