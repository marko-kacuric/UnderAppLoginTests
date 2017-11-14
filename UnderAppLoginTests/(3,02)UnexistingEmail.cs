
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;


namespace UnderAppLoginTests
{
    [TestClass]
    public class UnexistingEmail_3_02_ : TestBase
    {
        [TestMethod]
        public void _3_02_UnexistingEmail()
        {
            Pages.Login.GoTo();
            Pages.Login.LogIn("testEmail@test.com", "Test1234!");

            Thread.Sleep(350);
            Browser.WaitForElement("/html/body/under-agent/under-login/div/under-modal-dialog[3]/div/div/div/div");
            string alertTitle = "Wrong email or password is sent.";
            string alertMsg = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/under-modal-dialog[3]/div/div/div/div/div[2]/div")).Text;
            Assert.AreEqual(alertTitle, alertMsg, "Wrong error message is presented.");
        }
    }
}
