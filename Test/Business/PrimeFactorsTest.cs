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


    }
}
