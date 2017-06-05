using System;
using OpenQA.Selenium;

namespace InterviewTest
{
    public class ErrorPage : BasePage
    {
        private static String errorButton = "//a[@id='error']";

        public ErrorPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement getButton()
        {
            return base.getElement(errorButton);
        }

        public Boolean isErrorCodeVisible(int errorCode)
        {
            return base.isVisible(String.Format("//h1[contains(.,'{0} Error: File not found :-(')]", errorCode));
        }
    }
}
