
using OpenQA.Selenium;


namespace UnderAppLoginTests
{
    public class LoginPage
    {

        public void GoTo()
        {
            Browser.GoTo("https://agent.under.taxi/#/login", false);
        }

        public void LogIn(string email, string password)
        {

            var userEmailField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/div[2]/div/div[2]/div[2]/input"));
            userEmailField.SendKeys(email);

            var userPasswordField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/div[2]/div/div[2]/div[3]/input"));
            userPasswordField.SendKeys(password);

            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/div[2]/div/div[2]/div[4]/div[2]/button")).Click();

        }
    }
}
