
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;

namespace UnderAppLoginTests
{
    [TestClass]
    public class EmptyLoginFields_3_04_ : TestBase
    {
        [TestMethod]
        public void _3_04_EmptyLoginFields()
        {

            Pages.Login.GoTo();
            Pages.Login.LogIn("", "");

            Thread.Sleep(500);
            Browser.WaitForElement("/html/body/under-agent/under-login/div/under-modal-dialog[1]/div/div/div/div");
            string alertTitle = "Please enter valid email";
            string alertMsg = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/under-modal-dialog[1]/div/div/div/div/div[2]")).Text;
            string issueMessage = "@---------------------@Wrong error message is presented!@Expected result: " + alertTitle + "@Actual result: " + alertMsg + "@---------------------";
            issueMessage = issueMessage.Replace("@", "\n");
            Assert.AreEqual(alertTitle, alertMsg, issueMessage);
        }
    }
}
