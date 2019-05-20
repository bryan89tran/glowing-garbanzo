using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    [TestCategory("Quiz")]
    public class Test2
    {
        //1. All test should be categorized as Quiz
        //2. 3 test method
        //3. One test checks that 1 + 1 = 2;
        //4. One test automatically fails using special assertion method
        //5. One test check that 10 + 10 = 21 and expects that test to fail


        [TestMethod]
        public void FirstTest()
        {
            var a = 1;
            Assert.AreEqual(2, a + a);
        }

        [TestMethod]
        public void SecondTest()
        {
            Assert.Fail("Special Assertion method");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ThirdTest()
        {
            var b = 10;
            Assert.AreEqual(21, b + b);
        }
    }
}
