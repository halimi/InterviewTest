using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace InterviewTest
{
    [Binding]
    public class InterviewTestSteps
    {

        IWebDriver driver;
        IWebElement testButton;
        IWebElement homeButton;
        IWebElement formButton;
        IWebElement errorButton;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
        }

        [Given(@"user is on the Form page")]
        public void GivenUserIsOnTheFormPage()
        {
            driver.Url = "http://uitest.duodecadits.com/form.html";
        }
        
        [Given(@"user is on the landing page")]
        [Given(@"user is on the Home page")]
        public void GivenUserIsOnTheHomePage()
        {
            driver.Url = "http://uitest.duodecadits.com";
        }

        [Given(@"the Home button is available")]
        public void GivenTheHomeButtonIsAvailable()
        {
            homeButton = driver.FindElement(By.XPath("//a[@id='home']"));
        }

        [Given(@"the UI Testing button is available")]
        public void GivenTheUITestingButtonIsAvailable()
        {
            testButton = driver.FindElement(By.XPath("//a[@id='site']"));
        }

        [Given(@"the Form button is available")]
        public void GivenTheFormButtonIsAvailable()
        {
            formButton = driver.FindElement(By.XPath("//a[@id='form']"));
        }
        
        [Given(@"the Error button is available")]
        public void GivenTheErrorButtonIsAvailable()
        {
            errorButton = driver.FindElement(By.XPath("//a[@id='error']"));
        }
        
        [When(@"user clicks to the Home button")]
        public void WhenUserClicksToTheHomeButton()
        {
            homeButton.Click();
        }

        [When(@"user clicks to the UI Testing button")]
        public void WhenUserClicksToTheUITestingButton()
        {
            testButton.Click();
        }

        [When(@"user clicks to the Form button")]
        public void WhenUserClicksToTheFormButton()
        {
            formButton.Click();
        }
        
        [When(@"user clicks to the Error button")]
        public void WhenUserClicksToTheErrorButton()
        {
            errorButton.Click();
        }

        [When(@"user type (.*) to the input field")]
        public void WhenUserTypeToTheInputField(string inputText)
        {
            driver.FindElement(By.XPath("//input[@id='hello-input']")).SendKeys(inputText);
        }
        
        [When(@"submit the form")]
        public void WhenSubmitTheForm()
        {
            driver.FindElement(By.XPath("//button[@id='hello-submit']")).Submit();
        }
        
        [Then(@"the Home button is active")]
        public void ThenTheHomeButtonIsActive()
        {
            Assert.IsNotNull(driver.FindElement(By.XPath("//li[@class='active']/a[@id='home']")));
        }

        [Then(@"the Home page loads")]
        public void ThenTheHomePageLoads()
        {
            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//img[@id='dh_logo']")));
        }

        [Then(@"the Form page loads")]
        public void ThenTheFormPageLoads()
        {
            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='hello-input']")));
        }
        
        [Then(@"the Form button is active")]
        public void ThenTheFormButtonIsActive()
        {
            Assert.IsNotNull(driver.FindElement(By.XPath("//li[@class='active']/a[@id='form']")));
        }

        [Then(@"the title is ""(.*)""")]
        public void ThenTheTitleIs(string title)
        {
            String actualTitle = driver.Title;
            Assert.AreEqual(title, actualTitle);
        }

        [Then(@"The Company Logo is visible on the page")]
        public void ThenTheCompanyLogoIsVisibleOnThePage()
        {
            Assert.IsNotNull(driver.FindElement(By.XPath("//img[@id='dh_logo']")));
        }

        [Then(@"user get a (.*) HTTP response code")]
        public void ThenUserGetAHTTPResponseCode(int errorCode)
        {
            Assert.IsNotNull(driver.FindElement(By.XPath(String.Format("//h1[contains(.,'{0} Error: File not found :-(')]", errorCode))));
        }
        
        [Then(@"""(.*)"" text is visible on the Home page in (.*) tag")]
        public void ThenTextIsVisibleOnTheHomePage(string text, string tag)
        {
            IWebElement pageText = driver.FindElement(By.XPath(String.Format("//{0}[contains(.,'{1}')]", tag, text)));
            String actualTag = pageText.TagName;
            Assert.AreEqual(actualTag, tag);
        }
        
        [Then(@"a form is visible")]
        public void ThenAFormIsVisible()
        {
            Assert.IsNotNull(driver.FindElement(By.XPath("//input[@id='hello-input']")));
        }
        
        [Then(@"one input box is visible on the page")]
        public void ThenOneInputBoxIsVisibleOnThePage()
        {
            Assert.IsNotNull(driver.FindElement(By.XPath("//input[@id='hello-input']")));
        }
        
        [Then(@"one submit button is visible on the page")]
        public void ThenOneSubmitButtonIsVisibleOnThePage()
        {
            Assert.IsNotNull(driver.FindElement(By.XPath("//button[@id='hello-submit']")));
        }
        
        [Then(@"the page redirected to the Hello page")]
        public void ThenThePageRedirectedToTheHelloPage()
        {
            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h1[@id='hello-text']")));
            Assert.IsNotNull(driver.FindElement(By.XPath("//h1[@id='hello-text']")));
        }

        [Then(@"the following text is appear (.*)")]
        public void ThenTheFollowingTextIsAppear(string text)
        {
            String actualText = driver.FindElement(By.XPath("//h1[@id='hello-text']")).Text;
            Assert.AreEqual(text, actualText);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }
    }
}
