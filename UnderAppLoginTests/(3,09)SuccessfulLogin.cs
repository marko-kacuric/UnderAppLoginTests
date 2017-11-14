
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace UnderAppLoginTests
{
    [TestClass]
    public class SuccessfulLogin_3_09_ : TestBase
    {
        [TestMethod]
        public void _3_09_SuccessfulLogin()
        {
            string password = "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß";
            Pages.Login.GoTo();
            Pages.Login.LogIn("marko.kacuric@p3-group.commm", password);
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[1]/under-side-panel/div/div[2]");
            string alertTitle = "TAXI AGENT";
            string alertMsg = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[1]/under-side-panel/div/div[2]")).Text;
            Assert.AreEqual(alertTitle, alertMsg, "Redirected to the wrong page. Something went wrong.");
        }
    }
}
