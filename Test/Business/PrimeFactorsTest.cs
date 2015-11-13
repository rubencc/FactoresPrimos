using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Business
{
    [TestClass]
    public class PrimeFactorsTest
    {
        private PrimeFactors primeFactors;

        [TestInitialize]
        public void Setup()
        {
            this.primeFactors = new PrimeFactors();
        }

        [TestCleanup]
        public void Clean()
        {
            this.primeFactors = null;
        }

        [TestMethod]
        public void Calcular_los_factores_primos_de_2()
        {
            int input = 2;

            List<int> expected = new List<int>(){2};

            List<int> result = this.primeFactors.Calculate(input);

            Assert.AreEqual(1, result.Count, "El numero de factores deberia ser 1");
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
