using System;
using OpenQA.Selenium;

namespace InterviewTest
{
    public class HelloPage : BasePage
    {
        private const String helloText = "//h1[@id='hello-text']";

        public HelloPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public Boolean isHelloPageLoaded()
        {
            return base.isPageLoaded(helloText);
        }

        public String getText()
        {
            return base.getElement(helloText).Text;
        }
    }
}
