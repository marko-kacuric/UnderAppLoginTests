
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
            string issueMessage = "@---------------------@User not loged in!@Expected result: User is loged in successfuly and Taxi agent Control Center page is opened.@Actual result: User has failed to log in.@---------------------";
            issueMessage = issueMessage.Replace("@", "\n");
            string password = "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß";

            Pages.Login.GoTo();
            Pages.Login.LogIn("marko.kacuric@p3-group.commm", password);
            try
            {
                Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[1]/under-side-panel/div/div[2]");
            }
            catch(WebDriverTimeoutException)
            {
                Assert.AreEqual("User Loged In", "User Timed Out", issueMessage);
            }

            string alertTitle = "TAXI AGENT";
            string alertMsg = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[1]/under-side-panel/div/div[2]")).Text;
            
            Assert.AreEqual(alertTitle, alertMsg, issueMessage);

        }
    }
}
