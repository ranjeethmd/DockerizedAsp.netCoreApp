using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DockerizedAppUnitTest
{
    [TestClass]
    public class DemoUnitTest
    {
        [TestMethod]
        public void SuccessTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void FailedTest()
        {
            Assert.IsTrue(true);
        }
    }
}
