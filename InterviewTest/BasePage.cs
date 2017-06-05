using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace InterviewTest
{
    public class BasePage
    {
        public IWebDriver driver;
        private const String logo = "//img[@id='dh_logo']";

        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public void goToPage(String url)
        {
            driver.Url = url;
        }

        public IWebElement getElement(String xpath)
        {
            return driver.FindElement(By.XPath(xpath));
        }

        public void waitToPage(String xpath)
        {
            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
        }

        public String getTitle()
        {
            return driver.Title;
        }

        public Boolean isVisible(String xpath)
        {
            try
            {
                getElement(xpath);
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public Boolean isLogoVisible()
        {
            return isVisible(logo);
        }

        public Boolean isPageLoaded(String xpath)
        {
            try
            {
                waitToPage(xpath);
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }
    }
}
