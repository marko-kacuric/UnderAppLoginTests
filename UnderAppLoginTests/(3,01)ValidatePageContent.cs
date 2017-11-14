
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderAppLoginTests
{
    [TestClass]
    public class ValidatePageContent_3_01_ : TestBase
    {
        [TestMethod]
        public void _3_01_ValidatePageContent()
        {
            Pages.Login.GoTo();
            string header = "Taxi agent login";
            string pageHeader = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/div[2]/div/div[2]/div[1]")).Text;
            Assert.AreEqual(header, pageHeader, "Redirected to wrong page, something went wrong!");
        }
    }
}
