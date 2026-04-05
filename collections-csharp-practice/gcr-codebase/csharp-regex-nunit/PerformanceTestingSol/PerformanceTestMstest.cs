using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerformanceMSTest
{
    [TestClass]
    public class PerformanceUtilsTests
    {
        private PerformanceUtils utils;

        [TestInitialize]
        public void Setup()
        {
            utils = new PerformanceUtils();
        }

        [TestMethod]
        [Timeout(2000)] 
        public void LongRunningTask_Should_Fail_If_Too_Slow()
        {
            utils.LongRunningTask();
        }
    }
}
