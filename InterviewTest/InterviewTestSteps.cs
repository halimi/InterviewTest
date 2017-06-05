using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace InterviewTest
{
    [Binding]
    public class InterviewTestSteps
    {

        IWebDriver driver;
        BasePage basePage;
        HomePage homePage;
        FormPage formPage;
        TestPage testPage;
        ErrorPage errorPage;
        HelloPage helloPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            basePage = new BasePage(driver);
            homePage = new HomePage(driver);
            formPage = new FormPage(driver);
            testPage = new TestPage(driver);
            errorPage = new ErrorPage(driver);
            helloPage = new HelloPage(driver);
        }

        [Given(@"user is on the Form page")]
        public void GivenUserIsOnTheFormPage()
        {
            formPage.goToPage();
        }
        
        [Given(@"user is on the landing page")]
        [Given(@"user is on the Home page")]
        public void GivenUserIsOnTheHomePage()
        {
            homePage.goToPage();
        }

        [Given(@"the Home button is available")]
        public void GivenTheHomeButtonIsAvailable()
        {
            homePage.getButton();
        }

        [Given(@"the UI Testing button is available")]
        public void GivenTheUITestingButtonIsAvailable()
        {
            testPage.getButton();
        }

        [Given(@"the Form button is available")]
        public void GivenTheFormButtonIsAvailable()
        {
            formPage.getButton();
        }
        
        [Given(@"the Error button is available")]
        public void GivenTheErrorButtonIsAvailable()
        {
            errorPage.getButton();
        }
        
        [When(@"user clicks to the Home button")]
        public void WhenUserClicksToTheHomeButton()
        {
            homePage.getButton().Click();
        }

        [When(@"user clicks to the UI Testing button")]
        public void WhenUserClicksToTheUITestingButton()
        {
            testPage.getButton().Click();
        }

        [When(@"user clicks to the Form button")]
        public void WhenUserClicksToTheFormButton()
        {
            formPage.getButton().Click();
        }
        
        [When(@"user clicks to the Error button")]
        public void WhenUserClicksToTheErrorButton()
        {
            errorPage.getButton().Click();
        }

        [When(@"user type (.*) to the input field")]
        public void WhenUserTypeToTheInputField(string inputText)
        {
            formPage.getInputField().SendKeys(inputText);
        }
        
        [When(@"submit the form")]
        public void WhenSubmitTheForm()
        {
            formPage.getSubmitButton().Submit();
        }
        
        [Then(@"the Home button is active")]
        public void ThenTheHomeButtonIsActive()
        {
            Assert.IsTrue(homePage.isHomeButtonActive());
        }

        [Then(@"the Home page loads")]
        public void ThenTheHomePageLoads()
        {
            Assert.IsTrue(homePage.isHomePageLoaded());
        }

        [Then(@"the Form page loads")]
        public void ThenTheFormPageLoads()
        {
            Assert.IsTrue(formPage.isFormPageLoaded());
        }
        
        [Then(@"the Form button is active")]
        public void ThenTheFormButtonIsActive()
        {
            Assert.IsTrue(formPage.isFormButtonActive());
        }

        [Then(@"the title is ""(.*)""")]
        public void ThenTheTitleIs(string title)
        {
            Assert.AreEqual(title, basePage.getTitle());
        }

        [Then(@"The Company Logo is visible on the page")]
        public void ThenTheCompanyLogoIsVisibleOnThePage()
        {
            Assert.IsTrue(basePage.isLogoVisible());
        }

        [Then(@"user get a (.*) HTTP response code")]
        public void ThenUserGetAHTTPResponseCode(int errorCode)
        {
            Assert.IsTrue(errorPage.isErrorCodeVisible(errorCode));
        }
        
        [Then(@"""(.*)"" text is visible on the Home page in (.*) tag")]
        public void ThenTextIsVisibleOnTheHomePage(string text, string tag)
        {
            Assert.IsTrue(homePage.isTextVisibleInTag(text, tag));
        }
        
        [Then(@"a form is visible")]
        public void ThenAFormIsVisible()
        {
            Assert.IsTrue(formPage.isFormVisible());
        }
        
        [Then(@"one input box is visible on the page")]
        public void ThenOneInputBoxIsVisibleOnThePage()
        {
            Assert.IsTrue(formPage.isInputBoxVisible());
        }
        
        [Then(@"one submit button is visible on the page")]
        public void ThenOneSubmitButtonIsVisibleOnThePage()
        {
            Assert.IsTrue(formPage.isSubmitButtonVisible());
        }
        
        [Then(@"the page redirected to the Hello page")]
        public void ThenThePageRedirectedToTheHelloPage()
        {
            Assert.IsTrue(helloPage.isHelloPageLoaded());
        }

        [Then(@"the following text is appear (.*)")]
        public void ThenTheFollowingTextIsAppear(string text)
        {
            String actualText = helloPage.getText();
            Assert.AreEqual(text, actualText);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }
    }
}
