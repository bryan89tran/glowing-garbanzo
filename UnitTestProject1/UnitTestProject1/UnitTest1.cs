using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    [TestCategory("LoginFeature")]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Postive")]
        [Description("These are test demo units")]
        public void TestMethod1()
        {
            var a = 2;
            var b = 1;
            Assert.AreEqual(3, a + b);
        }
         
        [TestMethod]
        [TestCategory("Negative")]
        public void TestMethod2()
        {
            var a = 1;
            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            var a = 1;
            Assert.AreNotEqual(a, 1);
        }

        public void RunOtherTest()
        {

        }
    }
}
