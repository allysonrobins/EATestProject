using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using EAEmployeeTest.Pages;
using EAAutoFramework.Base;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1
    {
        string url = "http://localhost/";

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);

            Login();

            DriverContext.Driver.Close();
        }

        public void Login()
        {
            LoginPage page = new LoginPage();

            page.lnkLogin.Click();
            page.txtUserName.SendKeys("admin");
            page.txtPassword.SendKeys("password");
            page.btnLogin.Submit();
        }
    }
}
