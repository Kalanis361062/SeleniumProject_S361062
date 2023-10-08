using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Source.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "username_id")]
        private IWebElement _usernameTextBox;

        [FindsBy(How = How.Id, Using = "password_id")]
        private IWebElement _passwordTextBox;

        [FindsBy(How = How.Id, Using = "login-btn")]
        private IWebElement _signinButton;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Login()
        {
            _usernameTextBox.SendKeys("");
            _passwordTextBox.SendKeys("");
            _signinButton.Click();
        }
    }
}
