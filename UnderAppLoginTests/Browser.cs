using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using System.Threading;


namespace UnderAppLoginTests
{

    public enum Drivers
    {
        Chrome
    }
    public static class Browser
    {
        private static IWebDriver driver;

        private static string baseURL = "https://under.taxi";


        public static bool WaitUntilElementIsDisplayed(By element, int timeoutInSeconds)
        {
            for (int i = 0; i < timeoutInSeconds; i++)
            {
                if (ElementIsDisplayed(element))
                {
                    return true;
                }
                Thread.Sleep(1000);
            }
            return false;
        }

        public static ISearchContext Driver { get { return driver; } }

        internal static IWebElement FindElement(By by)
        {
            return driver.FindElement(by);

        }
        internal static IWebDriver GetDriver(Drivers driver)
        {

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var relativePath = @"..\..\..\UnderAppLoginTests\Drivers";
            var chromeDriverPath = Path.GetFullPath(Path.Combine(outPutDirectory, relativePath));
            return new ChromeDriver(chromeDriverPath);
        }

        public static bool ElementIsDisplayed(By element)
        {
            var present = false;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            try
            {
                present = driver.FindElement(element).Displayed;
            }
            catch (NoSuchElementException)
            {
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return present;
        }

        public static bool WaitUntilElementIsEnabled(By element, int timeoutInSeconds)
        {
            for (int i = 0; i < timeoutInSeconds; i++)
            {
                if (ElementIsDisplayed(element))
                {
                    return true;
                }
                Thread.Sleep(1000);
            }
            return false;
        }

        public static void GoTo(string url, bool useBaseURL = true)
        {
            if (useBaseURL)
                driver.Navigate().GoToUrl(string.Format("{0}/{1}", baseURL, url));
            else
                driver.Navigate().GoToUrl(url);

        }
        public static void Initialize()
        {

            driver = GetDriver(Drivers.Chrome);
            GoTo("");
            driver.Manage().Window.Maximize();
        }

        public static void WaitForElement(string locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(locator)));
        }


        public static void Close()
        {
            driver.Close();
        }
        public static void Quit()
        {
            driver.Quit();
        }

    }
}