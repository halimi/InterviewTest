using System;
using OpenQA.Selenium;

namespace InterviewTest
{
    public class HomePage: BasePage
    {
        private const String homeUrl = "http://uitest.duodecadits.com";
        private const String homeButton = "//a[@id='home']";
        private const String activeButton = "//li[@class='active']/a[@id='home']";
        private const String logo = "//img[@id='dh_logo']";

        public HomePage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public void goToPage()
        {
            base.goToPage(homeUrl); 
        }

        public IWebElement getButton()
        {
            return base.getElement(homeButton);
        }

        public Boolean isHomeButtonActive()
        {
            return base.isVisible(activeButton);
        }

        public Boolean isHomePageLoaded()
        {
            return base.isPageLoaded(logo);
        }

        public Boolean isTextVisibleInTag(String text, String tag)
        {
            return base.isVisible(String.Format("//{0}[contains(.,'{1}')]", tag, text));
        }
    }
}
