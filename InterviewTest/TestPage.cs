using System;
using OpenQA.Selenium;

namespace InterviewTest
{
    public class TestPage : BasePage
    {
        private static String testButton = "//a[@id='site']";

        public TestPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement getButton()
        {
            return base.getElement(testButton);
        }
    }
}
