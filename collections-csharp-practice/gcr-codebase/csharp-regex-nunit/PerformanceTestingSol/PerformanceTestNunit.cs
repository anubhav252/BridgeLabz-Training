using NUnit.Framework;

namespace PerformanceNUnitTest
{
    [TestFixture]
    public class PerformanceUtilsTests
    {
        private PerformanceUtils utils;

        [SetUp]
        public void Setup()
        {
            utils = new PerformanceUtils();
        }

        [Test]
        [Timeout(2000)] 
        public void LongRunningTask_Should_Fail_If_Too_Slow()
        {
            utils.LongRunningTask();
        }
    }
}
