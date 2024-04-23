using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BaseSalary()
        {
            Assert.ThrowsException<Exception>(() => { Formulas.Base_salary(-1, 1, 1)});
        }
    }
}
