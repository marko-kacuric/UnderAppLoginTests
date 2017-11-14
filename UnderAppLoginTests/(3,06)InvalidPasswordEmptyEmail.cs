
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace UnderAppLoginTests
{
    [TestClass]
    public class InvalidPasswordEmptyEmail_3_06_ : TestBase
    {
        [TestMethod]
        public void _3_06_InvalidPasswordEmptyEmail()
        {
            Pages.Login.GoTo();
            Pages.Login.LogIn("", "Test23!");

            Browser.WaitForElement("/html/body/under-agent/under-login/div/under-modal-dialog[1]/div/div/div/div");
            string alertTitle = "Please enter valid email";
            string alertMsg = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/under-modal-dialog[1]/div/div/div/div/div[2]")).Text;
            Assert.AreEqual(alertTitle, alertMsg, "Wrong error message is presented.");
        }
    }
}
