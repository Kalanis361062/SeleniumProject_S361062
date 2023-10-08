using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumProject.Source.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumProject.Test
{
    public class LoginTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }

        [Test]
        public void SignIn()
        {
            //LoginPage loginPage = new LoginPage(IWebDriver);
            _driver.Navigate().GoToUrl("");
           // loginPage.Login();
        }
    }
}
