
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnderAppLoginTests
{
    [TestClass]
    public class TestBase
    {
        [TestInitialize]
        public void Initialize()
        {
            Browser.Initialize();
        }

        [TestCleanup]

        public void cleanUp()
        {
            Browser.Close();
            Browser.Quit();
        }
    }
}

