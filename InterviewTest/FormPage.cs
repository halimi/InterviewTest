using System;
using OpenQA.Selenium;

namespace InterviewTest
{
    public class FormPage : BasePage
    {
        private const String formUrl = "http://uitest.duodecadits.com/form.html";
        private const String formButton = "//a[@id='form']";
        private const String inputField = "//input[@id='hello-input']";
        private const String submitButton = "//button[@id='hello-submit']";
        private const String activeButton = "//li[@class='active']/a[@id='form']";

        public FormPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public void goToPage()
        {
            base.goToPage(formUrl);
        }

        public IWebElement getButton()
        {
            return base.getElement(formButton);
        }

        public IWebElement getInputField()
        {
            return base.getElement(inputField);
        }

        public IWebElement getSubmitButton()
        {
            return base.getElement(submitButton);
        }

        public Boolean isFormButtonActive()
        {
            return base.isVisible(activeButton);
        }

        public Boolean isFormPageLoaded()
        {
            return base.isPageLoaded(inputField);
        }

        public Boolean isFormVisible()
        {
            return base.isVisible(inputField);
        }

        public Boolean isInputBoxVisible()
        {
            return base.isVisible(inputField);
        }

        public Boolean isSubmitButtonVisible()
        {
            return base.isVisible(submitButton);
        }
    }
}
