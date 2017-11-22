
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace UnderAppLoginTests
{
    [TestClass]
    public class ValidEmailEmptyPassword_3_07_ : TestBase
    {
        [TestMethod]
        public void _3_07_ValidEmailEmptyPassword()
        {
            Pages.Login.GoTo();
            Pages.Login.LogIn("marko.kacuric@p3-group.com", "");

            Browser.WaitForElement("/html/body/under-agent/under-login/div/under-modal-dialog[2]/div/div/div/div/div[2]/div");
            string alertTitle = "Please enter valid password!";
            string alertMsg = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/under-modal-dialog[2]/div/div/div/div/div[2]/div")).Text;
            string issueMessage = "@---------------------@Wrong error message is presented!@Expected result: " + alertTitle + "@Actual result: " + alertMsg + "@---------------------";
            issueMessage = issueMessage.Replace("@", "\n");
            Assert.AreEqual(alertTitle, alertMsg, issueMessage);
        }
    }
}
