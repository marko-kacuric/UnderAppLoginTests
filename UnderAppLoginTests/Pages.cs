
using OpenQA.Selenium.Support.PageObjects;


namespace UnderAppLoginTests
{

    public static class Pages
    {
        private static PagesList GetPage<PagesList>() where PagesList : new()
        {
            var page = new PagesList();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static LoginPage Login
        {

            get { return GetPage<LoginPage>(); }
        }
    }
}