using csharp_template.Main;
using NUnit.Framework;

namespace csharp_template.Test
{
    [TestFixture]
    public class CoreTests
    {
        private Core _core;
        public CoreTests()
        {
            _core = new Core();
        }
        [Test]
        public void Test()
        {
            Assert.Pass();
        }

    }
}