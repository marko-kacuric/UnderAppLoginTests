
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace UnderAppLoginTests
{
    [TestClass]
    public class EmptyEmailValidPassword__3_05_ : TestBase
    {
        [TestMethod]
        public void _3_05_EmptyEmailValidPassword()
        {
            Pages.Login.GoTo();
            Pages.Login.LogIn("", "Test1234!");

            Browser.WaitForElement("/html/body/under-agent/under-login/div/under-modal-dialog[1]/div/div/div/div");
            string alertTitle = "Please enter valid email";
            Browser.WaitForElement("/html/body/under-agent/under-login/div/under-modal-dialog[1]/div/div/div/div/div[2]");
            IWebElement alert = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/under-modal-dialog[1]/div/div/div/div/div[2]/div"));
            Assert.IsTrue(alert.Text.Contains(alertTitle));
        }
    }
}
